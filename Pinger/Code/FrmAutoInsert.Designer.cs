namespace PingTester
{
    partial class FrmAutoInsert
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.radioIP = new System.Windows.Forms.RadioButton();
            this.radioCustomize = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelCustomize = new System.Windows.Forms.Panel();
            this.lblExample = new System.Windows.Forms.Label();
            this.panelInsertArguments = new System.Windows.Forms.Panel();
            this.lblMinTitle = new System.Windows.Forms.Label();
            this.lblMaxTitle = new System.Windows.Forms.Label();
            this.lblArgumentTitle = new System.Windows.Forms.Label();
            this.txtInsertFormatString = new System.Windows.Forms.TextBox();
            this.panelIP = new System.Windows.Forms.Panel();
            this.lblIPEnd = new System.Windows.Forms.Label();
            this.numericEnd0 = new System.Windows.Forms.NumericUpDown();
            this.numericEnd1 = new System.Windows.Forms.NumericUpDown();
            this.numericEnd2 = new System.Windows.Forms.NumericUpDown();
            this.numericEnd3 = new System.Windows.Forms.NumericUpDown();
            this.numericStart2 = new System.Windows.Forms.NumericUpDown();
            this.numericStart0 = new System.Windows.Forms.NumericUpDown();
            this.numericStart1 = new System.Windows.Forms.NumericUpDown();
            this.numericStart3 = new System.Windows.Forms.NumericUpDown();
            this.lblIPStart = new System.Windows.Forms.Label();
            this.lblTotalElements = new System.Windows.Forms.Label();
            this.lblTotalElementsTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panelCustomize.SuspendLayout();
            this.panelInsertArguments.SuspendLayout();
            this.panelIP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnd0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnd2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnd3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStart0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStart3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(174, 342);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "אישור";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(61, 342);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "ביטול";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // radioIP
            // 
            this.radioIP.AutoSize = true;
            this.radioIP.Location = new System.Drawing.Point(157, 19);
            this.radioIP.Name = "radioIP";
            this.radioIP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioIP.Size = new System.Drawing.Size(121, 17);
            this.radioIP.TabIndex = 15;
            this.radioIP.Text = "הכנס תחום כתובות";
            this.radioIP.UseVisualStyleBackColor = true;
            this.radioIP.CheckedChanged += new System.EventHandler(this.radioIP_CheckedChanged);
            // 
            // radioCustomize
            // 
            this.radioCustomize.AutoSize = true;
            this.radioCustomize.Checked = true;
            this.radioCustomize.Location = new System.Drawing.Point(127, 104);
            this.radioCustomize.Name = "radioCustomize";
            this.radioCustomize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioCustomize.Size = new System.Drawing.Size(151, 17);
            this.radioCustomize.TabIndex = 8;
            this.radioCustomize.TabStop = true;
            this.radioCustomize.Text = "הכנס תחום מוגדר אישית";
            this.radioCustomize.UseVisualStyleBackColor = true;
            this.radioCustomize.CheckedChanged += new System.EventHandler(this.radioCustomize_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelCustomize);
            this.groupBox1.Controls.Add(this.panelIP);
            this.groupBox1.Controls.Add(this.radioCustomize);
            this.groupBox1.Controls.Add(this.radioIP);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 310);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // panelCustomize
            // 
            this.panelCustomize.Controls.Add(this.lblExample);
            this.panelCustomize.Controls.Add(this.panelInsertArguments);
            this.panelCustomize.Controls.Add(this.txtInsertFormatString);
            this.panelCustomize.Location = new System.Drawing.Point(23, 127);
            this.panelCustomize.Name = "panelCustomize";
            this.panelCustomize.Size = new System.Drawing.Size(255, 175);
            this.panelCustomize.TabIndex = 17;
            // 
            // lblExample
            // 
            this.lblExample.AutoSize = true;
            this.lblExample.Location = new System.Drawing.Point(23, 29);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(76, 13);
            this.lblExample.TabIndex = 18;
            this.lblExample.Text = "String example";
            // 
            // panelInsertArguments
            // 
            this.panelInsertArguments.AutoScroll = true;
            this.panelInsertArguments.Controls.Add(this.lblMinTitle);
            this.panelInsertArguments.Controls.Add(this.lblMaxTitle);
            this.panelInsertArguments.Controls.Add(this.lblArgumentTitle);
            this.panelInsertArguments.Location = new System.Drawing.Point(3, 46);
            this.panelInsertArguments.Name = "panelInsertArguments";
            this.panelInsertArguments.Size = new System.Drawing.Size(246, 121);
            this.panelInsertArguments.TabIndex = 17;
            this.panelInsertArguments.Visible = false;
            // 
            // lblMinTitle
            // 
            this.lblMinTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMinTitle.Location = new System.Drawing.Point(80, 10);
            this.lblMinTitle.Name = "lblMinTitle";
            this.lblMinTitle.Size = new System.Drawing.Size(55, 13);
            this.lblMinTitle.TabIndex = 15;
            this.lblMinTitle.Text = "מינימום";
            this.lblMinTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaxTitle
            // 
            this.lblMaxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMaxTitle.Location = new System.Drawing.Point(147, 10);
            this.lblMaxTitle.Name = "lblMaxTitle";
            this.lblMaxTitle.Size = new System.Drawing.Size(55, 13);
            this.lblMaxTitle.TabIndex = 15;
            this.lblMaxTitle.Text = "מקסימום";
            this.lblMaxTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArgumentTitle
            // 
            this.lblArgumentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblArgumentTitle.Location = new System.Drawing.Point(13, 10);
            this.lblArgumentTitle.Name = "lblArgumentTitle";
            this.lblArgumentTitle.Size = new System.Drawing.Size(55, 13);
            this.lblArgumentTitle.TabIndex = 15;
            this.lblArgumentTitle.Text = "ארגומנט";
            this.lblArgumentTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInsertFormatString
            // 
            this.txtInsertFormatString.Location = new System.Drawing.Point(24, 6);
            this.txtInsertFormatString.Name = "txtInsertFormatString";
            this.txtInsertFormatString.Size = new System.Drawing.Size(220, 20);
            this.txtInsertFormatString.TabIndex = 15;
            this.txtInsertFormatString.TextChanged += new System.EventHandler(this.txtInsertFormatString_TextChanged);
            // 
            // panelIP
            // 
            this.panelIP.Controls.Add(this.lblIPEnd);
            this.panelIP.Controls.Add(this.numericEnd0);
            this.panelIP.Controls.Add(this.numericEnd1);
            this.panelIP.Controls.Add(this.numericEnd2);
            this.panelIP.Controls.Add(this.numericEnd3);
            this.panelIP.Controls.Add(this.numericStart2);
            this.panelIP.Controls.Add(this.numericStart0);
            this.panelIP.Controls.Add(this.numericStart1);
            this.panelIP.Controls.Add(this.numericStart3);
            this.panelIP.Controls.Add(this.lblIPStart);
            this.panelIP.Location = new System.Drawing.Point(23, 42);
            this.panelIP.Name = "panelIP";
            this.panelIP.Size = new System.Drawing.Size(241, 56);
            this.panelIP.TabIndex = 16;
            // 
            // lblIPEnd
            // 
            this.lblIPEnd.AutoSize = true;
            this.lblIPEnd.Location = new System.Drawing.Point(188, 33);
            this.lblIPEnd.Name = "lblIPEnd";
            this.lblIPEnd.Size = new System.Drawing.Size(26, 13);
            this.lblIPEnd.TabIndex = 21;
            this.lblIPEnd.Text = "סוף";
            // 
            // numericEnd0
            // 
            this.numericEnd0.Location = new System.Drawing.Point(10, 31);
            this.numericEnd0.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericEnd0.Name = "numericEnd0";
            this.numericEnd0.Size = new System.Drawing.Size(43, 20);
            this.numericEnd0.TabIndex = 4;
            // 
            // numericEnd1
            // 
            this.numericEnd1.Location = new System.Drawing.Point(53, 31);
            this.numericEnd1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericEnd1.Name = "numericEnd1";
            this.numericEnd1.Size = new System.Drawing.Size(43, 20);
            this.numericEnd1.TabIndex = 5;
            // 
            // numericEnd2
            // 
            this.numericEnd2.Location = new System.Drawing.Point(96, 31);
            this.numericEnd2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericEnd2.Name = "numericEnd2";
            this.numericEnd2.Size = new System.Drawing.Size(43, 20);
            this.numericEnd2.TabIndex = 6;
            // 
            // numericEnd3
            // 
            this.numericEnd3.Location = new System.Drawing.Point(139, 31);
            this.numericEnd3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericEnd3.Name = "numericEnd3";
            this.numericEnd3.Size = new System.Drawing.Size(43, 20);
            this.numericEnd3.TabIndex = 7;
            // 
            // numericStart2
            // 
            this.numericStart2.Location = new System.Drawing.Point(96, 6);
            this.numericStart2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericStart2.Name = "numericStart2";
            this.numericStart2.Size = new System.Drawing.Size(43, 20);
            this.numericStart2.TabIndex = 2;
            // 
            // numericStart0
            // 
            this.numericStart0.Location = new System.Drawing.Point(10, 6);
            this.numericStart0.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericStart0.Name = "numericStart0";
            this.numericStart0.Size = new System.Drawing.Size(43, 20);
            this.numericStart0.TabIndex = 0;
            // 
            // numericStart1
            // 
            this.numericStart1.Location = new System.Drawing.Point(53, 6);
            this.numericStart1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericStart1.Name = "numericStart1";
            this.numericStart1.Size = new System.Drawing.Size(43, 20);
            this.numericStart1.TabIndex = 1;
            // 
            // numericStart3
            // 
            this.numericStart3.Location = new System.Drawing.Point(139, 6);
            this.numericStart3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericStart3.Name = "numericStart3";
            this.numericStart3.Size = new System.Drawing.Size(43, 20);
            this.numericStart3.TabIndex = 3;
            // 
            // lblIPStart
            // 
            this.lblIPStart.AutoSize = true;
            this.lblIPStart.Location = new System.Drawing.Point(188, 8);
            this.lblIPStart.Name = "lblIPStart";
            this.lblIPStart.Size = new System.Drawing.Size(42, 13);
            this.lblIPStart.TabIndex = 12;
            this.lblIPStart.Text = "התחלה";
            // 
            // lblTotalElements
            // 
            this.lblTotalElements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalElements.AutoSize = true;
            this.lblTotalElements.Location = new System.Drawing.Point(188, 318);
            this.lblTotalElements.Name = "lblTotalElements";
            this.lblTotalElements.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalElements.Size = new System.Drawing.Size(21, 13);
            this.lblTotalElements.TabIndex = 24;
            this.lblTotalElements.Text = "##";
            this.lblTotalElements.SizeChanged += new System.EventHandler(this.lblTotalElements_SizeChanged);
            // 
            // lblTotalElementsTitle
            // 
            this.lblTotalElementsTitle.AutoSize = true;
            this.lblTotalElementsTitle.Location = new System.Drawing.Point(208, 318);
            this.lblTotalElementsTitle.Name = "lblTotalElementsTitle";
            this.lblTotalElementsTitle.Size = new System.Drawing.Size(82, 13);
            this.lblTotalElementsTitle.TabIndex = 23;
            this.lblTotalElementsTitle.Text = "סה\"כ אלמנטים";
            // 
            // frmAutoInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 373);
            this.Controls.Add(this.lblTotalElements);
            this.Controls.Add(this.lblTotalElementsTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAutoInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "הכנסה אוטומטית";
            this.Load += new System.EventHandler(this.frmAutoInsert_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAutoInsert_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelCustomize.ResumeLayout(false);
            this.panelCustomize.PerformLayout();
            this.panelInsertArguments.ResumeLayout(false);
            this.panelIP.ResumeLayout(false);
            this.panelIP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnd0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnd2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnd3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStart0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton radioIP;
        private System.Windows.Forms.RadioButton radioCustomize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelIP;
        private System.Windows.Forms.Label lblIPEnd;
        public System.Windows.Forms.NumericUpDown numericEnd0;
        public System.Windows.Forms.NumericUpDown numericEnd1;
        public System.Windows.Forms.NumericUpDown numericEnd2;
        public System.Windows.Forms.NumericUpDown numericEnd3;
        public System.Windows.Forms.NumericUpDown numericStart0;
        public System.Windows.Forms.NumericUpDown numericStart1;
        public System.Windows.Forms.NumericUpDown numericStart2;
        public System.Windows.Forms.NumericUpDown numericStart3;
        private System.Windows.Forms.Label lblIPStart;
        private System.Windows.Forms.Panel panelCustomize;
        private System.Windows.Forms.Panel panelInsertArguments;
        private System.Windows.Forms.Label lblMinTitle;
        private System.Windows.Forms.Label lblMaxTitle;
        private System.Windows.Forms.Label lblArgumentTitle;
        private System.Windows.Forms.TextBox txtInsertFormatString;
        private System.Windows.Forms.Label lblExample;
        private System.Windows.Forms.Label lblTotalElements;
        private System.Windows.Forms.Label lblTotalElementsTitle;
    }
}