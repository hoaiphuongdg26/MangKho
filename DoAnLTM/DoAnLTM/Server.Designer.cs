namespace DoAnLTM
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
            txt_ServerLog = new TextBox();
            SuspendLayout();
            // 
            // txt_ServerLog
            // 
            txt_ServerLog.BackColor = SystemColors.Control;
            txt_ServerLog.BorderStyle = BorderStyle.None;
            txt_ServerLog.Location = new Point(12, 12);
            txt_ServerLog.Name = "txt_ServerLog";
            txt_ServerLog.ReadOnly = true;
            txt_ServerLog.Size = new Size(776, 20);
            txt_ServerLog.TabIndex = 1;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_ServerLog);
            Name = "Server";
            Text = "Server";
            Load += Server_Load;
            MouseMove += Server_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_ServerLog;
    }
}