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
            ptb_mouseCursor = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptb_mouseCursor).BeginInit();
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
            // ptb_mouseCursor
            // 
            ptb_mouseCursor.BackColor = SystemColors.ActiveCaption;
            ptb_mouseCursor.Location = new Point(385, 210);
            ptb_mouseCursor.Name = "ptb_mouseCursor";
            ptb_mouseCursor.Size = new Size(30, 30);
            ptb_mouseCursor.TabIndex = 3;
            ptb_mouseCursor.TabStop = false;
            ptb_mouseCursor.UseWaitCursor = true;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ptb_mouseCursor);
            Controls.Add(txt_ServerLog);
            Name = "Server";
            Text = "Server";
            Load += Server_Load;
            MouseEnter += Server_MouseEnter;
            MouseLeave += Server_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)ptb_mouseCursor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_ServerLog;
        private PictureBox ptb_mouseCursor;
    }
}