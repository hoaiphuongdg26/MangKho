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
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)ptb_mouseCursor).BeginInit();
            SuspendLayout();
            // 
            // txt_Port
            // 
            txt_Port.BackColor = SystemColors.ButtonHighlight;
            txt_Port.Location = new Point(567, 5);
            txt_Port.Name = "txt_Port";
            txt_Port.Size = new Size(92, 27);
            txt_Port.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(516, 9);
            label2.Name = "label2";
            label2.Size = new Size(48, 23);
            label2.TabIndex = 10;
            label2.Text = "Port:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(79, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 9;
            label1.Text = "IP Address:";
            // 
            // bnt_Connect
            // 
            bnt_Connect.BackColor = Color.Azure;
            bnt_Connect.FlatStyle = FlatStyle.Flat;
            bnt_Connect.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            bnt_Connect.ForeColor = Color.SteelBlue;
            bnt_Connect.Location = new Point(249, 48);
            bnt_Connect.Name = "bnt_Connect";
            bnt_Connect.Size = new Size(113, 40);
            bnt_Connect.TabIndex = 8;
            bnt_Connect.Text = "Connect";
            bnt_Connect.UseVisualStyleBackColor = false;
            bnt_Connect.Click += bnt_Connect_Click;
            // 
            // bnt_Disconnect
            // 
            bnt_Disconnect.BackColor = Color.Azure;
            bnt_Disconnect.Enabled = false;
            bnt_Disconnect.FlatStyle = FlatStyle.Flat;
            bnt_Disconnect.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            bnt_Disconnect.ForeColor = Color.SteelBlue;
            bnt_Disconnect.Location = new Point(459, 48);
            bnt_Disconnect.Name = "bnt_Disconnect";
            bnt_Disconnect.Size = new Size(113, 40);
            bnt_Disconnect.TabIndex = 7;
            bnt_Disconnect.Text = "Disconnect";
            bnt_Disconnect.UseVisualStyleBackColor = false;
            bnt_Disconnect.Click += bnt_Disconnect_Click;
            // 
            // txt_ServerIP
            // 
            txt_ServerIP.BackColor = SystemColors.ButtonHighlight;
            txt_ServerIP.Location = new Point(179, 5);
            txt_ServerIP.Name = "txt_ServerIP";
            txt_ServerIP.Size = new Size(253, 27);
            txt_ServerIP.TabIndex = 6;
            // 
            // ptb_mouseCursor
            // 
            ptb_mouseCursor.BackColor = Color.SteelBlue;
            ptb_mouseCursor.BorderStyle = BorderStyle.FixedSingle;
            ptb_mouseCursor.Location = new Point(379, 166);
            ptb_mouseCursor.Name = "ptb_mouseCursor";
            ptb_mouseCursor.Size = new Size(10, 10);
            ptb_mouseCursor.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_mouseCursor.TabIndex = 12;
            ptb_mouseCursor.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 87);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 13;
            label3.Text = "label3";
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
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
        private Label label3;
    }
}