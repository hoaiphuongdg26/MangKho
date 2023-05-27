namespace ChatGroup
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            label2 = new Label();
            listView1 = new ListView();
            label1 = new Label();
            ls_Files = new ListBox();
            btn_Download = new Button();
            pictureBox1 = new PictureBox();
            btn_Join = new Button();
            lb_showFileName = new Label();
            btn_Attach = new Button();
            tb_Message = new TextBox();
            tb_Name = new TextBox();
            rtb_Client = new RichTextBox();
            lb_Message = new Label();
            lb_Name = new Label();
            btn_Send = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(896, 265);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 32;
            label2.Text = "Users";
            // 
            // listView1
            // 
            listView1.BackColor = Color.White;
            listView1.Location = new Point(797, 290);
            listView1.Name = "listView1";
            listView1.Size = new Size(250, 115);
            listView1.TabIndex = 31;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(896, 408);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 30;
            label1.Text = "Files";
            // 
            // ls_Files
            // 
            ls_Files.BackColor = Color.White;
            ls_Files.FormattingEnabled = true;
            ls_Files.ItemHeight = 20;
            ls_Files.Location = new Point(797, 436);
            ls_Files.Name = "ls_Files";
            ls_Files.Size = new Size(250, 184);
            ls_Files.TabIndex = 29;
            // 
            // btn_Download
            // 
            btn_Download.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Download.Location = new Point(870, 626);
            btn_Download.Name = "btn_Download";
            btn_Download.Size = new Size(102, 30);
            btn_Download.TabIndex = 28;
            btn_Download.Text = "Download";
            btn_Download.UseVisualStyleBackColor = true;
            btn_Download.Click += btn_Download_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1;
            pictureBox1.Location = new Point(797, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 237);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_Join
            // 
            btn_Join.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Join.Image = Properties.Resources._5528913;
            btn_Join.Location = new Point(324, 521);
            btn_Join.Name = "btn_Join";
            btn_Join.Size = new Size(86, 30);
            btn_Join.TabIndex = 36;
            btn_Join.Text = "Login";
            btn_Join.UseVisualStyleBackColor = true;
            btn_Join.Click += btn_Join_Click;
            // 
            // lb_showFileName
            // 
            lb_showFileName.AutoSize = true;
            lb_showFileName.Location = new Point(104, 595);
            lb_showFileName.Name = "lb_showFileName";
            lb_showFileName.Size = new Size(0, 20);
            lb_showFileName.TabIndex = 35;
            // 
            // btn_Attach
            // 
            btn_Attach.Enabled = false;
            btn_Attach.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Attach.Location = new Point(9, 628);
            btn_Attach.Name = "btn_Attach";
            btn_Attach.Size = new Size(86, 30);
            btn_Attach.TabIndex = 34;
            btn_Attach.Text = "Attach";
            btn_Attach.UseVisualStyleBackColor = true;
            btn_Attach.Click += btn_Attach_Click;
            // 
            // tb_Message
            // 
            tb_Message.Enabled = false;
            tb_Message.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Message.Location = new Point(9, 579);
            tb_Message.Multiline = true;
            tb_Message.Name = "tb_Message";
            tb_Message.Size = new Size(684, 43);
            tb_Message.TabIndex = 33;
            // 
            // tb_Name
            // 
            tb_Name.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Name.Location = new Point(9, 520);
            tb_Name.Name = "tb_Name";
            tb_Name.Size = new Size(312, 30);
            tb_Name.TabIndex = 32;
            // 
            // rtb_Client
            // 
            rtb_Client.BackColor = Color.White;
            rtb_Client.BorderStyle = BorderStyle.None;
            rtb_Client.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rtb_Client.Location = new Point(12, 12);
            rtb_Client.Name = "rtb_Client";
            rtb_Client.ReadOnly = true;
            rtb_Client.Size = new Size(776, 459);
            rtb_Client.TabIndex = 31;
            rtb_Client.Text = "";
            // 
            // lb_Message
            // 
            lb_Message.AutoSize = true;
            lb_Message.BackColor = Color.Transparent;
            lb_Message.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Message.Location = new Point(10, 553);
            lb_Message.Name = "lb_Message";
            lb_Message.Size = new Size(81, 23);
            lb_Message.TabIndex = 30;
            lb_Message.Text = "Message:";
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.BackColor = Color.Transparent;
            lb_Name.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Name.Location = new Point(10, 494);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(96, 23);
            lb_Name.TabIndex = 29;
            lb_Name.Text = "Your name:";
            // 
            // btn_Send
            // 
            btn_Send.Enabled = false;
            btn_Send.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Send.Location = new Point(693, 592);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(86, 30);
            btn_Send.TabIndex = 28;
            btn_Send.Text = "Send";
            btn_Send.UseVisualStyleBackColor = true;
            btn_Send.Click += btn_Send_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = Properties.Resources._5528913;
            button1.Location = new Point(416, 521);
            button1.Name = "button1";
            button1.Size = new Size(86, 30);
            button1.TabIndex = 37;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackgroundImage = Properties.Resources._5528913;
            ClientSize = new Size(1057, 664);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(tb_Name);
            Controls.Add(ls_Files);
            Controls.Add(btn_Download);
            Controls.Add(lb_Name);
            Controls.Add(lb_showFileName);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Join);
            Controls.Add(btn_Attach);
            Controls.Add(rtb_Client);
            Controls.Add(btn_Send);
            Controls.Add(tb_Message);
            Controls.Add(lb_Message);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Client";
            Text = "Client";
            FormClosing += Client_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ListBox ls_Files;
        private Button btn_Download;
        private PictureBox pictureBox1;
        private Button btn_Join;
        private Label lb_showFileName;
        private Button btn_Attach;
        private TextBox tb_Message;
        private TextBox tb_Name;
        private RichTextBox rtb_Client;
        private Label lb_Message;
        private Label lb_Name;
        private Button btn_Send;
        private Label label2;
        private ListView listView1;
        private Button button1;
    }
}