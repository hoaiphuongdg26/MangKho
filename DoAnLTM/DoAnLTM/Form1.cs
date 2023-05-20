namespace DoAnLTM
{
    public partial class Form1 : Form
    {
        private Server server;
        private Client client;
        public Form1()
        {
            InitializeComponent();
        }

        private void bnt_Server_Click(object sender, EventArgs e)
        {
            server = new Server();
            server.Show();
        }

        private void bnt_Client_Click(object sender, EventArgs e)
        {
            client = new Client();
            client.Show();
        }
        private void Client_MouseMoved(object sender, Point location)
        {
            server.UpdateMousePosition(location);
        }
    }
}