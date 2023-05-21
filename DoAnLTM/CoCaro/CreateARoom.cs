using System;
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

namespace CoCaro
{
    public partial class CreateARoom : Form
    {
        private TcpListener listener;
        private TcpClient client;
        private NetworkStream stream;
        public CreateARoom()
        {
            InitializeComponent();
        }

        private void btn_CreateARoom_Click(object sender, EventArgs e)
        {
            //Mở form của người chơi đóng vai trò là chủ phòng
            Room_SERVER newRoom = new Room_SERVER();
            newRoom.Show();
            this.Close();

            /*//Tạo server mới
            IPAddress ipAddress = IPAddress.Parse(txt_IPServer.Text);
            int ServerPort = 3030;

            //Khởi tạo lắng nghe kết nối từ Client
            listener = new TcpListener(IPAddress.Any, ServerPort);
            listener.Start();

            //Bắt đầu chấp nhận kết nối từ Client
            listener.BeginAcceptTcpClient(AcceptCallBack, null);*/
        }
        private void AcceptCallBack(IAsyncResult ar)
        {
            client = listener.EndAcceptTcpClient(ar);
            stream = client.GetStream();
        }
    }
}
