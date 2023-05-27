namespace CoCaro
{
    partial class Room_CLIENT
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
            label5 = new Label();
            pn_ListPlayers = new Panel();
            btn_Quit = new Button();
            label4 = new Label();
            panel1 = new Panel();
            btn_Ready = new Button();
            btn_Undo = new Button();
            progressBar1 = new ProgressBar();
            label3 = new Label();
            txt_PlayerName = new TextBox();
            label2 = new Label();
            txt_IPServer = new TextBox();
            label1 = new Label();
            homeToolStripMenuItem = new ToolStripMenuItem();
            menuToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            pn_Chessboard = new Panel();
            pn_ListPlayers.SuspendLayout();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 4);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 0;
            label5.Text = "Players:";
            // 
            // pn_ListPlayers
            // 
            pn_ListPlayers.Controls.Add(label5);
            pn_ListPlayers.Location = new Point(12, 33);
            pn_ListPlayers.Name = "pn_ListPlayers";
            pn_ListPlayers.Size = new Size(334, 251);
            pn_ListPlayers.TabIndex = 15;
            // 
            // btn_Quit
            // 
            btn_Quit.Location = new Point(109, 410);
            btn_Quit.Name = "btn_Quit";
            btn_Quit.Size = new Size(94, 29);
            btn_Quit.TabIndex = 11;
            btn_Quit.Text = "Quit";
            btn_Quit.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(131, 178);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 10;
            label4.Text = "Rules";
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Quit);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btn_Ready);
            panel1.Controls.Add(btn_Undo);
            panel1.Controls.Add(progressBar1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_PlayerName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_IPServer);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 290);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 442);
            panel1.TabIndex = 14;
            // 
            // btn_Ready
            // 
            btn_Ready.Location = new Point(37, 130);
            btn_Ready.Name = "btn_Ready";
            btn_Ready.Size = new Size(94, 29);
            btn_Ready.TabIndex = 9;
            btn_Ready.Text = "Ready";
            btn_Ready.UseVisualStyleBackColor = true;
            // 
            // btn_Undo
            // 
            btn_Undo.Enabled = false;
            btn_Undo.Location = new Point(198, 130);
            btn_Undo.Name = "btn_Undo";
            btn_Undo.Size = new Size(94, 29);
            btn_Undo.TabIndex = 8;
            btn_Undo.Text = "Undo";
            btn_Undo.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(154, 70);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(180, 29);
            progressBar1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 75);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 0;
            label3.Text = "Time:";
            // 
            // txt_PlayerName
            // 
            txt_PlayerName.Location = new Point(154, 37);
            txt_PlayerName.Name = "txt_PlayerName";
            txt_PlayerName.ReadOnly = true;
            txt_PlayerName.Size = new Size(180, 27);
            txt_PlayerName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 42);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 5;
            label2.Text = "Player name:";
            // 
            // txt_IPServer
            // 
            txt_IPServer.Location = new Point(154, 4);
            txt_IPServer.Name = "txt_IPServer";
            txt_IPServer.ReadOnly = true;
            txt_IPServer.Size = new Size(180, 27);
            txt_IPServer.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 3;
            label1.Text = "Room ID (IP Adress):";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(162, 26);
            homeToolStripMenuItem.Text = "Home";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { homeToolStripMenuItem, quitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(162, 26);
            quitToolStripMenuItem.Text = "Quit game";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1153, 28);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // pn_Chessboard
            // 
            pn_Chessboard.Location = new Point(355, 33);
            pn_Chessboard.Name = "pn_Chessboard";
            pn_Chessboard.Size = new Size(788, 699);
            pn_Chessboard.TabIndex = 12;
            // 
            // Room_CLIENT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 741);
            Controls.Add(pn_ListPlayers);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Controls.Add(pn_Chessboard);
            Name = "Room_CLIENT";
            Text = "Room_CLIENT";
            pn_ListPlayers.ResumeLayout(false);
            pn_ListPlayers.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Panel pn_ListPlayers;
        private Button btn_Quit;
        private Label label4;
        private Panel panel1;
        private Button btn_Ready;
        private Button btn_Undo;
        private ProgressBar progressBar1;
        private Label label3;
        private TextBox txt_PlayerName;
        private Label label2;
        private TextBox txt_IPServer;
        private Label label1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Panel pn_Chessboard;
    }
}