using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoCaro
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_CreateARoom_Click(object sender, EventArgs e)
        {
            CreateARoom newRoom = new CreateARoom();
            newRoom.Show();
        }
        private void btn_JoinARoom_Click(object sender, EventArgs e)
        {
            JoinARoom joinRoom = new JoinARoom();
            joinRoom.Show();
        }
    }
}
