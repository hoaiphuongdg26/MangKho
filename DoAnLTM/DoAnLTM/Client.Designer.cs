namespace DoAnLTM
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
            txt_Port = new TextBox();
            label2 = new Label();
            label1 = new Label();
            bnt_Connect = new Button();
            bnt_Disconnect = new Button();
            txt_ServerIP = new TextBox();
            ptb_mouseCursor = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptb_mouseCursor).BeginInit();
            SuspendLayout();
            // 
            // txt_Port
            // 
            txt_Port.Location = new Point(577, 12);
            txt_Port.Name = "txt_Port";
            txt_Port.Size = new Size(92, 27);
            txt_Port.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(536, 15);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 10;
            label2.Text = "Port:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 15);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 9;
            label1.Text = "IP Address:";
            // 
            // bnt_Connect
            // 
            bnt_Connect.Location = new Point(259, 59);
            bnt_Connect.Name = "bnt_Connect";
            bnt_Connect.Size = new Size(104, 29);
            bnt_Connect.TabIndex = 8;
            bnt_Connect.Text = "Connect";
            bnt_Connect.UseVisualStyleBackColor = true;
            bnt_Connect.Click += bnt_Connect_Click;
            // 
            // bnt_Disconnect
            // 
            bnt_Disconnect.Enabled = false;
            bnt_Disconnect.Location = new Point(434, 59);
            bnt_Disconnect.Name = "bnt_Disconnect";
            bnt_Disconnect.Size = new Size(104, 29);
            bnt_Disconnect.TabIndex = 7;
            bnt_Disconnect.Text = "Disconnect";
            bnt_Disconnect.UseVisualStyleBackColor = true;
            bnt_Disconnect.Click += bnt_Disconnect_Click;
            // 
            // txt_ServerIP
            // 
            txt_ServerIP.Location = new Point(199, 12);
            txt_ServerIP.Name = "txt_ServerIP";
            txt_ServerIP.Size = new Size(318, 27);
            txt_ServerIP.TabIndex = 6;
            // 
            // ptb_mouseCursor
            // 
            ptb_mouseCursor.BackColor = Color.IndianRed;
            ptb_mouseCursor.BorderStyle = BorderStyle.FixedSingle;
            ptb_mouseCursor.Location = new Point(379, 166);
            ptb_mouseCursor.Name = "ptb_mouseCursor";
            ptb_mouseCursor.Size = new Size(10, 10);
            ptb_mouseCursor.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_mouseCursor.TabIndex = 12;
            ptb_mouseCursor.TabStop = false;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ptb_mouseCursor);
            Controls.Add(txt_Port);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bnt_Connect);
            Controls.Add(bnt_Disconnect);
            Controls.Add(txt_ServerIP);
            Name = "Client";
            Text = "Client";
            FormClosing += Client_FormClosing;
            MouseMove += Client_MouseMove;
            ((System.ComponentModel.ISupportInitialize)ptb_mouseCursor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Port;
        private Label label2;
        private Label label1;
        private Button bnt_Connect;
        private Button bnt_Disconnect;
        private TextBox txt_ServerIP;
        private PictureBox ptb_mouseCursor;
    }
}