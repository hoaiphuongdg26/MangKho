namespace ChatGroup
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            TCPClient = new Button();
            TCPServer = new Button();
            SuspendLayout();
            // 
            // TCPClient
            // 
            TCPClient.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TCPClient.Location = new Point(222, 32);
            TCPClient.Name = "TCPClient";
            TCPClient.Size = new Size(138, 50);
            TCPClient.TabIndex = 5;
            TCPClient.Text = "TCP Client";
            TCPClient.UseVisualStyleBackColor = true;
            TCPClient.Click += TCPClient_Click;
            // 
            // TCPServer
            // 
            TCPServer.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TCPServer.Location = new Point(37, 32);
            TCPServer.Name = "TCPServer";
            TCPServer.Size = new Size(141, 50);
            TCPServer.TabIndex = 6;
            TCPServer.Text = "TCP Server";
            TCPServer.UseVisualStyleBackColor = true;
            TCPServer.Click += TCPServer_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 118);
            Controls.Add(TCPClient);
            Controls.Add(TCPServer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button TCPClient;
        private Button TCPServer;
    }
}