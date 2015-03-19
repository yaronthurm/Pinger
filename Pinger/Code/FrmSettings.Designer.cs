namespace PingTester
{
    partial class FrmSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericTTL = new System.Windows.Forms.NumericUpDown();
            this.checkBoxDontFragment = new System.Windows.Forms.CheckBox();
            this.numericTimeout = new System.Windows.Forms.NumericUpDown();
            this.numericPingInterval = new System.Windows.Forms.NumericUpDown();
            this.numericMsgCount = new System.Windows.Forms.NumericUpDown();
            this.numericHistoryCapacity = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.numericBufferSize = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericTTL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPingInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMsgCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHistoryCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBufferSize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 3);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TTL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 27);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buffer Size [bytes]";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 55);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Don\'t Fragment Flag";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 81);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Timout Delay [ms]";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 107);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ping Interval [ms]";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 133);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Stability Counter";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 159);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "History Capacity";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numericTTL
            // 
            this.numericTTL.Location = new System.Drawing.Point(129, 3);
            this.numericTTL.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericTTL.Name = "numericTTL";
            this.numericTTL.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericTTL.Size = new System.Drawing.Size(69, 20);
            this.numericTTL.TabIndex = 1;
            this.numericTTL.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});            
            // 
            // checkBoxDontFragment
            // 
            this.checkBoxDontFragment.AutoSize = true;
            this.checkBoxDontFragment.Location = new System.Drawing.Point(129, 54);
            this.checkBoxDontFragment.Name = "checkBoxDontFragment";
            this.checkBoxDontFragment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxDontFragment.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDontFragment.TabIndex = 3;
            this.checkBoxDontFragment.UseVisualStyleBackColor = true;
            // 
            // numericTimeout
            // 
            this.numericTimeout.Location = new System.Drawing.Point(129, 79);
            this.numericTimeout.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericTimeout.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericTimeout.Name = "numericTimeout";
            this.numericTimeout.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericTimeout.Size = new System.Drawing.Size(69, 20);
            this.numericTimeout.TabIndex = 4;
            this.numericTimeout.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // numericPingInterval
            // 
            this.numericPingInterval.Location = new System.Drawing.Point(129, 105);
            this.numericPingInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericPingInterval.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericPingInterval.Name = "numericPingInterval";
            this.numericPingInterval.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericPingInterval.Size = new System.Drawing.Size(69, 20);
            this.numericPingInterval.TabIndex = 5;
            this.numericPingInterval.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // numericMsgCount
            // 
            this.numericMsgCount.Location = new System.Drawing.Point(129, 131);
            this.numericMsgCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericMsgCount.Name = "numericMsgCount";
            this.numericMsgCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericMsgCount.Size = new System.Drawing.Size(69, 20);
            this.numericMsgCount.TabIndex = 6;
            // 
            // numericHistoryCapacity
            // 
            this.numericHistoryCapacity.Location = new System.Drawing.Point(129, 157);
            this.numericHistoryCapacity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericHistoryCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericHistoryCapacity.Name = "numericHistoryCapacity";
            this.numericHistoryCapacity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericHistoryCapacity.Size = new System.Drawing.Size(69, 20);
            this.numericHistoryCapacity.TabIndex = 7;
            this.numericHistoryCapacity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(113, 188);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "אישור";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(18, 188);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 9;
            this.btnCancle.Text = "ביטול";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // numericBufferSize
            // 
            this.numericBufferSize.Location = new System.Drawing.Point(129, 27);
            this.numericBufferSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericBufferSize.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericBufferSize.Name = "numericBufferSize";
            this.numericBufferSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericBufferSize.Size = new System.Drawing.Size(69, 20);
            this.numericBufferSize.TabIndex = 2;
            this.numericBufferSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 214);
            this.Controls.Add(this.numericBufferSize);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.numericHistoryCapacity);
            this.Controls.Add(this.numericMsgCount);
            this.Controls.Add(this.numericPingInterval);
            this.Controls.Add(this.numericTimeout);
            this.Controls.Add(this.checkBoxDontFragment);
            this.Controls.Add(this.numericTTL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "הגדרות";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSettings_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericTTL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPingInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMsgCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHistoryCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBufferSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericTTL;
        private System.Windows.Forms.CheckBox checkBoxDontFragment;
        private System.Windows.Forms.NumericUpDown numericTimeout;
        private System.Windows.Forms.NumericUpDown numericPingInterval;
        private System.Windows.Forms.NumericUpDown numericMsgCount;
        private System.Windows.Forms.NumericUpDown numericHistoryCapacity;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.NumericUpDown numericBufferSize;
    }
}