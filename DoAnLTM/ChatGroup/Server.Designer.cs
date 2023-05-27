namespace ChatGroup
{
    partial class Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            rtb_Server = new RichTextBox();
            Listen = new Button();
            StopListen = new Button();
            SuspendLayout();
            // 
            // rtb_Server
            // 
            rtb_Server.BackColor = Color.White;
            rtb_Server.BorderStyle = BorderStyle.None;
            rtb_Server.Location = new Point(12, 47);
            rtb_Server.Name = "rtb_Server";
            rtb_Server.ReadOnly = true;
            rtb_Server.Size = new Size(776, 391);
            rtb_Server.TabIndex = 11;
            rtb_Server.Text = "";
            // 
            // Listen
            // 
            Listen.Location = new Point(594, 12);
            Listen.Name = "Listen";
            Listen.Size = new Size(94, 29);
            Listen.TabIndex = 10;
            Listen.Text = "Listen";
            Listen.UseVisualStyleBackColor = true;
            Listen.Click += Listen_Click;
            // 
            // StopListen
            // 
            StopListen.Location = new Point(694, 12);
            StopListen.Name = "StopListen";
            StopListen.Size = new Size(94, 29);
            StopListen.TabIndex = 9;
            StopListen.Text = "Stop Listen";
            StopListen.UseVisualStyleBackColor = true;
            StopListen.Click += StopListen_Click;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(rtb_Server);
            Controls.Add(Listen);
            Controls.Add(StopListen);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Server";
            Text = "Server";
            FormClosing += Server_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtb_Server;
        private Button Listen;
        private Button StopListen;
    }
}