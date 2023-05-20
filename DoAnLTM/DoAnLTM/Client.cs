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

namespace DoAnLTM
{
    public partial class Client : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private bool isConnected = false;

        public event EventHandler<Point> MouseMoved;

        public Client()
        {
            InitializeComponent();
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

                // Lắng nghe sự kiện di chuyển chuột
                MouseMove += Client_MouseMove;

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
            // Đóng kết nối và xóa sự kiện di chuyển chuột
            if (stream != null)
                stream.Close();
            if (client != null)
                client.Close();
            MouseMove -= Client_MouseMove;

            // Cập nhật trạng thái kết nối
            isConnected = false;
            bnt_Connect.Enabled = true;
            bnt_Disconnect.Enabled = false;
        }

        private void Client_MouseMove(object sender, MouseEventArgs e)
        {
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
        }
    }
}
