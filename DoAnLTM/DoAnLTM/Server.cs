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
        //private bool isMouseCursorVisible = false;
        private Point virtualMousePosition = Point.Empty;
        private const int MOUSEEVENTF_MOVE = 0x0001;
        private TcpListener listener;
        private TcpClient client;
        private NetworkStream stream;
        private byte[] buffer;
        //test
        private bool isListening = true;


        //mới thêm 
        private bool isConnected = false;


        [DllImport("user32.dll")]
        private static extern bool NativeSetCursorPos(int X, int Y);

        public Server()
        {
            InitializeComponent();

            ptb_mouseCursor.Visible = false;

            //Tạo IP Address và Port cho Server
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            int ServerPort = 3000;
            //Khởi tạo lắng nghe kết nối từ Client
            listener = new TcpListener(IPAddress.Any, ServerPort);
            listener.Start();
            MessageBox.Show("Server started, listening for connections...", "Listen", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Bắt đầu chấp nhận kết nối từ Client
            listener.BeginAcceptTcpClient(AcceptCallBack, null);
        }
        private void SetCursorPos(int x, int y)
        {
            /* Invoke((Action)(() => virtualMousePosition = new Point(x, y)));
             Invoke((Action)(() => ptb_mouseCursor.Location = virtualMousePosition));*/
            Invoke((Action)(() =>
            {
                virtualMousePosition = new Point(x, y);
                ptb_mouseCursor.Location = virtualMousePosition;

                // Cập nhật toạ độ chuột trên Label
                //lbl_MousePosition.Text = $"X: {x}, Y: {y}";
            }));
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
            if (isListening)
            {
                //test mới thêm
                // Bắt đầu chấp nhận kết nối từ Client
                listener.BeginAcceptTcpClient(AcceptCallBack, null);
                Invoke((Action)(() =>
                {
                    ptb_mouseCursor.Visible = true;
                }));

                // Cập nhật trạng thái kết nối
                isConnected = true;

                //MessageBox.Show("Connection accepted from 127.0.0.1:3000\n", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayMessage("Connection accepted from 127.0.0.1:3000\n");
                //DisplayMessage("Conneted...");

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
        }
        private void ReadCallback(IAsyncResult ar)
        {
            try
            {
                int bytesRead = stream.EndRead(ar);
                if (bytesRead == 0)
                    return;

                // Đọc tọa độ chuột từ client

                int mouseX = BitConverter.ToInt32(buffer, 4);
                int mouseY = BitConverter.ToInt32(buffer, 0);
                // Di chuyển chuột trên máy chủ
                Invoke((Action)(() => SetCursorPos(mouseX, mouseY)));

                // Tiếp tục đọc tọa độ chuột từ client
                stream.BeginRead(buffer, 0, buffer.Length, ReadCallback, null);
            }
            catch (IOException)
            {
                Invoke((Action)(() =>
                {
                    ptb_mouseCursor.Visible = false;
                }));
                DisconnectClient();
            }
        }
        private void DisconnectClient()
        {
            // Đóng kết nối và dừng lắng nghe
            stream.Close();
            client.Close();
            //listener.Stop();
        }
        private void Server_Load(object sender, EventArgs e)
        {
            ptb_mouseCursor.Visible = false;
        }

        private void Server_MouseEnter(object sender, EventArgs e)
        {
            //ptb_mouseCursor.Visible = true;
            Invoke((Action)(() => ptb_mouseCursor.Location = virtualMousePosition));
        }

        private void Server_MouseLeave(object sender, EventArgs e)
        {
            //ptb_mouseCursor.Visible = false;
        }
        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            listener.Stop();
            isListening = false;
        }
    }
}
