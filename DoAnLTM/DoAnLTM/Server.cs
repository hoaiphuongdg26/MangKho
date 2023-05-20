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

namespace DoAnLTM
{
    public partial class Server : Form
    {
        private const int MOUSEEVENTF_MOVE = 0x0001;
        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int X, int Y);

        private TcpListener listener;
        private TcpClient client;
        private NetworkStream stream;
        private byte[] buffer;

        public Server()
        {
            InitializeComponent();

            //Tạo IP Address và Port cho Server
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            int ServerPort = 3000;

            //Khởi tạo lắng nghe kết nối từ Client
            listener = new TcpListener(IPAddress.Any, ServerPort);
            listener.Start();

            //Bắt đầu chấp nhận kết nối từ Client
            listener.BeginAcceptTcpClient(AcceptCallBack, null);
        }
        private void DisplayMessage(string message)
        {
            if (txt_ServerLog.InvokeRequired)
            {
                txt_ServerLog.Invoke(new Action<string>(DisplayMessage), new object[] { message });
            }
            else
            {
                txt_ServerLog.AppendText(message + "\n");
            }
        }
        private void AcceptCallBack(IAsyncResult ar)
        {
            DisplayMessage("Server started, listening for connections...\nConnection accepted from 127.0.0.1:8080\n");
            client = listener.EndAcceptTcpClient(ar);
            stream = client.GetStream();
            //Tạo kích thước cho buffer là 8 byte, 4 byte cho toạ độ X, 4 byte cho toạ độ Y
            buffer = new byte[8];

            //Bắt đầu đọc toạ độ chuột từ client
            stream.BeginRead(buffer, 0, buffer.Length, ReadCallback, null);
        }
        private void ReadCallback(IAsyncResult ar)
        {
            try
            {
                int bytesRead = stream.EndRead(ar);
                if (bytesRead == 0)
                    return;

                // Đọc tọa độ chuột từ client
                int mouseX = BitConverter.ToInt32(buffer, 0);
                int mouseY = BitConverter.ToInt32(buffer, 4);

                // Di chuyển chuột trên máy chủ
                SetCursorPos(mouseX, mouseY);

                // Tiếp tục đọc tọa độ chuột từ client
                stream.BeginRead(buffer, 0, buffer.Length, ReadCallback, null);
            }
            catch (IOException)
            {
                DisconnectClient();
            }
        }
        private void DisconnectClient()
        {
            // Đóng kết nối và dừng lắng nghe
            stream.Close();
            client.Close();
            listener.Stop();

            // Hiển thị thông báo client đã ngắt kết nối
            MessageBox.Show("Client disconnected.");
        }


        private void Server_Load(object sender, EventArgs e)
        {

        }
    }
}
