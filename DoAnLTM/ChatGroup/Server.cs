using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatGroup
{
    public partial class Server : Form
    {
        private TcpListener server;
        private Thread listenThread;
        private List<TcpClient> connectedClients = new List<TcpClient>();

        //Danh sách lưu tên người dùng với mỗi client được kết nối
        private ConcurrentDictionary<TcpClient, string> userNames = new ConcurrentDictionary<TcpClient, string>();
        //Danh sách lưu tên file và nội dung file
        private ConcurrentDictionary<string, string> files = new ConcurrentDictionary<string, string>();

        //Dùng để kiểm tra xem Server có đang chạy hay không
        private bool isServerRunning;

        public Server()
        {
            InitializeComponent();
        }
        private void Log(string message)
        {
            if (rtb_Server.IsDisposed) return;
            if (rtb_Server.InvokeRequired)
            {
                rtb_Server.Invoke(new Action<string>(Log), message);
            }
            else
            {
                //serverTextBox.AppendText(message);
                string[] messageParts = message.Split(": ");
                if (messageParts.Length == 2)
                {
                    Font boldFont = new Font(rtb_Server.Font, FontStyle.Bold);
                    rtb_Server.SelectionFont = boldFont;
                    rtb_Server.AppendText(messageParts[0]+": ");

                    Font ItalicFont = new Font(rtb_Server.Font, FontStyle.Italic);
                    rtb_Server.SelectionFont = ItalicFont;
                    rtb_Server.AppendText($"({DateTime.Now})");

                    rtb_Server.SelectionFont = rtb_Server.Font; // Đặt lại font gốc
                    rtb_Server.AppendText(": " + messageParts[1] + "\n");
                }
                else
                {
                    rtb_Server.AppendText(message + "\n");
                }
            }
        }
        private void Listen_Click(object sender, EventArgs e)
        {
            int port = 8080;
            server = new TcpListener(IPAddress.Any, port);
            //Server bắt đầu lắng nghe
            server.Start();
            isServerRunning = true;

            Log($"Server started on 127.0.0.1:{port}\n");

            //Tạo thread để chấp nhận kết nối từ các Client
            listenThread = new Thread(AcceptClients);
            listenThread.Start();

            //Ẩn/hiện các button
            Listen.Enabled = false;
            StopListen.Enabled = true;
        }
        private void AcceptClients()
        {
            while (isServerRunning)
            {
                try
                {
                    //Chấp nhận kết nối từ Client
                    TcpClient client = server.AcceptTcpClient();

                    // Thêm client vào danh sách
                    lock (connectedClients)
                    {
                        connectedClients.Add(client);
                    }
                    //Đọc tên người dùng
                    NetworkStream stream = client.GetStream();
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string userName = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    userNames[client] = userName;
                    Log($"[NEW USER] - {userName} connected from: {client.Client.RemoteEndPoint}.");
                    SendMessageToAllClients(client, $"[NEW USER] - {userName} is connected.");

                    //Tạo thread mới để nhận tin nhắn từ Client vừa kết nối
                    Thread receiveMessagesThread = new Thread(() => ReceiveMessages(client));
                    receiveMessagesThread.Start();
                }
                catch (Exception ex)
                {
                    if (!isServerRunning)
                    {
                        break;
                    }
                    Log($"Error accepting client: {ex.Message}");
                    continue;
                }
            }
        }
        //Hàm này để nhận tin nhắn
        private void ReceiveMessages(TcpClient client)
        {
            //Tạo 1 stream để đọc và ghi tin nhắn gửi từ Client
            using (NetworkStream stream = client.GetStream())
            {
                //Mảng này để đọc dữ liệu từ stream đó
                byte[] buffer = new byte[1024];

                //Nếu vẫn còn kết nối thì vẫn nhận tin nhắn
                while (client.Connected)
                {
                    if (stream.DataAvailable)
                    {
                        //Đọc dữ liệu từ stream vào mảng byte
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        if (bytesRead == 0)
                        {
                            break;
                        }

                        //Chuyển dữ liệu đọc thành chuỗi
                        string userName = userNames[client];
                        string receivedData = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                        if (receivedData.Contains("[FILE]"))
                        {
                            string[] arr_message = receivedData.Split($"[FILE] - ");
                            int colonIndex = arr_message[1].IndexOf(":");
                            string fileName = arr_message[1].Substring(0, colonIndex + 1);
                            //byte[] fileContent = buffer.Skip(Encoding.UTF8.GetBytes(arr_message[0]).Length).ToArray();
                            string fileContent = arr_message[1].Substring(colonIndex + 1);
                            files[fileName] = fileContent;

                            //Với tb_Messgae
                            /*Log($"{arr_message[0]}");
                            SendMessageToAllClients(client, $"{arr_message[0]}");*/

                            //Với fileAttach
                            Log(receivedData);
                            SendMessageToAllClients(client, receivedData);
                        }
                        else
                        {
                            //In ra màn hình
                            Log($"{receivedData}");
                            //Gửi tới các client khác nữa
                            SendMessageToAllClients(client, $"{receivedData}");
                        }
                    }
                }
                //Xoá Client khỏi ds

                Log($"Client disconnected: {client.Client.RemoteEndPoint}\n");
                lock (connectedClients)
                {
                    connectedClients.Remove(client);
                }
                client.Close();

                stream.Close();
            }
            
        }
        private async Task SendMessageToAllClients(TcpClient senderClient, string message)
        {
            //Chuyển tin nhắn thành mảng byte
            byte[] buffer = Encoding.UTF8.GetBytes(message);

            //Duyệt qua tất cả các Client trong list để gửi tin nhắn
            foreach (TcpClient client in userNames.Keys)
            {
                NetworkStream stream = client.GetStream();
                await stream.WriteAsync(buffer, 0, buffer.Length);
                
            }
        }
        private void StopListen_Click(object sender, EventArgs e)
        {
            Listen.Enabled = true;
            StopListen.Enabled = false;

            isServerRunning = false;
            //Dừng máy chủ
            server.Stop();
            //Xoá danh sách các Clients đang kết nối
            connectedClients.Clear();

            Log("Server stopped\n");
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Hiển thị cảnh báo yes/no
            DialogResult result = MessageBox.Show("Are you sure you want to close the server?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Nếu người dùng chọn Yes
            if (result == DialogResult.Yes)
            {
                // Ngắt kết nối với tất cả các client
                if (connectedClients.Count > 0)
                {
                    // Duyệt qua danh sách các client và ngắt kết nối với mỗi client
                    foreach (TcpClient client in connectedClients)
                    { 
                        client.Close();
                        client.Dispose();
                    }
                    connectedClients.Clear();
                    server.Stop();
                }
            }
            else
            {
                // Hủy đóng form
                e.Cancel = true;
            }
        }

    }
}
