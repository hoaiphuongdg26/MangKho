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
    public partial class Room_CLIENT : Form
    {
        private static int CHESS_WIDTH = 30;
        private static int CHESS_HEIGHT = 30;
        private static int CHESS_ROW = 23;
        private static int CHESS_COL = 26;
        public Room_CLIENT()
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
                    };
                    pn_Chessboard.Controls.Add(cellButton);
                    oldButton = cellButton;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + CHESS_HEIGHT);
                oldButton.Width = 0; oldButton.Height = 0;
            }
        }

    }
}
