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
    public partial class JoinARoom : Form
    {
        public JoinARoom()
        {
            InitializeComponent();
        }

        private void btn_Join_Click(object sender, EventArgs e)
        {
            Room_CLIENT room = new Room_CLIENT();
            room.Show();
            this.Close();
        }
    }
}
