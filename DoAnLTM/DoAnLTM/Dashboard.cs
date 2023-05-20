namespace DoAnLTM
{
    public partial class Dashboard : Form
    {
        private Server server;
        private Client client;
        public Dashboard()
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
    }
}