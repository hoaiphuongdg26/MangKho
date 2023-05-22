namespace CoCaro
{
    partial class CreateARoom
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
            txt_PlayerName = new TextBox();
            btn_CreateARoom = new Button();
            label1 = new Label();
            txt_IPServer = new TextBox();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_PlayerName
            // 
            txt_PlayerName.Location = new Point(187, 46);
            txt_PlayerName.Name = "txt_PlayerName";
            txt_PlayerName.Size = new Size(180, 27);
            txt_PlayerName.TabIndex = 10;
            // 
            // btn_CreateARoom
            // 
            btn_CreateARoom.Location = new Point(140, 96);
            btn_CreateARoom.Name = "btn_CreateARoom";
            btn_CreateARoom.Size = new Size(129, 29);
            btn_CreateARoom.TabIndex = 11;
            btn_CreateARoom.Text = "Create a room";
            btn_CreateARoom.UseVisualStyleBackColor = true;
            btn_CreateARoom.Click += btn_CreateARoom_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 17);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 7;
            label1.Text = "Room ID (IP Adress):";
            // 
            // txt_IPServer
            // 
            txt_IPServer.Location = new Point(187, 13);
            txt_IPServer.Name = "txt_IPServer";
            txt_IPServer.ReadOnly = true;
            txt_IPServer.Size = new Size(180, 27);
            txt_IPServer.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 51);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 9;
            label2.Text = "Player name:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(428, 28);
            menuStrip1.TabIndex = 14;
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
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_PlayerName);
            panel1.Controls.Add(btn_CreateARoom);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_IPServer);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 136);
            panel1.TabIndex = 15;
            // 
            // CreateARoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 178);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Name = "CreateARoom";
            Text = "CreateARoom";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_PlayerName;
        private Button btn_CreateARoom;
        private Label label1;
        private TextBox txt_IPServer;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Panel panel1;
    }
}