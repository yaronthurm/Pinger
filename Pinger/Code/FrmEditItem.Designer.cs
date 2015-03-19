namespace PingTester
{
    partial class FrmEditItem
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
            this.lblDestinationAddress = new System.Windows.Forms.Label();
            this.lblDestinationName = new System.Windows.Forms.Label();
            this.txtDestinationAddress = new System.Windows.Forms.TextBox();
            this.txtDestinationName = new System.Windows.Forms.TextBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblEditMultipleItems = new System.Windows.Forms.Label();
            this.checkName = new System.Windows.Forms.CheckBox();
            this.checkAddress = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblDestinationAddress
            // 
            this.lblDestinationAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDestinationAddress.AutoSize = true;
            this.lblDestinationAddress.Location = new System.Drawing.Point(30, 29);
            this.lblDestinationAddress.Name = "lblDestinationAddress";
            this.lblDestinationAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDestinationAddress.Size = new System.Drawing.Size(130, 13);
            this.lblDestinationAddress.TabIndex = 13;
            this.lblDestinationAddress.Text = "כתובת היעד או שם DNS";
            // 
            // lblDestinationName
            // 
            this.lblDestinationName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDestinationName.AutoSize = true;
            this.lblDestinationName.Location = new System.Drawing.Point(214, 29);
            this.lblDestinationName.Name = "lblDestinationName";
            this.lblDestinationName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDestinationName.Size = new System.Drawing.Size(52, 13);
            this.lblDestinationName.TabIndex = 12;
            this.lblDestinationName.Text = "שם היעד";
            // 
            // txtDestinationAddress
            // 
            this.txtDestinationAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestinationAddress.Location = new System.Drawing.Point(3, 45);
            this.txtDestinationAddress.Name = "txtDestinationAddress";
            this.txtDestinationAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDestinationAddress.Size = new System.Drawing.Size(154, 20);
            this.txtDestinationAddress.TabIndex = 2;
            this.txtDestinationAddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDestinationAddress_KeyUp);
            // 
            // txtDestinationName
            // 
            this.txtDestinationName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestinationName.Location = new System.Drawing.Point(163, 45);
            this.txtDestinationName.Name = "txtDestinationName";
            this.txtDestinationName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDestinationName.Size = new System.Drawing.Size(100, 20);
            this.txtDestinationName.TabIndex = 1;
            this.txtDestinationName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDestinationName_KeyUp);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(63, 98);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 4;
            this.btnCancle.Text = "ביטול";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(163, 98);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "אישור";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblEditMultipleItems
            // 
            this.lblEditMultipleItems.AutoSize = true;
            this.lblEditMultipleItems.Location = new System.Drawing.Point(152, 9);
            this.lblEditMultipleItems.Name = "lblEditMultipleItems";
            this.lblEditMultipleItems.Size = new System.Drawing.Size(114, 13);
            this.lblEditMultipleItems.TabIndex = 14;
            this.lblEditMultipleItems.Text = "עריכת ערכים מרובים";
            // 
            // checkName
            // 
            this.checkName.AutoSize = true;
            this.checkName.Location = new System.Drawing.Point(197, 71);
            this.checkName.Name = "checkName";
            this.checkName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkName.Size = new System.Drawing.Size(66, 17);
            this.checkName.TabIndex = 15;
            this.checkName.Text = "שנה שם";
            this.checkName.UseVisualStyleBackColor = true;
            this.checkName.CheckedChanged += new System.EventHandler(this.checkName_CheckedChanged);
            // 
            // checkAddress
            // 
            this.checkAddress.AutoSize = true;
            this.checkAddress.Location = new System.Drawing.Point(74, 71);
            this.checkAddress.Name = "checkAddress";
            this.checkAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkAddress.Size = new System.Drawing.Size(83, 17);
            this.checkAddress.TabIndex = 15;
            this.checkAddress.Text = "שנה כתובת";
            this.checkAddress.UseVisualStyleBackColor = true;
            this.checkAddress.CheckedChanged += new System.EventHandler(this.checkAddress_CheckedChanged);
            // 
            // frmEditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 127);
            this.Controls.Add(this.checkAddress);
            this.Controls.Add(this.checkName);
            this.Controls.Add(this.lblEditMultipleItems);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblDestinationAddress);
            this.Controls.Add(this.lblDestinationName);
            this.Controls.Add(this.txtDestinationAddress);
            this.Controls.Add(this.txtDestinationName);
            this.Name = "frmEditItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "עריכה";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditItem_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDestinationAddress;
        private System.Windows.Forms.Label lblDestinationName;
        private System.Windows.Forms.TextBox txtDestinationAddress;
        private System.Windows.Forms.TextBox txtDestinationName;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblEditMultipleItems;
        private System.Windows.Forms.CheckBox checkName;
        private System.Windows.Forms.CheckBox checkAddress;
    }
}