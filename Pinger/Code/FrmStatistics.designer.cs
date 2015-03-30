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
            resources.ApplyResources(this.lblPercent, "lblPercent");
            this.lblPercent.ForeColor = System.Drawing.Color.Black;
            this.lblPercent.Name = "lblPercent";
            // 
            // listView
            // 
            this.listView.AllowDrop = true;
            resources.ApplyResources(this.listView, "listView");
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Name = "listView";
            this.listView.SmallImageList = this.imagePingState;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
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
            resources.ApplyResources(this.lblFailed, "lblFailed");
            this.lblFailed.ForeColor = System.Drawing.Color.Red;
            this.lblFailed.Name = "lblFailed";
            // 
            // lblSuccessed
            // 
            resources.ApplyResources(this.lblSuccessed, "lblSuccessed");
            this.lblSuccessed.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblSuccessed.Name = "lblSuccessed";
            // 
            // btnResetStatistics
            // 
            resources.ApplyResources(this.btnResetStatistics, "btnResetStatistics");
            this.btnResetStatistics.Name = "btnResetStatistics";
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
            resources.ApplyResources(this.lblStats, "lblStats");
            this.lblStats.ForeColor = System.Drawing.Color.Black;
            this.lblStats.Name = "lblStats";
            // 
            // FrmStatistics
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.btnResetStatistics);
            this.Controls.Add(this.lblSuccessed);
            this.Controls.Add(this.lblFailed);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.listView);
            this.Name = "FrmStatistics";
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