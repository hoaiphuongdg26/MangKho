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
    public class Room
    {
        public string Id { get; set; }
        public bool IsOwner { get; set; }

        public Room(string id, bool isOwner)
        {
            Id = id;
            IsOwner = isOwner;
        }
    }

    public partial class Home : Form
    {
        private List<Room> rooms;
        public event EventHandler RoomCreated;
        public Home()
        {
            InitializeComponent();
            rooms = new List<Room>();
        }
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_CreateARoom_Click(object sender, EventArgs e)
        {
            // Tạo mới form CreateRoom và truyền danh sách các phòng
            CreateARoom newRoom = new CreateARoom();
            newRoom.Show();
        }
        private void btn_JoinARoom_Click(object sender, EventArgs e)
        {
            JoinARoom joinRoom = new JoinARoom();
            joinRoom.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
