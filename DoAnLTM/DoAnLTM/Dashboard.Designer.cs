namespace DoAnLTM
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
            bnt_Client = new Button();
            bnt_Server = new Button();
            SuspendLayout();
            // 
            // bnt_Client
            // 
            bnt_Client.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            bnt_Client.Location = new Point(239, 48);
            bnt_Client.Name = "bnt_Client";
            bnt_Client.Size = new Size(135, 46);
            bnt_Client.TabIndex = 3;
            bnt_Client.Text = "Client";
            bnt_Client.UseVisualStyleBackColor = true;
            bnt_Client.Click += bnt_Client_Click;
            // 
            // bnt_Server
            // 
            bnt_Server.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            bnt_Server.Location = new Point(48, 48);
            bnt_Server.Name = "bnt_Server";
            bnt_Server.Size = new Size(135, 46);
            bnt_Server.TabIndex = 2;
            bnt_Server.Text = "Server";
            bnt_Server.UseVisualStyleBackColor = true;
            bnt_Server.Click += bnt_Server_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 136);
            Controls.Add(bnt_Client);
            Controls.Add(bnt_Server);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button bnt_Client;
        private Button bnt_Server;
    }
}