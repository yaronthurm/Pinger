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
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuResumePing = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuResumePing_Start = new System.Windows.Forms.ToolStripMenuItem();
            this.menuResumePing_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuResumePing_Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblIPAddressTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblIPv4Address = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuStopPing_VNC = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStopPing_RemoteDesktop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStopPing_Telnet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStopPing_SSH = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFontSize)).BeginInit();
            this.menuStopPing.SuspendLayout();
            this.menuResumePing.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuSettings,
            this.menuAutoInsert,
            this.menuAbout});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(309, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpen,
            this.menuSave});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(46, 20);
            this.menuFile.Text = "קובץ";
            // 
            // menuOpen
            // 
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(149, 22);
            this.menuOpen.Text = "פתח..";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(149, 22);
            this.menuSave.Text = "שמירה בשם..";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuSettings
            // 
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(69, 20);
            this.menuSettings.Text = "הגדרות..";
            this.menuSettings.Click += new System.EventHandler(this.menuSettings_Click);
            // 
            // menuAutoInsert
            // 
            this.menuAutoInsert.Name = "menuAutoInsert";
            this.menuAutoInsert.Size = new System.Drawing.Size(111, 20);
            this.menuAutoInsert.Text = "הכנסה אוטומטית";
            this.menuAutoInsert.Click += new System.EventHandler(this.menuAutoInsert_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(51, 20);
            this.menuAbout.Text = "אודות";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
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
            this.listView.Location = new System.Drawing.Point(12, 131);
            this.listView.Name = "listView";
            this.listView.RightToLeftLayout = true;
            this.listView.Size = new System.Drawing.Size(284, 312);
            this.listView.SmallImageList = this.imagePingState;
            this.listView.TabIndex = 6;
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
            this.columnHeader1.Text = "שם היעד";
            this.columnHeader1.Width = 136;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "כתובת היעד";
            this.columnHeader2.Width = 141;
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
            this.openFileDialog.Filter = "Text | *.txt";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text | *.txt";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(221, 93);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "הוסף";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDestinationName
            // 
            this.txtDestinationName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestinationName.Location = new System.Drawing.Point(196, 65);
            this.txtDestinationName.Name = "txtDestinationName";
            this.txtDestinationName.Size = new System.Drawing.Size(100, 20);
            this.txtDestinationName.TabIndex = 1;
            this.txtDestinationName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDestinationName_KeyDown);
            // 
            // txtDestinationAddress
            // 
            this.txtDestinationAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestinationAddress.Location = new System.Drawing.Point(36, 65);
            this.txtDestinationAddress.Name = "txtDestinationAddress";
            this.txtDestinationAddress.Size = new System.Drawing.Size(154, 20);
            this.txtDestinationAddress.TabIndex = 2;
            this.txtDestinationAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDestinationAddress_KeyDown);
            // 
            // lblDestinationName
            // 
            this.lblDestinationName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDestinationName.AutoSize = true;
            this.lblDestinationName.Location = new System.Drawing.Point(247, 49);
            this.lblDestinationName.Name = "lblDestinationName";
            this.lblDestinationName.Size = new System.Drawing.Size(52, 13);
            this.lblDestinationName.TabIndex = 5;
            this.lblDestinationName.Text = "שם היעד";
            // 
            // lblDestinationAddress
            // 
            this.lblDestinationAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDestinationAddress.AutoSize = true;
            this.lblDestinationAddress.Location = new System.Drawing.Point(63, 49);
            this.lblDestinationAddress.Name = "lblDestinationAddress";
            this.lblDestinationAddress.Size = new System.Drawing.Size(130, 13);
            this.lblDestinationAddress.TabIndex = 6;
            this.lblDestinationAddress.Text = "כתובת היעד או שם DNS";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(131, 93);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "הסר";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // numericFontSize
            // 
            this.numericFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericFontSize.Location = new System.Drawing.Point(14, 108);
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
            this.numericFontSize.Size = new System.Drawing.Size(56, 20);
            this.numericFontSize.TabIndex = 5;
            this.numericFontSize.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericFontSize.ValueChanged += new System.EventHandler(this.numericFontSize_ValueChanged);
            // 
            // lblFontSize
            // 
            this.lblFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Location = new System.Drawing.Point(14, 92);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(59, 13);
            this.lblFontSize.TabIndex = 9;
            this.lblFontSize.Text = "גודל פונט";
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 1000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // menuStopPing
            // 
            this.menuStopPing.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStopPing_Stop,
            this.menuStopPing_Edit,
            this.menuStopPing_Remove,
            this.menuStopPing_Stats,
            this.toolStripSeparator1,
            this.menuStopPing_VNC,
            this.menuStopPing_RemoteDesktop,
            this.menuStopPing_Telnet,
            this.menuStopPing_SSH});
            this.menuStopPing.Name = "menuStopPing";
            this.menuStopPing.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStopPing.Size = new System.Drawing.Size(167, 208);
            // 
            // menuStopPing_Stop
            // 
            this.menuStopPing_Stop.Name = "menuStopPing_Stop";
            this.menuStopPing_Stop.Size = new System.Drawing.Size(166, 22);
            this.menuStopPing_Stop.Text = "עצור";
            this.menuStopPing_Stop.Click += new System.EventHandler(this.menuStopPing_Stop_Click);
            // 
            // menuStopPing_Edit
            // 
            this.menuStopPing_Edit.Name = "menuStopPing_Edit";
            this.menuStopPing_Edit.Size = new System.Drawing.Size(166, 22);
            this.menuStopPing_Edit.Text = "ערוך";
            this.menuStopPing_Edit.Click += new System.EventHandler(this.menuStopPing_Edit_Click);
            // 
            // menuStopPing_Remove
            // 
            this.menuStopPing_Remove.Name = "menuStopPing_Remove";
            this.menuStopPing_Remove.Size = new System.Drawing.Size(166, 22);
            this.menuStopPing_Remove.Text = "הסר";
            this.menuStopPing_Remove.Click += new System.EventHandler(this.menuStopPing_Remove_Click);
            // 
            // menuStopPing_Stats
            // 
            this.menuStopPing_Stats.Name = "menuStopPing_Stats";
            this.menuStopPing_Stats.Size = new System.Drawing.Size(166, 22);
            this.menuStopPing_Stats.Text = "הצג סטטיסטיקה";
            this.menuStopPing_Stats.Click += new System.EventHandler(this.menuStopPing_Stats_Click);
            // 
            // menuResumePing
            // 
            this.menuResumePing.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuResumePing_Start,
            this.menuResumePing_Edit,
            this.menuResumePing_Remove});
            this.menuResumePing.Name = "menuResumePing";
            this.menuResumePing.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuResumePing.Size = new System.Drawing.Size(108, 70);
            // 
            // menuResumePing_Start
            // 
            this.menuResumePing_Start.Name = "menuResumePing_Start";
            this.menuResumePing_Start.Size = new System.Drawing.Size(107, 22);
            this.menuResumePing_Start.Text = "התחל";
            this.menuResumePing_Start.Click += new System.EventHandler(this.menuResumePing_Start_Click);
            // 
            // menuResumePing_Edit
            // 
            this.menuResumePing_Edit.Name = "menuResumePing_Edit";
            this.menuResumePing_Edit.Size = new System.Drawing.Size(107, 22);
            this.menuResumePing_Edit.Text = "ערוך";
            this.menuResumePing_Edit.Click += new System.EventHandler(this.menuResumePing_Edit_Click);
            // 
            // menuResumePing_Remove
            // 
            this.menuResumePing_Remove.Name = "menuResumePing_Remove";
            this.menuResumePing_Remove.Size = new System.Drawing.Size(107, 22);
            this.menuResumePing_Remove.Text = "הסר";
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
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblIPAddressTitle,
            this.lblIPv4Address,
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 446);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(309, 22);
            this.statusStrip1.TabIndex = 10;
            // 
            // lblIPAddressTitle
            // 
            this.lblIPAddressTitle.Name = "lblIPAddressTitle";
            this.lblIPAddressTitle.Size = new System.Drawing.Size(113, 17);
            this.lblIPAddressTitle.Text = "Local IPv4 Address:";
            // 
            // lblIPv4Address
            // 
            this.lblIPv4Address.Name = "lblIPv4Address";
            this.lblIPv4Address.Size = new System.Drawing.Size(47, 17);
            this.lblIPv4Address.Text = "0.0.0.0";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "All IP Addresses";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // menuStopPing_VNC
            // 
            this.menuStopPing_VNC.Name = "menuStopPing_VNC";
            this.menuStopPing_VNC.Size = new System.Drawing.Size(166, 22);
            this.menuStopPing_VNC.Text = "Ultra VNC";
            this.menuStopPing_VNC.Click += new System.EventHandler(this.menuStopPing_VNC_Click);
            // 
            // menuStopPing_RemoteDesktop
            // 
            this.menuStopPing_RemoteDesktop.Name = "menuStopPing_RemoteDesktop";
            this.menuStopPing_RemoteDesktop.Size = new System.Drawing.Size(166, 22);
            this.menuStopPing_RemoteDesktop.Text = "Remote Desktop";
            this.menuStopPing_RemoteDesktop.Click += new System.EventHandler(this.menuStopPing_RemoteDesktop_Click);
            // 
            // menuStopPing_Telnet
            // 
            this.menuStopPing_Telnet.Name = "menuStopPing_Telnet";
            this.menuStopPing_Telnet.Size = new System.Drawing.Size(166, 22);
            this.menuStopPing_Telnet.Text = "Telnet";
            this.menuStopPing_Telnet.Click += new System.EventHandler(this.menuStopPing_Telnet_Click);
            // 
            // menuStopPing_SSH
            // 
            this.menuStopPing_SSH.Name = "menuStopPing_SSH";
            this.menuStopPing_SSH.Size = new System.Drawing.Size(166, 22);
            this.menuStopPing_SSH.Text = "SSH";
            this.menuStopPing_SSH.Click += new System.EventHandler(this.menuStopPing_SSH_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 468);
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
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pinger";
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
        private System.Windows.Forms.ToolStripMenuItem menuSave;
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
    }
}

