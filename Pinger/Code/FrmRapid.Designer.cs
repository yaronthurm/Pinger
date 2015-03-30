namespace PingTester {
    partial class FrmRapid {
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRapid));
            this.lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUsersCount = new System.Windows.Forms.NumericUpDown();
            this.numericDuration = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtMessages = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUsersCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.Name = "lblStatus";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // numericUsersCount
            // 
            resources.ApplyResources(this.numericUsersCount, "numericUsersCount");
            this.numericUsersCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUsersCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUsersCount.Name = "numericUsersCount";
            this.numericUsersCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericDuration
            // 
            resources.ApplyResources(this.numericDuration, "numericDuration");
            this.numericDuration.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericDuration.Name = "numericDuration";
            this.numericDuration.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtDestination
            // 
            resources.ApplyResources(this.txtDestination, "txtDestination");
            this.txtDestination.Name = "txtDestination";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // btnStop
            // 
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.Name = "btnStop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtMessages
            // 
            resources.ApplyResources(this.txtMessages, "txtMessages");
            this.txtMessages.Name = "txtMessages";
            // 
            // FrmRapid
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtMessages);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.numericDuration);
            this.Controls.Add(this.numericUsersCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStatus);
            this.Name = "FrmRapid";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRapid_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUsersCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUsersCount;
        private System.Windows.Forms.NumericUpDown numericDuration;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtMessages;
    }
}