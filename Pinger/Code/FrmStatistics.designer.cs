namespace PingTester
{
    partial class FrmStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStatistics));
            this.lblPercent = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imagePingState = new System.Windows.Forms.ImageList(this.components);
            this.lblFailed = new System.Windows.Forms.Label();
            this.lblSuccessed = new System.Windows.Forms.Label();
            this.btnResetStatistics = new System.Windows.Forms.Button();
            this.timerUpdateView = new System.Windows.Forms.Timer(this.components);
            this.lblStats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.ForeColor = System.Drawing.Color.Black;
            this.lblPercent.Location = new System.Drawing.Point(12, 68);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(27, 13);
            this.lblPercent.TabIndex = 8;
            this.lblPercent.Text = "N/A";
            // 
            // listView
            // 
            this.listView.AllowDrop = true;
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(3, 117);
            this.listView.Name = "listView";
            this.listView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView.RightToLeftLayout = true;
            this.listView.Size = new System.Drawing.Size(314, 270);
            this.listView.SmallImageList = this.imagePingState;
            this.listView.TabIndex = 7;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "זמן שינוי";
            this.columnHeader1.Width = 174;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "מספר נסיונות";
            this.columnHeader2.Width = 106;
            // 
            // imagePingState
            // 
            this.imagePingState.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagePingState.ImageStream")));
            this.imagePingState.TransparentColor = System.Drawing.Color.Transparent;
            this.imagePingState.Images.SetKeyName(0, "israel stop sign.png");
            this.imagePingState.Images.SetKeyName(1, "X.png");
            this.imagePingState.Images.SetKeyName(2, "V2.png");
            // 
            // lblFailed
            // 
            this.lblFailed.AutoSize = true;
            this.lblFailed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblFailed.ForeColor = System.Drawing.Color.Red;
            this.lblFailed.Location = new System.Drawing.Point(12, 46);
            this.lblFailed.Name = "lblFailed";
            this.lblFailed.Size = new System.Drawing.Size(54, 19);
            this.lblFailed.TabIndex = 4;
            this.lblFailed.Text = "label2";
            // 
            // lblSuccessed
            // 
            this.lblSuccessed.AutoSize = true;
            this.lblSuccessed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSuccessed.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblSuccessed.Location = new System.Drawing.Point(12, 21);
            this.lblSuccessed.Name = "lblSuccessed";
            this.lblSuccessed.Size = new System.Drawing.Size(54, 19);
            this.lblSuccessed.TabIndex = 3;
            this.lblSuccessed.Text = "label1";
            // 
            // btnResetStatistics
            // 
            this.btnResetStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetStatistics.Location = new System.Drawing.Point(242, 21);
            this.btnResetStatistics.Name = "btnResetStatistics";
            this.btnResetStatistics.Size = new System.Drawing.Size(75, 23);
            this.btnResetStatistics.TabIndex = 9;
            this.btnResetStatistics.Text = "איפוס";
            this.btnResetStatistics.UseVisualStyleBackColor = true;
            this.btnResetStatistics.Click += new System.EventHandler(this.btnResetStatistics_Click);
            // 
            // timerUpdateView
            // 
            this.timerUpdateView.Enabled = true;
            this.timerUpdateView.Interval = 2000;
            this.timerUpdateView.Tick += new System.EventHandler(this.timerUpdateView_Tick);
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.ForeColor = System.Drawing.Color.Black;
            this.lblStats.Location = new System.Drawing.Point(13, 101);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(57, 13);
            this.lblStats.TabIndex = 10;
            this.lblStats.Text = "Stats: N/A";
            // 
            // FrmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 389);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.btnResetStatistics);
            this.Controls.Add(this.lblSuccessed);
            this.Controls.Add(this.lblFailed);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.listView);
            this.Name = "FrmStatistics";
            this.Text = "frmStatistics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStatistics_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblFailed;
        private System.Windows.Forms.Label lblSuccessed;
        private System.Windows.Forms.Button btnResetStatistics;
        private System.Windows.Forms.Timer timerUpdateView;
        public System.Windows.Forms.ImageList imagePingState;
        private System.Windows.Forms.Label lblStats;
    }
}