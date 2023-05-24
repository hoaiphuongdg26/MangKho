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
    public partial class Room_SERVER : Form
    {
        private static int CHESS_WIDTH = 30;
        private static int CHESS_HEIGHT = 30;
        private static int CHESS_ROW = 23;
        private static int CHESS_COL = 26;
        public Room_SERVER()
        {
            InitializeComponent();
            IntializeChessboard();
        }
        private void IntializeChessboard()
        {
            Button oldButton = new Button()
            {
                Width = 0,
                Location = new Point(0, 0)
            };
            for (int row = 0; row < CHESS_ROW; row++)
            {
                for (int col = 0; col < CHESS_COL; col++)
                {
                    Button cellButton = new Button()
                    {
                        Width = CHESS_WIDTH,
                        Height = CHESS_HEIGHT,
                        Location = new Point(oldButton.Location.X + CHESS_WIDTH, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch
                    };
                    cellButton.Click += cellButton_Click;
                    pn_Chessboard.Controls.Add(cellButton);
                    oldButton = cellButton;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + CHESS_HEIGHT);
                oldButton.Width = 0; oldButton.Height = 0;
            }
        }
        private void cellButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Image = Image.FromFile(Application.StartupPath + "\\Pictures\\O.png");
        }
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_PlayGame_Click(object sender, EventArgs e)
        {

        }
    }
}
