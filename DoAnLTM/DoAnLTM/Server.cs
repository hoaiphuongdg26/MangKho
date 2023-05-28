using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace DoAnLTM
{
    public partial class Server : Form
    {
        private Point virtualMousePosition = Point.Empty;
        private const int MOUSEEVENTF_MOVE = 0x0001;
        private TcpListener listener;
        private TcpClient client;
        private NetworkStream stream;
        private byte[] buffer;

        private bool isListening = true;
        private bool isConnected = false;

        [DllImport("user32.dll")]
        private static extern bool NativeSetCursorPos(int X, int Y);

        public Server()
        {
            InitializeComponent();

            ptb_mouseCursor.Visible = false;

            string ipAddress = Dns.GetHostEntry(Dns.GetHostName())
                     .AddressList
                     .FirstOrDefault(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                     ?.ToString();

            //Tạo IP Address và Port cho Server
            //IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            int ServerPort = 3000;
            //Khởi tạo lắng nghe kết nối từ Client
            listener = new TcpListener(IPAddress.Any, ServerPort);
            listener.Start();
            DisplayMessage($"Server started on {ipAddress}, listening for connections...");

            //Bắt đầu chấp nhận kết nối từ Client
            listener.BeginAcceptTcpClient(AcceptCallBack, null);
        }
        private void SetCursorPos(int x, int y)
        {
            Invoke((Action)(() =>
            {
                virtualMousePosition = new Point(x, y);
                ptb_mouseCursor.Location = virtualMousePosition;
            }));
        }
        private void DisplayMessage(string message)
        {
            if (txt_ServerLog.IsDisposed)
                return;
            if (txt_ServerLog.InvokeRequired)
            {
                Invoke((Action)(() =>
                {
                    txt_ServerLog.Text = "";
                    txt_ServerLog.Text = message;
                }));
            }
            else
            {
                txt_ServerLog.AppendText(message + "\n");
            }
        }
        private void AcceptCallBack(IAsyncResult ar)
        {
            if (isListening)
            {
                // Bắt đầu chấp nhận kết nối từ Client
                listener.BeginAcceptTcpClient(AcceptCallBack, null);
                Invoke((Action)(() =>
                {
                    ptb_mouseCursor.Visible = true;
                }));

                // Cập nhật trạng thái kết nối
                isConnected = true;

                string ipAddress = Dns.GetHostEntry(Dns.GetHostName())
                     .AddressList
                     .FirstOrDefault(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                     ?.ToString();
                DisplayMessage($"Connection accepted from {ipAddress}:3000\n");

                client = listener.EndAcceptTcpClient(ar);
                stream = client.GetStream();
                // Tạo kích thước cho buffer là 8 byte, 4 byte cho toạ độ X, 4 byte cho toạ độ Y
                buffer = new byte[8];

                // Bắt đầu đọc toạ độ chuột
                stream.BeginRead(buffer, 0, buffer.Length, ReadCallback, null);

                // Cập nhật vị trí ban đầu của con chuột
                Invoke((Action)(() =>
                {
                    ptb_mouseCursor.Location = Cursor.Position;
                    ptb_mouseCursor.Visible = true;
                }));
            }
            else
            {
                DisconnectClient();
            }
        }
        private void ReadCallback(IAsyncResult ar)
        {
            try
            {
                int bytesRead = stream.EndRead(ar);
                if (bytesRead == 0)
                {
                    DisconnectClient();
                    return;
                }
                // Đọc tọa độ chuột từ client
                int mouseX = BitConverter.ToInt32(buffer, 4);
                int mouseY = BitConverter.ToInt32(buffer, 0);

                /*Invoke((Action)(() =>
                {
                    label1.Text = $"X: {mouseX}, Y: {mouseY}";
                }));*/

                // Di chuyển chuột trên máy chủ
                Invoke((Action)(() => SetCursorPos(mouseX, mouseY)));

                // Tiếp tục đọc tọa độ chuột từ client
                stream.BeginRead(buffer, 0, buffer.Length, ReadCallback, null);
            }
            catch (IOException)
            {
                DisconnectClient();
                isListening = false;
            }
        }
        private void DisconnectClient()
        {
            try
            {
                Invoke((Action)(() =>
                {
                    ptb_mouseCursor.Visible = false;
                }));
                DisplayMessage("No connection. Listening for connections...");
                // Đóng kết nối và dừng lắng nghe
                stream.Close();
                client.Close();
                isConnected = false;
            }
            catch (Exception ex)
            {
                DisplayMessage(ex.ToString());
            }
        }
        private void Server_Load(object sender, EventArgs e)
        {
            ptb_mouseCursor.Visible = false;
        }

        private void Server_MouseEnter(object sender, EventArgs e)
        {
            Invoke((Action)(() => ptb_mouseCursor.Location = virtualMousePosition));
        }
        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isConnected)
            {
                MessageBox.Show("Please disconnect before exiting!", "UNABLE TO EXIT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //K đóng form nữa
                e.Cancel = true;
            }
            else
            {
                listener.Stop();
                isListening = false;
            }

            // Enable lại nút Server trong form Dashboard
            if (Application.OpenForms["Dashboard"] is Dashboard dashboardForm)
            {
                dashboardForm.buttonServer(true);
            }
        }
    }
}