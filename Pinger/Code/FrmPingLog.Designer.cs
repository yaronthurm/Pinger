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
            this.listBox = new System.Windows.Forms.ListBox();
            this.checkAutoScroll = new System.Windows.Forms.CheckBox();
            this.timerUpdateLog = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.FormattingEnabled = true;
            this.listBox.HorizontalScrollbar = true;
            this.listBox.Location = new System.Drawing.Point(0, 0);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(537, 147);
            this.listBox.TabIndex = 0;
            // 
            // checkAutoScroll
            // 
            this.checkAutoScroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkAutoScroll.AutoSize = true;
            this.checkAutoScroll.BackColor = System.Drawing.Color.White;
            this.checkAutoScroll.Checked = true;
            this.checkAutoScroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAutoScroll.Location = new System.Drawing.Point(443, 1);
            this.checkAutoScroll.Name = "checkAutoScroll";
            this.checkAutoScroll.Size = new System.Drawing.Size(75, 17);
            this.checkAutoScroll.TabIndex = 1;
            this.checkAutoScroll.Text = "Auto scroll";
            this.checkAutoScroll.UseVisualStyleBackColor = false;
            // 
            // timerUpdateLog
            // 
            this.timerUpdateLog.Enabled = true;
            this.timerUpdateLog.Tick += new System.EventHandler(this.timerUpdateLog_Tick);
            // 
            // frmPingLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 148);
            this.Controls.Add(this.checkAutoScroll);
            this.Controls.Add(this.listBox);
            this.MinimizeBox = false;
            this.Name = "frmPingLog";
            this.ShowInTaskbar = false;
            this.Text = "frmPingLog";
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