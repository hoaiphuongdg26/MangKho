namespace DoAnLTM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bnt_Server_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
        }

        private void bnt_Client_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }
    }
}