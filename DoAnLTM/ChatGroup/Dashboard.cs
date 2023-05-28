using System.Net.Sockets;

namespace ChatGroup
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void TCPServer_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            TCPClient.Enabled = true;
            server.Show();
        }

        private void TCPClient_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }
    }
}