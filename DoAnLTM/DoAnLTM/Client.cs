using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace DoAnLTM
{
    public partial class Client : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private bool isConnected = false;

        private const int WM_MOUSEMOVE = 0x0200;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        public Client()
        {
            InitializeComponent();
            ptb_mouseCursor.Visible = false;
        }

        private void bnt_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                // Kết nối tới địa chỉ IP và cổng của server
                string serverIP = txt_ServerIP.Text;
                int serverPort = int.Parse(txt_Port.Text);
                client = new TcpClient(serverIP, serverPort);
                stream = client.GetStream();

                // Chỉ thêm sự kiện di chuyển chuột nếu isConnected là false
                if (!isConnected)
                    MouseMove += Client_MouseMove;

                // Hiển thị PictureBox
                ptb_mouseCursor.Visible = true;

                // Cập nhật trạng thái kết nối
                isConnected = true;
                bnt_Connect.Enabled = false;
                bnt_Disconnect.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối tới server: " + ex.Message);
            }
        }

        private void bnt_Disconnect_Click(object sender, EventArgs e)
        {
            // Đóng kết nối 
            if (stream != null)
                stream.Close();
            if (client != null)
                client.Close();

            // Xóa sự kiện di chuyển chuột chỉ khi trạng thái kết nối là true
            if (isConnected)
                MouseMove -= Client_MouseMove;

            // Cập nhật trạng thái kết nối
            isConnected = false;
            bnt_Connect.Enabled = true;
            bnt_Disconnect.Enabled = false;
        }

        private void Client_MouseMove(object sender, MouseEventArgs e)
        {
            ptb_mouseCursor.Location = e.Location;
            try
            {
                if (isConnected)
                {
                    // Gửi tọa độ chuột tới server
                    byte[] buffer = BitConverter.GetBytes(e.X);
                    stream.Write(buffer, 0, buffer.Length);
                    buffer = BitConverter.GetBytes(e.Y);
                    stream.Write(buffer, 0, buffer.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi tọa độ chuột tới server: " + ex.Message);
            }
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            bnt_Disconnect_Click(sender, e);

            // Enable lại nút Client trong form Dashboard
            if (Application.OpenForms["Dashboard"] is Dashboard dashboardForm)
            {
                dashboardForm.buttonClient(true);
            }
        }
    }
}