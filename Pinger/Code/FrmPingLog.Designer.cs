namespace PingTester
{
    partial class FrmPingLog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPingLog));
            this.listBox = new System.Windows.Forms.ListBox();
            this.checkAutoScroll = new System.Windows.Forms.CheckBox();
            this.timerUpdateLog = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listBox
            // 
            resources.ApplyResources(this.listBox, "listBox");
            this.listBox.FormattingEnabled = true;
            this.listBox.Name = "listBox";
            // 
            // checkAutoScroll
            // 
            resources.ApplyResources(this.checkAutoScroll, "checkAutoScroll");
            this.checkAutoScroll.BackColor = System.Drawing.Color.White;
            this.checkAutoScroll.Checked = true;
            this.checkAutoScroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAutoScroll.Name = "checkAutoScroll";
            this.checkAutoScroll.UseVisualStyleBackColor = false;
            // 
            // timerUpdateLog
            // 
            this.timerUpdateLog.Enabled = true;
            this.timerUpdateLog.Tick += new System.EventHandler(this.timerUpdateLog_Tick);
            // 
            // FrmPingLog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkAutoScroll);
            this.Controls.Add(this.listBox);
            this.MinimizeBox = false;
            this.Name = "FrmPingLog";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPingLog_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.CheckBox checkAutoScroll;
        private System.Windows.Forms.Timer timerUpdateLog;


    }
}