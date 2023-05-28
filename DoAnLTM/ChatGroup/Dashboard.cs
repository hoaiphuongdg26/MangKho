using System.Net.Sockets;

namespace ChatGroup
{
    public partial class Dashboard : Form
    {
        private Server server;
        public Dashboard()
        {
            InitializeComponent();
        }
        private void TCPServer_Click(object sender, EventArgs e)
        {
            server = new Server();
            server.Show();
            btn_TCPServer(false);
        }

        private void TCPClient_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }
        public void btn_TCPServer(bool status)
        {
            TCPServer.Enabled = status;
        }
    }
}