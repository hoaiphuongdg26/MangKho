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
            panel1 = new Panel();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ls_Files);
            panel1.Controls.Add(btn_Download);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(794, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 602);
            panel1.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 240);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 30;
            label1.Text = "Files";
            // 
            // ls_Files
            // 
            ls_Files.FormattingEnabled = true;
            ls_Files.ItemHeight = 20;
            ls_Files.Location = new Point(3, 263);
            ls_Files.Name = "ls_Files";
            ls_Files.Size = new Size(244, 284);
            ls_Files.TabIndex = 29;
            // 
            // btn_Download
            // 
            btn_Download.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Download.Location = new Point(77, 563);
            btn_Download.Name = "btn_Download";
            btn_Download.Size = new Size(102, 30);
            btn_Download.TabIndex = 28;
            btn_Download.Text = "Download";
            btn_Download.UseVisualStyleBackColor = true;
            btn_Download.Click += btn_Download_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 237);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_Join
            // 
            btn_Join.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Join.Location = new Point(330, 462);
            btn_Join.Name = "btn_Join";
            btn_Join.Size = new Size(86, 30);
            btn_Join.TabIndex = 36;
            btn_Join.Text = "Join";
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
            btn_Attach.Location = new Point(12, 589);
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
            tb_Message.Location = new Point(12, 527);
            tb_Message.Multiline = true;
            tb_Message.Name = "tb_Message";
            tb_Message.Size = new Size(684, 56);
            tb_Message.TabIndex = 33;
            tb_Message.KeyDown += tb_Message_KeyDown;
            // 
            // tb_Name
            // 
            tb_Name.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Name.Location = new Point(12, 462);
            tb_Name.Name = "tb_Name";
            tb_Name.Size = new Size(312, 30);
            tb_Name.TabIndex = 32;
            // 
            // rtb_Client
            // 
            rtb_Client.BackColor = Color.WhiteSmoke;
            rtb_Client.BorderStyle = BorderStyle.FixedSingle;
            rtb_Client.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rtb_Client.Location = new Point(12, 12);
            rtb_Client.Name = "rtb_Client";
            rtb_Client.ReadOnly = true;
            rtb_Client.Size = new Size(776, 421);
            rtb_Client.TabIndex = 31;
            rtb_Client.Text = "";
            // 
            // lb_Message
            // 
            lb_Message.AutoSize = true;
            lb_Message.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Message.Location = new Point(16, 499);
            lb_Message.Name = "lb_Message";
            lb_Message.Size = new Size(76, 23);
            lb_Message.TabIndex = 30;
            lb_Message.Text = "Message";
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Name.Location = new Point(16, 436);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(96, 23);
            lb_Name.TabIndex = 29;
            lb_Name.Text = "Your name:";
            // 
            // btn_Send
            // 
            btn_Send.Enabled = false;
            btn_Send.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Send.Location = new Point(702, 541);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(86, 30);
            btn_Send.TabIndex = 28;
            btn_Send.Text = "Send";
            btn_Send.UseVisualStyleBackColor = true;
            btn_Send.Click += btn_Send_Click;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 635);
            Controls.Add(panel1);
            Controls.Add(btn_Join);
            Controls.Add(lb_showFileName);
            Controls.Add(btn_Attach);
            Controls.Add(tb_Message);
            Controls.Add(tb_Name);
            Controls.Add(rtb_Client);
            Controls.Add(lb_Message);
            Controls.Add(lb_Name);
            Controls.Add(btn_Send);
            Name = "Client";
            Text = "Client";
            FormClosing += Client_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
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
    }
}