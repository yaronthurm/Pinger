namespace PingTester
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAutoInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imagePingState = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDestinationName = new System.Windows.Forms.TextBox();
            this.txtDestinationAddress = new System.Windows.Forms.TextBox();
            this.lblDestinationName = new System.Windows.Forms.Label();
            this.lblDestinationAddress = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.numericFontSize = new System.Windows.Forms.NumericUpDown();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.menuStopPing = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStopPing_Stop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStopPing_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStopPing_Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStopPing_Stats = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStopPing_Rapid = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStopPing_VNC = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStopPing_RemoteDesktop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStopPing_Telnet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStopPing_SSH = new System.Windows.Forms.ToolStripMenuItem();
            this.menuResumePing = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuResumePing_Start = new System.Windows.Forms.ToolStripMenuItem();
            this.menuResumePing_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuResumePing_Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblIPAddressTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblIPv4Address = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFontSize)).BeginInit();
            this.menuStopPing.SuspendLayout();
            this.menuResumePing.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuSettings,
            this.menuAutoInsert,
            this.menuAbout});
            this.menuStrip.Name = "menuStrip";
            // 
            // menuFile
            // 
            resources.ApplyResources(this.menuFile, "menuFile");
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpen,
            this.menuSaveAS});
            this.menuFile.Name = "menuFile";
            // 
            // menuOpen
            // 
            resources.ApplyResources(this.menuOpen, "menuOpen");
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // menuSaveAS
            // 
            resources.ApplyResources(this.menuSaveAS, "menuSaveAS");
            this.menuSaveAS.Name = "menuSaveAS";
            this.menuSaveAS.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuSettings
            // 
            resources.ApplyResources(this.menuSettings, "menuSettings");
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Click += new System.EventHandler(this.menuSettings_Click);
            // 
            // menuAutoInsert
            // 
            resources.ApplyResources(this.menuAutoInsert, "menuAutoInsert");
            this.menuAutoInsert.Name = "menuAutoInsert";
            this.menuAutoInsert.Click += new System.EventHandler(this.menuAutoInsert_Click);
            // 
            // menuAbout
            // 
            resources.ApplyResources(this.menuAbout, "menuAbout");
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // listView
            // 
            resources.ApplyResources(this.listView, "listView");
            this.listView.AllowDrop = true;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Name = "listView";
            this.listView.SmallImageList = this.imagePingState;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.ItemActivate += new System.EventHandler(this.listView_ItemActivate);
            this.listView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listView_ItemDrag);
            this.listView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_KeyDown);
            this.listView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listView_MouseMove);
            this.listView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView_MouseUp);
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
            // openFileDialog
            // 
            resources.ApplyResources(this.openFileDialog, "openFileDialog");
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // saveFileDialog
            // 
            resources.ApplyResources(this.saveFileDialog, "saveFileDialog");
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDestinationName
            // 
            resources.ApplyResources(this.txtDestinationName, "txtDestinationName");
            this.txtDestinationName.Name = "txtDestinationName";
            this.txtDestinationName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDestinationName_KeyDown);
            // 
            // txtDestinationAddress
            // 
            resources.ApplyResources(this.txtDestinationAddress, "txtDestinationAddress");
            this.txtDestinationAddress.Name = "txtDestinationAddress";
            this.txtDestinationAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDestinationAddress_KeyDown);
            // 
            // lblDestinationName
            // 
            resources.ApplyResources(this.lblDestinationName, "lblDestinationName");
            this.lblDestinationName.Name = "lblDestinationName";
            // 
            // lblDestinationAddress
            // 
            resources.ApplyResources(this.lblDestinationAddress, "lblDestinationAddress");
            this.lblDestinationAddress.Name = "lblDestinationAddress";
            // 
            // btnRemove
            // 
            resources.ApplyResources(this.btnRemove, "btnRemove");
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // numericFontSize
            // 
            resources.ApplyResources(this.numericFontSize, "numericFontSize");
            this.numericFontSize.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericFontSize.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericFontSize.Name = "numericFontSize";
            this.numericFontSize.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericFontSize.ValueChanged += new System.EventHandler(this.numericFontSize_ValueChanged);
            // 
            // lblFontSize
            // 
            resources.ApplyResources(this.lblFontSize, "lblFontSize");
            this.lblFontSize.Name = "lblFontSize";
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 1000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // menuStopPing
            // 
            resources.ApplyResources(this.menuStopPing, "menuStopPing");
            this.menuStopPing.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStopPing_Stop,
            this.menuStopPing_Edit,
            this.menuStopPing_Remove,
            this.menuStopPing_Stats,
            this.menuStopPing_Rapid,
            this.toolStripSeparator1,
            this.menuStopPing_VNC,
            this.menuStopPing_RemoteDesktop,
            this.menuStopPing_Telnet,
            this.menuStopPing_SSH});
            this.menuStopPing.Name = "menuStopPing";
            // 
            // menuStopPing_Stop
            // 
            resources.ApplyResources(this.menuStopPing_Stop, "menuStopPing_Stop");
            this.menuStopPing_Stop.Name = "menuStopPing_Stop";
            this.menuStopPing_Stop.Click += new System.EventHandler(this.menuStopPing_Stop_Click);
            // 
            // menuStopPing_Edit
            // 
            resources.ApplyResources(this.menuStopPing_Edit, "menuStopPing_Edit");
            this.menuStopPing_Edit.Name = "menuStopPing_Edit";
            this.menuStopPing_Edit.Click += new System.EventHandler(this.menuStopPing_Edit_Click);
            // 
            // menuStopPing_Remove
            // 
            resources.ApplyResources(this.menuStopPing_Remove, "menuStopPing_Remove");
            this.menuStopPing_Remove.Name = "menuStopPing_Remove";
            this.menuStopPing_Remove.Click += new System.EventHandler(this.menuStopPing_Remove_Click);
            // 
            // menuStopPing_Stats
            // 
            resources.ApplyResources(this.menuStopPing_Stats, "menuStopPing_Stats");
            this.menuStopPing_Stats.Name = "menuStopPing_Stats";
            this.menuStopPing_Stats.Click += new System.EventHandler(this.menuStopPing_Stats_Click);
            // 
            // menuStopPing_Rapid
            // 
            resources.ApplyResources(this.menuStopPing_Rapid, "menuStopPing_Rapid");
            this.menuStopPing_Rapid.Name = "menuStopPing_Rapid";
            this.menuStopPing_Rapid.Click += new System.EventHandler(this.menuStopPing_Rapid_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // menuStopPing_VNC
            // 
            resources.ApplyResources(this.menuStopPing_VNC, "menuStopPing_VNC");
            this.menuStopPing_VNC.Name = "menuStopPing_VNC";
            this.menuStopPing_VNC.Click += new System.EventHandler(this.menuStopPing_VNC_Click);
            // 
            // menuStopPing_RemoteDesktop
            // 
            resources.ApplyResources(this.menuStopPing_RemoteDesktop, "menuStopPing_RemoteDesktop");
            this.menuStopPing_RemoteDesktop.Name = "menuStopPing_RemoteDesktop";
            this.menuStopPing_RemoteDesktop.Click += new System.EventHandler(this.menuStopPing_RemoteDesktop_Click);
            // 
            // menuStopPing_Telnet
            // 
            resources.ApplyResources(this.menuStopPing_Telnet, "menuStopPing_Telnet");
            this.menuStopPing_Telnet.Name = "menuStopPing_Telnet";
            this.menuStopPing_Telnet.Click += new System.EventHandler(this.menuStopPing_Telnet_Click);
            // 
            // menuStopPing_SSH
            // 
            resources.ApplyResources(this.menuStopPing_SSH, "menuStopPing_SSH");
            this.menuStopPing_SSH.Name = "menuStopPing_SSH";
            this.menuStopPing_SSH.Click += new System.EventHandler(this.menuStopPing_SSH_Click);
            // 
            // menuResumePing
            // 
            resources.ApplyResources(this.menuResumePing, "menuResumePing");
            this.menuResumePing.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuResumePing_Start,
            this.menuResumePing_Edit,
            this.menuResumePing_Remove});
            this.menuResumePing.Name = "menuResumePing";
            // 
            // menuResumePing_Start
            // 
            resources.ApplyResources(this.menuResumePing_Start, "menuResumePing_Start");
            this.menuResumePing_Start.Name = "menuResumePing_Start";
            this.menuResumePing_Start.Click += new System.EventHandler(this.menuResumePing_Start_Click);
            // 
            // menuResumePing_Edit
            // 
            resources.ApplyResources(this.menuResumePing_Edit, "menuResumePing_Edit");
            this.menuResumePing_Edit.Name = "menuResumePing_Edit";
            this.menuResumePing_Edit.Click += new System.EventHandler(this.menuResumePing_Edit_Click);
            // 
            // menuResumePing_Remove
            // 
            resources.ApplyResources(this.menuResumePing_Remove, "menuResumePing_Remove");
            this.menuResumePing_Remove.Name = "menuResumePing_Remove";
            this.menuResumePing_Remove.Click += new System.EventHandler(this.menuResumePing_Remove_Click);
            // 
            // imageListIcons
            // 
            this.imageListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcons.ImageStream")));
            this.imageListIcons.TransparentColor = System.Drawing.Color.White;
            this.imageListIcons.Images.SetKeyName(0, "PingerIcon Green-Red.bmp");
            this.imageListIcons.Images.SetKeyName(1, "PingerIcon Green-Green.bmp");
            this.imageListIcons.Images.SetKeyName(2, "PingerIcon Red-Red.bmp");
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblIPAddressTitle,
            this.lblIPv4Address,
            this.toolStripDropDownButton1});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // lblIPAddressTitle
            // 
            resources.ApplyResources(this.lblIPAddressTitle, "lblIPAddressTitle");
            this.lblIPAddressTitle.Name = "lblIPAddressTitle";
            // 
            // lblIPv4Address
            // 
            resources.ApplyResources(this.lblIPv4Address, "lblIPv4Address");
            this.lblIPv4Address.Name = "lblIPv4Address";
            // 
            // toolStripDropDownButton1
            // 
            resources.ApplyResources(this.toolStripDropDownButton1, "toolStripDropDownButton1");
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            // 
            // lblFileName
            // 
            resources.ApplyResources(this.lblFileName, "lblFileName");
            this.lblFileName.Name = "lblFileName";
            // 
            // txtFileName
            // 
            resources.ApplyResources(this.txtFileName, "txtFileName");
            this.txtFileName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblFontSize);
            this.Controls.Add(this.numericFontSize);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblDestinationAddress);
            this.Controls.Add(this.lblDestinationName);
            this.Controls.Add(this.txtDestinationAddress);
            this.Controls.Add(this.txtDestinationName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFontSize)).EndInit();
            this.menuStopPing.ResumeLayout(false);
            this.menuResumePing.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDestinationName;
        private System.Windows.Forms.TextBox txtDestinationAddress;
        private System.Windows.Forms.Label lblDestinationName;
        private System.Windows.Forms.Label lblDestinationAddress;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAS;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ToolStripMenuItem menuSettings;
        private System.Windows.Forms.NumericUpDown numericFontSize;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.ToolStripMenuItem menuAutoInsert;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.ContextMenuStrip menuStopPing;
        private System.Windows.Forms.ToolStripMenuItem menuStopPing_Stop;
        private System.Windows.Forms.ContextMenuStrip menuResumePing;
        private System.Windows.Forms.ToolStripMenuItem menuResumePing_Start;
        private System.Windows.Forms.ToolStripMenuItem menuStopPing_Edit;
        private System.Windows.Forms.ToolStripMenuItem menuResumePing_Edit;
        private System.Windows.Forms.ToolStripMenuItem menuStopPing_Remove;
        private System.Windows.Forms.ToolStripMenuItem menuResumePing_Remove;
        private System.Windows.Forms.ImageList imageListIcons;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripStatusLabel lblIPAddressTitle;
        private System.Windows.Forms.ToolStripStatusLabel lblIPv4Address;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        public System.Windows.Forms.ImageList imagePingState;
        private System.Windows.Forms.ToolStripMenuItem menuStopPing_Stats;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuStopPing_VNC;
        private System.Windows.Forms.ToolStripMenuItem menuStopPing_RemoteDesktop;
        private System.Windows.Forms.ToolStripMenuItem menuStopPing_Telnet;
        private System.Windows.Forms.ToolStripMenuItem menuStopPing_SSH;
        private System.Windows.Forms.ToolStripMenuItem menuStopPing_Rapid;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFileName;
    }
}

