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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
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
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
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
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // numericTTL
            // 
            resources.ApplyResources(this.numericTTL, "numericTTL");
            this.numericTTL.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericTTL.Name = "numericTTL";
            this.numericTTL.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // checkBoxDontFragment
            // 
            resources.ApplyResources(this.checkBoxDontFragment, "checkBoxDontFragment");
            this.checkBoxDontFragment.Name = "checkBoxDontFragment";
            this.checkBoxDontFragment.UseVisualStyleBackColor = true;
            // 
            // numericTimeout
            // 
            resources.ApplyResources(this.numericTimeout, "numericTimeout");
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
            this.numericTimeout.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // numericPingInterval
            // 
            resources.ApplyResources(this.numericPingInterval, "numericPingInterval");
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
            this.numericPingInterval.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // numericMsgCount
            // 
            resources.ApplyResources(this.numericMsgCount, "numericMsgCount");
            this.numericMsgCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericMsgCount.Name = "numericMsgCount";
            // 
            // numericHistoryCapacity
            // 
            resources.ApplyResources(this.numericHistoryCapacity, "numericHistoryCapacity");
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
            this.numericHistoryCapacity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancle
            // 
            resources.ApplyResources(this.btnCancle, "btnCancle");
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // numericBufferSize
            // 
            resources.ApplyResources(this.numericBufferSize, "numericBufferSize");
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
            this.numericBufferSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // FrmSettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "FrmSettings";
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