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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditItem));
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
            resources.ApplyResources(this.lblDestinationAddress, "lblDestinationAddress");
            this.lblDestinationAddress.Name = "lblDestinationAddress";
            // 
            // lblDestinationName
            // 
            resources.ApplyResources(this.lblDestinationName, "lblDestinationName");
            this.lblDestinationName.Name = "lblDestinationName";
            // 
            // txtDestinationAddress
            // 
            resources.ApplyResources(this.txtDestinationAddress, "txtDestinationAddress");
            this.txtDestinationAddress.Name = "txtDestinationAddress";
            this.txtDestinationAddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDestinationAddress_KeyUp);
            // 
            // txtDestinationName
            // 
            resources.ApplyResources(this.txtDestinationName, "txtDestinationName");
            this.txtDestinationName.Name = "txtDestinationName";
            this.txtDestinationName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDestinationName_KeyUp);
            // 
            // btnCancle
            // 
            resources.ApplyResources(this.btnCancle, "btnCancle");
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblEditMultipleItems
            // 
            resources.ApplyResources(this.lblEditMultipleItems, "lblEditMultipleItems");
            this.lblEditMultipleItems.Name = "lblEditMultipleItems";
            // 
            // checkName
            // 
            resources.ApplyResources(this.checkName, "checkName");
            this.checkName.Name = "checkName";
            this.checkName.UseVisualStyleBackColor = true;
            this.checkName.CheckedChanged += new System.EventHandler(this.checkName_CheckedChanged);
            // 
            // checkAddress
            // 
            resources.ApplyResources(this.checkAddress, "checkAddress");
            this.checkAddress.Name = "checkAddress";
            this.checkAddress.UseVisualStyleBackColor = true;
            this.checkAddress.CheckedChanged += new System.EventHandler(this.checkAddress_CheckedChanged);
            // 
            // FrmEditItem
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkAddress);
            this.Controls.Add(this.checkName);
            this.Controls.Add(this.lblEditMultipleItems);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblDestinationAddress);
            this.Controls.Add(this.lblDestinationName);
            this.Controls.Add(this.txtDestinationAddress);
            this.Controls.Add(this.txtDestinationName);
            this.Name = "FrmEditItem";
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