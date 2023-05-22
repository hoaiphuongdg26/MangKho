namespace CoCaro
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_JoinARoom = new Button();
            btn_CreateARoom = new Button();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_JoinARoom
            // 
            btn_JoinARoom.Location = new Point(194, 165);
            btn_JoinARoom.Name = "btn_JoinARoom";
            btn_JoinARoom.Size = new Size(147, 29);
            btn_JoinARoom.TabIndex = 1;
            btn_JoinARoom.Text = "Join a room";
            btn_JoinARoom.UseVisualStyleBackColor = true;
            btn_JoinARoom.Click += btn_JoinARoom_Click;
            // 
            // btn_CreateARoom
            // 
            btn_CreateARoom.Location = new Point(194, 113);
            btn_CreateARoom.Name = "btn_CreateARoom";
            btn_CreateARoom.Size = new Size(147, 29);
            btn_CreateARoom.TabIndex = 0;
            btn_CreateARoom.Text = "Create new game";
            btn_CreateARoom.UseVisualStyleBackColor = true;
            btn_CreateARoom.Click += btn_CreateARoom_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_JoinARoom);
            panel1.Controls.Add(btn_CreateARoom);
            panel1.Location = new Point(12, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(535, 304);
            panel1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(558, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(120, 26);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 347);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_JoinARoom;
        private Button btn_CreateARoom;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
    }
}