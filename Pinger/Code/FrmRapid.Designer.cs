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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUsersCount = new System.Windows.Forms.NumericUpDown();
            this.numericDuration = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUsersCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Users count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duration [sec]";
            // 
            // numericUsersCount
            // 
            this.numericUsersCount.Location = new System.Drawing.Point(108, 27);
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
            this.numericUsersCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUsersCount.Size = new System.Drawing.Size(69, 20);
            this.numericUsersCount.TabIndex = 3;
            this.numericUsersCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericDuration
            // 
            this.numericDuration.Location = new System.Drawing.Point(108, 58);
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
            this.numericDuration.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericDuration.Size = new System.Drawing.Size(69, 20);
            this.numericDuration.TabIndex = 4;
            this.numericDuration.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(108, 125);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "התחל";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(108, 88);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(164, 20);
            this.txtDestination.TabIndex = 10;
            this.txtDestination.Text = "127.0.0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Destination";
            // 
            // FrmRapid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.numericDuration);
            this.Controls.Add(this.numericUsersCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRapid";
            this.Text = "FrmRapid";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRapid_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUsersCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUsersCount;
        private System.Windows.Forms.NumericUpDown numericDuration;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label label4;
    }
}