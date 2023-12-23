using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace PingTester
{
    public partial class FrmMain : Form
    {
        private enum IconImageID {GreenRed = 0, GreenGreen = 1, RedRed = 2};
        private enum StateImageID {Success = 2, Failure = 1, Stopped = 0};
        
        #region Members
        /// <summary>
        /// The name of the file to open on start-up. Will be loaded on the Load event.
        /// If empty, no item will be added to the list on start-up.
        /// </summary>
        public string StartupFileName = "";
        
        public string LastPingerFileName = "";
        
        private FrmAbout _aboutForm;
        
        /// <summary>
        /// List of icons for the application forms.
        /// </summary>
        private List<Icon> _formsIcons;
        
        /// <summary>
        /// List of PingPerformers objects that will use to the actual pinging operation
        /// </summary>
        private List<PingPerformer> _pingPerformers;
        
        /// <summary>
        /// List of forms that will save the replies from the ping operation. Each form
        /// will be assigned to a specific PingPerformer
        /// </summary>
        private List<FrmPingLog> _logForms;
        
        private List<FrmStatistics> _statisticsForms;
        
        /// <summary>
        /// The form that will give the user the option to change the settings of the ping, like
        /// ttl, timeout delay, ping interval etc.
        /// </summary>
        private FrmSettings _settingsForm;

        private FrmRapid _rapidForm;
        
        /// <summary>
        /// The form that will give the user the ability to add multiple destinations at once.
        /// e.g: all addresses from 192.168.1.1 to 192.168.1.255
        /// </summary>
        private FrmAutoInsert _autoInsertForm;
        
        /// <summary>
        /// The form that gives the user the ability to edit an item after inserting it (changing
        /// its name or even the destination address)
        /// </summary>
        private FrmEditItem _editItemForm;
        
        /// <summary>
        /// In order to give the user the feature of re-ordering the items in the pings list, 
        /// we need to know when a drag operation has started.
        /// </summary>
        private bool _dragItemStarted = false;
        
        /// <summary>
        /// In order to give the user the feature of re-ordering the items in the pings list, 
        /// we need to know on which item the drag operation is acting upon.
        /// </summary>
        private ListViewItem _dragItem;        
        
        /// <summary>
        /// The title of the main form as assigned in design mode. The application need to change
        /// it in order to show how many successful pings are there in any moment, and should
        /// be able to restore it when no more items are in the list.
        /// </summary>
        private string _originalCaption;
        
        /// <summary>
        /// A class that raises an event whenever the ip of thie host is changed
        /// </summary>
        private YaronThurm.Network.IPChangeNotifier _ipNotifier;

        #endregion

        #region Ping settings members
        private int _ttl = 128;
        private int _bufferSize = 32; // [bytes]
        private bool _dontFragment = true;
        private int _timeout = 2000;// [msec]
        private int _pingInterval = 1000; // [msec]
        private int _stabilityCount = 10;
        private int _capacity = 100;
        #endregion

        #region Constructor
        public FrmMain()
        {
            // Initialize members
            this._aboutForm = new FrmAbout();
            this._pingPerformers = new List<PingPerformer>();
            this._logForms = new List<FrmPingLog>();
            this._statisticsForms = new List<FrmStatistics>();
            this._settingsForm = new FrmSettings();
            this._autoInsertForm = new FrmAutoInsert();
            this._editItemForm = new FrmEditItem();
            this._rapidForm = new FrmRapid();
            this._ipNotifier = new YaronThurm.Network.IPChangeNotifier();


            InitializeComponent();

            // Save design-mode caption
            this._originalCaption = this.Text;

            // Set form's icons
            this._formsIcons = new List<Icon>();
            for (int i = 0; i < this.imageListIcons.Images.Count; i++)
                this._formsIcons.Add(this.MakeIcon(this.imageListIcons.Images[i], 100, true));
            this.SetFormsIcons(IconImageID.GreenRed);
            
            // Subscribe to events
            this._settingsForm.OKClicked += new EventHandler(this.settingsForm_OKClicked);
            this._autoInsertForm.OKClicked += new EventHandler(this.autoInsertForm_OKClicked);
            this._editItemForm.OKClicked += new EventHandler(this.editItemForm_OKClicked);
            this._ipNotifier.IPChanged += new EventHandler(ipNotifier_IPChanged);
        }
        #endregion
        
        #region Form events hadlers
        private void frmMain_Load(object sender, EventArgs e)
        {          
            // Set font size
            Font f = this.listView.Font;
            int size = (int)this.numericFontSize.Value;
            this.listView.Font = new Font(f.FontFamily, size, f.Style);

            // Set focus to the destination-name textbox
            this.txtDestinationName.Focus();
                       
            // Load data from startup file
            if (this.StartupFileName != "")
            {
                // Check if the name given is not a file
                if (! StringExtensions.IsFile(this.StartupFileName))
                {
                    // Try adding it to the current directory
                    this.StartupFileName = Path.Combine(System.Environment.CurrentDirectory, this.StartupFileName);
                }

                this.ReadFromFile(this.StartupFileName);
            }

            // Start the ip notifier
            this._ipNotifier.Start();
        }

        private void ipNotifier_IPChanged(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                EventHandler del = new EventHandler(this.ipNotifier_IPChanged);
                this.BeginInvoke(del, new object[] { sender, e });
            }
            else
            {
                // Fill IP addresses of the host:
                IPAddress[] addresses = this._ipNotifier.IPAddresses;
                this.toolStripDropDownButton1.DropDownItems.Clear();
                this.toolStripDropDownButton1.DropDownItems.Add("All IP Addresses for this host:");
                int counter = 0;
                foreach (System.Net.IPAddress ip in addresses)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        this.lblIPv4Address.Text = ip.ToString();

                    this.toolStripDropDownButton1.DropDownItems.Add((++counter).ToString() + ".  " + ip.ToString());
                }
            }
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            // If minimized, hide all the log forms
            if (this.WindowState == FormWindowState.Minimized)
            {
                foreach (FrmPingLog form in this._logForms)
                    form.Hide();
            }
            else // If maximized, show all the log forms that were shown before
            {
                foreach (FrmPingLog form in this._logForms)
                {
                    if (form.ShowForm)
                    {
                        form.Show();
                        form.Focus();
                    }
                }
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { this.SaveToFile(this.LastPingerFileName); }
            catch { }
        }

        #endregion

        #region File dialogs events handlers
        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            // Save items list to the selected file
            this.SaveToFile(this.saveFileDialog.FileName);
            this.UpdateLoadedFile(this.saveFileDialog.FileName);
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            // First, clear all items:
            // Select all items
            ListView.SelectedIndexCollection selectedIndeces = new ListView.SelectedIndexCollection(this.listView);
            for (int i = 0; i < this.listView.Items.Count; i++)
                selectedIndeces.Add(i);

            // Remove the selected items
            this.btnRemove_Click(this, EventArgs.Empty);

            // Read from the file selected
            this.ReadFromFile(this.openFileDialog.FileName);
            this.UpdateLoadedFile(this.openFileDialog.FileName);
        }
        
        #endregion

        #region Form controls events handlers
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Add the destination and set focus back to the name's textbox
                this.AddNewPinger(this.txtDestinationName.Text, this.txtDestinationAddress.Text);
                this.txtDestinationName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n",
                    "Error adding new items", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }            
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.listView.SelectedItems.Count <= 0)
                return;

            int totalElements = this.listView.SelectedItems.Count;
            int removedElementsCount = 0;
            double removedPercentage = 0;
            string originalText = this.Text;
            
            this.Enabled = false;
            this.Text = "Progress: " + removedPercentage.ToString() + "%";
        
            while (this.listView.SelectedItems.Count > 0)
            {
                try
                {
                    // Go throw every selected item and tell it to stop
                    for (int i = this.listView.SelectedIndices.Count - 1; i >= 0; i--)
                    {
                        int index = this.listView.SelectedIndices[i];
                        this._pingPerformers[index].InitiateStop();
                    }

                    // Go throw every selected item from the last to the first one
                    while (this.listView.SelectedItems.Count > 0)
                    {
                        Application.DoEvents();
                        for (int i = this.listView.SelectedIndices.Count - 1; i >= 0; i--)
                        {
                            int index = this.listView.SelectedIndices[i];
                            if (this._pingPerformers[index].Stopped)
                            {
                                this.listView.Items.RemoveAt(index);
                                this._pingPerformers.RemoveAt(index);
                                this._logForms[index].Close();
                                this._logForms.RemoveAt(index);
                                this._statisticsForms[index].Close();
                                this._statisticsForms.RemoveAt(index);

                                removedElementsCount++;
                                removedPercentage = (int)((double)removedElementsCount / (double)totalElements * 100);
                                this.Text = "Progress: " + removedPercentage.ToString() + "%";
                            }
                        }
                    }
                }
                catch (OutOfMemoryException) // Most likely "OutOfMemoryException"
                {
                    int numberOfItemsToRemove = 5;
                    while (this.listView.SelectedItems.Count > 0 && numberOfItemsToRemove > 0)
                    {
                        int index = this.listView.SelectedIndices[this.listView.SelectedIndices.Count - 1];
                        this._pingPerformers[index].Stop();
                        this._pingPerformers.RemoveAt(index);
                        this._logForms[index].Close();
                        this._logForms.RemoveAt(index);
                        this._statisticsForms[index].Close();
                        this._statisticsForms.RemoveAt(index);
                        this.listView.Items.RemoveAt(index);

                        removedPercentage = (int)((double)removedElementsCount / (double)totalElements * 100);
                        this.Text = "*** Progress: " + removedPercentage.ToString() + "% ***";
                        removedElementsCount++;
                        numberOfItemsToRemove--;
                    }
                }
                catch (Exception)
                {
                    break;
                }
            } // While ends here

            // Clean-up
            GC.Collect();

            this.txtDestinationAddress.Text = "";
            this.txtDestinationName.Text = "";
            this.Text = originalText;
            if (this._pingPerformers.Count == 0)
                this.Text = this._originalCaption;
            this.Enabled = true;
        }
        private void btnRemove_Click_Syncronized(object sender, EventArgs e)
        {
            // This is the old method of removing items - in sereis instead of parellal
            
            if (this.listView.SelectedItems.Count > 0)
            {
                this.Enabled = false;

                int totalElements = this.listView.SelectedIndices.Count;
                int removesElementsCount = 0;
                double removedPercentage;
                string originalText = this.Text;
                
                // Go throw every selected item from the last to the first one
                for (int i = this.listView.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    int index = this.listView.SelectedIndices[i];
                    removedPercentage = (int)((double)removesElementsCount / (double)totalElements * 100);
                    this.Text = "Progress: " + removedPercentage.ToString() + "%";
                    removesElementsCount++;
                    this._pingPerformers[index].Stop();
                    this._pingPerformers.RemoveAt(index);
                    this._logForms[index].Close();                                
                    this._logForms.RemoveAt(index);
                    this._statisticsForms[index].Close();
                    this._statisticsForms.RemoveAt(index);
                    this.listView.Items.RemoveAt(index);
                }
                GC.Collect();

                this.txtDestinationAddress.Text = "";
                this.txtDestinationName.Text = "";

                this.Text = originalText;
                this.Enabled = true;
            }
        }
        private void txtDestinationName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtDestinationAddress.Focus();
            }
        }
        private void txtDestinationAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnAdd_Click(this, EventArgs.Empty);                
            }
        }
        private void listView_ItemActivate(object sender, EventArgs e)
        {
            // Open the corresponding log form(s)
            for (int i = 0; i < this.listView.SelectedIndices.Count; i++)
            {
                int index = this.listView.SelectedIndices[i];
                this._logForms[index].Show();
                this._logForms[index].Focus();
                this._logForms[index].ShowForm = true;
            }
        }
        private void listView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            this._dragItemStarted = true;
            this._dragItem = (ListViewItem)e.Item;
        }
        private void listView_KeyDown(object sender, KeyEventArgs e)
        {
            // Implement "select-all" by pressing Ctrl-A:
            if (e.KeyCode == Keys.A && e.Control == true)
            {
                for (int i = 0; i < this.listView.Items.Count; i++)
                {
                    this.listView.SelectedIndices.Add(i);
                }
            }
            
            // Implement removing items by pressing "Delete" or "Backspace"
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                this.btnRemove_Click(this, EventArgs.Empty);
            }

            // Implement "Edit"
            if (e.KeyCode == Keys.F2)
            {
                this.menuResumePing_Edit_Click(this, EventArgs.Empty);
            }

            // Implement "Statistics"
            if (e.KeyCode == Keys.S && e.Control == true)
            {
                ShowStats();
            }
        }

        private void ShowStats()
        {
            this._statisticsForms[this.listView.SelectedIndices[0]].Show();
            this._statisticsForms[this.listView.SelectedIndices[0]].Focus();
        }
        private void listView_MouseMove(object sender, MouseEventArgs e)
        {
            if (this._dragItemStarted)
            {
                // Get the item we are dragging over right now
                ListViewItem x = this.listView.GetItemAt(e.Location.X, e.Location.Y);
                if (x != this._dragItem && x != null)
                    this.SwapItems(this.listView, this._dragItem, x);
            }
        }
        private void listView_MouseUp(object sender, MouseEventArgs e)
        {
            // Assign a context menu to the listview when mouse is right-clicked
            if (e.Button == MouseButtons.Right && this.listView.SelectedItems.Count > 0)
            {
                // Look at the first item selected
                PingPerformer p = this._pingPerformers[this.listView.SelectedIndices[0]];

                // If the item is a ping that was stopped, assign the menu that wil allow resuming
                if (p.Stopped)
                {
                    this.listView.ContextMenuStrip = this.menuResumePing;
                }
                else // If the item is a ping that is running, assign the menu that will allow stopping it
                {
                    this.listView.ContextMenuStrip = this.menuStopPing;
                }
            }
            // Mouse-up will also indicate that any drag operation has ended
            this._dragItemStarted = false;
        }                
        private void numericFontSize_ValueChanged(object sender, EventArgs e)
        {
            // Change font size
            Font f = this.listView.Font;
            int size = (int)this.numericFontSize.Value;
            this.listView.Font = new Font(f.FontFamily, size, f.Style);
        }
        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            // Calculate how many successfull pings are there
            int successfullPings = 0;
            foreach (PingPerformer pinger in this._pingPerformers)
            {
                if (pinger.PingState == State.Success || pinger.PingState == State.Transient)
                    successfullPings++;
            }

            // Set the title accordingly
            double ratio = 0.5;
            if (this._pingPerformers.Count > 0)
            {
                this.Text = string.Format("{0} {1}/{2}", this._originalCaption, successfullPings, this._pingPerformers.Count);
                ratio = (double)(successfullPings) / (double)(this._pingPerformers.Count);
            }
            else
                this.Text = this._originalCaption;

            // Set the icons accordingly
            if (ratio >= 0.7)
                this.SetFormsIcons(IconImageID.GreenGreen);
            else if (ratio >= 0.3)
                this.SetFormsIcons(IconImageID.GreenRed);
            else
                this.SetFormsIcons(IconImageID.RedRed);
        }

        #endregion

        #region Menu click events handlers
        
        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            this.saveFileDialog.ShowDialog();
        }
        private void menuSave_Click(object sender, EventArgs e)
        {
            // Save items list to the selected file
            var filename = (string)this.txtFileName.Tag;
            this.SaveToFile(filename);
        }
        private void menuOpen_Click(object sender, EventArgs e)
        {
            this.openFileDialog.ShowDialog();
        }
        private void menuSettings_Click(object sender, EventArgs e)
        {
            this._settingsForm.SetSettings(this._ttl, this._bufferSize, this._dontFragment,
                this._timeout, this._pingInterval, this._stabilityCount, this._capacity);
            this._settingsForm.Show();
            this._settingsForm.Focus();
        }
        private void menuAutoInsert_Click(object sender, EventArgs e)
        {
            this._autoInsertForm.Show();
            this._autoInsertForm.Focus();
        }
        private void menuAbout_Click(object sender, EventArgs e)
        {
            this._aboutForm.Show();
            this._aboutForm.Focus();
        }

        private void menuResumePing_Start_Click(object sender, EventArgs e)
        {
            foreach (int index in this.listView.SelectedIndices)
            {
                if (this._pingPerformers[index].Stopped)
                {
                    this._pingPerformers[index].Start();
                }
            }
            this.listView.SelectedItems.Clear();
        }
        private void menuResumePing_Edit_Click(object sender, EventArgs e)
        {            
            List<PingPerformer> pingersToEdit = new List<PingPerformer>();

            foreach (int index in this.listView.SelectedIndices)
                pingersToEdit.Add(this._pingPerformers[index]);

            this._editItemForm.EditItems(pingersToEdit);
        }
        private void menuResumePing_Remove_Click(object sender, EventArgs e)
        {
            this.btnRemove_Click(this, EventArgs.Empty);
        }
        
        private void menuStopPing_Stop_Click(object sender, EventArgs e)
        {
            foreach (int index in this.listView.SelectedIndices)
            {
                if (!this._pingPerformers[index].Stopped)
                {
                    this._pingPerformers[index].InitiateStop();
                    this.listView.Items[index].BackColor = Color.FromKnownColor(KnownColor.Window);
                    this.listView.Items[index].ImageIndex = (int)StateImageID.Stopped;
                }
            }
            this.listView.SelectedItems.Clear();
        }
        private void menuStopPing_Edit_Click(object sender, EventArgs e)
        {
            this.menuResumePing_Edit_Click(this, EventArgs.Empty);            
        }        
        private void menuStopPing_Remove_Click(object sender, EventArgs e)
        {
            this.btnRemove_Click(this, EventArgs.Empty);
        }
        private void menuStopPing_Stats_Click(object sender, EventArgs e)
        {
            ShowStats();
        }
        private void menuStopPing_Rapid_Click(object sender, EventArgs e)
        {
            PingPerformer pinger = null;
            foreach (int index in this.listView.SelectedIndices) {
                pinger = this._pingPerformers[index];
                break;
            }
            if (pinger == null) return;

            this._rapidForm.SetDestination(pinger.DestinationAddress);
            this._rapidForm.Show();
            this._rapidForm.Focus();
        }
        #endregion

        #region Events handlers for events raised from within the PingPerformers objects
        
        private void pingers_ReplyRecieved(PingPerformer sender, PingPerformerEventArgs e)
        {
            try
            {
                // find index of ping object
                int index = -1;
                for (int i = 0; i < this._pingPerformers.Count; i++)
                {
                    if (this._pingPerformers[i] == sender)
                    {
                        index = i;
                        break;
                    }
                }
                if (index < 0)
                    return;
                
                this._logForms[index].AddMessage(e.Message);
                this._statisticsForms[index].SetStatistics(sender, e.Reply != null? (long?)e.Reply.RoundtripTime: null);
                
            }
            catch
            {
            }
        }
        private void pingers_StateChanged(PingPerformer sender, PingPerformerEventArgs e)
        {
            try
            {
                // find index
                int index = -1;
                for (int i = 0; i < this._pingPerformers.Count; i++)
                {
                    if (this._pingPerformers[i] == sender)
                    {
                        index = i;
                        break;
                    }
                }
                if (index < 0)
                    return;

                if (this.listView.InvokeRequired)
                {
                    ReplyRecievedHandler eh = new ReplyRecievedHandler(this.pingers_StateChanged);
                    this.Invoke(eh, new object[] { sender, e });
                }
                else
                {
                    if (sender.IsStopping)
                        return;

                    if (e.State == State.Success)
                    {                        
                        this.listView.Items[index].BackColor = Color.Lime;
                        this.listView.Items[index].ImageIndex = (int)StateImageID.Success;
                    }
                    else if (e.State == State.Failure)
                    {                        
                        this.listView.Items[index].BackColor = Color.Red;
                        this.listView.Items[index].ImageIndex = (int)StateImageID.Failure;
                    }
                    else if (e.State == State.Transient)
                    {                        
                        this.listView.Items[index].BackColor = Color.Yellow;
                        this.listView.Items[index].ImageIndex = (int)StateImageID.Success;
                    }
                    else
                    {
                        this.listView.Items[index].BackColor = Color.FromKnownColor(KnownColor.Window);
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        
        #endregion

        #region OKClicked event handlers
        private void settingsForm_OKClicked(object sender, EventArgs e)
        {
            this._ttl = this._settingsForm.TTL;
            this._bufferSize = this._settingsForm.BufferSize;
            this._dontFragment = this._settingsForm.DontFragment;
            this._timeout = this._settingsForm.Timeout;
            this._pingInterval = this._settingsForm.PingInterval;
            this._stabilityCount = this._settingsForm.StabilityCount;            
            this._capacity = this._settingsForm.Capacity;            
            // Set the loggers capacity
            foreach (FrmPingLog form in this._logForms)
            {
                form.Capacity = this._capacity;
            }

            // Set the pingers
            foreach (PingPerformer pinger in this._pingPerformers)
            {
                pinger.ChangeSettings(this._stabilityCount, this._ttl,
                    this._bufferSize, this._dontFragment, this._timeout, this._pingInterval);
            }
        }
        private void editItemForm_OKClicked(object sender, EventArgs e)
        {
            // find indeces of ping objects
            List<int> indeces = new List<int>();
            List<PingPerformer> editedPingers = (List<PingPerformer>)sender;

            foreach (PingPerformer pinger in editedPingers)
            {
                // Find that pinger in the pingers list
                for (int i = 0; i < this._pingPerformers.Count; i++)
                {
                    if (this._pingPerformers[i] == pinger)
                    {
                        indeces.Add(i);
                        break;
                    }
                }
            }

            // Change list-view item text
            foreach (int index in indeces)
            {
                this.listView.Items[index].SubItems[0].Text = this._pingPerformers[index].DestinationName;
                this.listView.Items[index].SubItems[1].Text = this._pingPerformers[index].DestinationAddress;

                // Change title of corresponding history-window
                this._logForms[index].Text = this._pingPerformers[index].DestinationName + " " +
                    this._pingPerformers[index].DestinationAddress;

                // Change title of corresponding statistics-window
                this._statisticsForms[index].Text = this._pingPerformers[index].DestinationName + " " +
                    this._pingPerformers[index].DestinationAddress;
            }
        }
        #endregion

        #region Auto Insert OKClicked event handler
        public void autoInsertForm_OKClicked(object sender, EventArgs e)
        {
            long totalElements = this._autoInsertForm.TotalElements;
            int addedElementsCount = 0;
            double addedPercentage = 0;
            string originalText = this.Text;

            try
            {
                this.Enabled = false;

                string expression = this._autoInsertForm.Expression;
                object[] iterators = this._autoInsertForm.GetFirstIterators();

                string address = string.Format(expression, iterators);
                this.AddNewPinger("Auto", address);
                
                while (!this._autoInsertForm.IsLast(iterators))
                {
                    this._autoInsertForm.GetNextIterators(ref iterators);
                    address = string.Format(expression, iterators);
                    this.AddNewPinger("Auto", address);

                    addedPercentage = (int)((double)addedElementsCount / (double)totalElements * 100);
                    this.Text = "Progress: " + addedPercentage.ToString() + "%";
                    addedElementsCount++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + 
                    "Finished: " + ((int)addedPercentage).ToString() + "%", 
                    "Error adding new items", MessageBoxButtons.OK, MessageBoxIcon.Stop );
            }
            finally
            {
                this.Text = originalText;
                this.Enabled = true;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Converts an image into an icon.
        /// </summary>
        /// <param name="img">The image that shall become an icon</param>
        /// <param name="size">The width and height of the icon. Standard
        /// sizes are 16x16, 32x32, 48x48, 64x64.</param>
        /// <param name="keepAspectRatio">Whether the image should be squashed into a
        /// square or whether whitespace should be put around it.</param>
        /// <returns>An icon!!</returns>
        private Icon MakeIcon(Image img, int size, bool keepAspectRatio)
        {
            Bitmap square = new Bitmap(size, size); // create new bitmap
            Graphics g = Graphics.FromImage(square); // allow drawing to it

            int x, y, w, h; // dimensions for new image

            if (!keepAspectRatio || img.Height == img.Width)
            {
                // just fill the square
                x = y = 0; // set x and y to 0
                w = h = size; // set width and height to size
            }
            else
            {
                // work out the aspect ratio
                float r = (float)img.Width / (float)img.Height;

                // set dimensions accordingly to fit inside size^2 square
                if (r > 1)
                { // w is bigger, so divide h by r
                    w = size;
                    h = (int)((float)size / r);
                    x = 0; y = (size - h) / 2; // center the image
                }
                else
                { // h is bigger, so multiply w by r
                    w = (int)((float)size * r);
                    h = size;
                    y = 0; x = (size - w) / 2; // center the image
                }
            }

            // make the image shrink nicely by using HighQualityBicubic mode
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(img, x, y, w, h); // draw image with specified dimensions
            g.Flush(); // make sure all drawing operations complete before we get the icon

            // following line would work directly on any image, but then
            // it wouldn't look as nice.
            return Icon.FromHandle(square.GetHicon());
        }

        private void SetFormsIcons(IconImageID imageID)
        {
            try
            {
                int iconIndex = (int)imageID;

                this.Icon = this._formsIcons[iconIndex];
                this._aboutForm.Icon = this._formsIcons[iconIndex];
                this._settingsForm.Icon = this._formsIcons[iconIndex];
                this._autoInsertForm.Icon = this._formsIcons[iconIndex];
                this._editItemForm.Icon = this._formsIcons[iconIndex];
                this._rapidForm.Icon = this._formsIcons[iconIndex];
                foreach (FrmPingLog log in this._logForms)
                    log.Icon = this._formsIcons[iconIndex];
                foreach (FrmStatistics stat in this._statisticsForms)
                    stat.Icon = this._formsIcons[iconIndex];
            }
            catch { }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="destinationName"></param>
        /// <param name="destinationAddress"></param>
        private void AddNewPinger(string destinationName, string destinationAddress)
        {
            // Allow only non empty addresses. Ignore even addresses that looks empty (e.g: "     ")
            if (destinationAddress.Replace(" ", "") != "")
            {
                // Create ping object
                PingPerformer pinger = new PingPerformer(destinationName, destinationAddress,
                    this._stabilityCount, this._ttl, this._bufferSize, this._dontFragment, 
                    this._timeout, this._pingInterval);
                pinger.ReplyRecieved += new ReplyRecievedHandler(this.pingers_ReplyRecieved);
                pinger.StateChanged += new StateChangeHandler(this.pingers_StateChanged);
                this._pingPerformers.Add(pinger);

                // Add to list view
                ListViewItem item = new ListViewItem();                
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
                item.SubItems[0].Text = destinationName;
                item.SubItems[1].Text = destinationAddress;
                this.listView.Items.Add(item);

                // Create log form
                FrmPingLog log = new FrmPingLog();
                log.Text = destinationName + "  " + destinationAddress;
                log.Capacity = this._capacity;
                log.Icon = this._formsIcons[0];
                this._logForms.Add(log);

                // Create statistics form
                FrmStatistics stat = new FrmStatistics();
                stat.Text = destinationName + "  " + destinationAddress;                
                stat.Icon = this._formsIcons[0];
                this._statisticsForms.Add(stat);

                // Start to ping
                pinger.Start();

                // Clear text
                this.txtDestinationName.Text = "";
                this.txtDestinationAddress.Text = "";
            }
            this.txtDestinationAddress.Text = "";
        }
        private void SwapItems(ListView listView, ListViewItem a, ListViewItem b)
        {
            int indexToRemove = listView.Items.IndexOf(a);
            int indexToInsert = listView.Items.IndexOf(b);

            if (a != null && indexToInsert != -1)
            {
                listView.Items.Remove(a);
                listView.Items.Insert(indexToInsert, a);


                PingPerformer p = this._pingPerformers[indexToRemove];
                this._pingPerformers.RemoveAt(indexToRemove);
                this._pingPerformers.Insert(indexToInsert, p);

                FrmPingLog log = this._logForms[indexToRemove];
                this._logForms.RemoveAt(indexToRemove);
                this._logForms.Insert(indexToInsert, log);

                FrmStatistics stat = this._statisticsForms[indexToRemove];
                this._statisticsForms.RemoveAt(indexToRemove);
                this._statisticsForms.Insert(indexToInsert, stat);
            }
        }

        private void SaveToFile(string fileName)
        {
            this.SaveToFileVersion4(fileName);
        }   
        private void SaveToFileVersion1(string fileName)
        {
            string seperatorChar = "$";
            FileStream file = new FileStream(fileName, FileMode.Create);
            StreamWriter writer = new StreamWriter(file);

            // Save settings
            writer.WriteLine(this._ttl.ToString());
            writer.WriteLine(this._bufferSize.ToString());
            writer.WriteLine(this._dontFragment.ToString());
            writer.WriteLine(this._timeout.ToString());
            writer.WriteLine(this._pingInterval.ToString());
            writer.WriteLine(this._stabilityCount.ToString());
            writer.WriteLine(this._capacity.ToString());
            // Save list
            for (int i = 0; i < this._pingPerformers.Count; i++)
            {
                writer.WriteLine(
                    this._pingPerformers[i].DestinationName +
                    seperatorChar +
                    this._pingPerformers[i].DestinationAddress);
            }
            writer.Close();
            file.Close();
        }        
        private void SaveToFileVersion2(string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.Create);
            StreamWriter writer = new StreamWriter(file);

            // Write version
            writer.WriteLine("Version 2.0");
            // Save settings
            writer.WriteLine(this._ttl.ToString());
            writer.WriteLine(this._bufferSize.ToString());
            writer.WriteLine(this._dontFragment.ToString());
            writer.WriteLine(this._timeout.ToString());
            writer.WriteLine(this._pingInterval.ToString());
            writer.WriteLine(this._stabilityCount.ToString());
            writer.WriteLine(this._capacity.ToString());
            // Save list
            for (int i = 0; i < this._pingPerformers.Count; i++)
            {
                writer.WriteLine(this._pingPerformers[i].DestinationName);
                writer.WriteLine(this._pingPerformers[i].DestinationAddress);
            }
            writer.Close();
            file.Close();
        }
        private void SaveToFileVersion3(string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.Create);
            StreamWriter writer = new StreamWriter(file);

            // Write version
            writer.WriteLine("Version 3.0");
            // Save settings
            writer.WriteLine(this._ttl.ToString());
            writer.WriteLine(this._bufferSize.ToString());
            writer.WriteLine(this._dontFragment.ToString());
            writer.WriteLine(this._timeout.ToString());
            writer.WriteLine(this._pingInterval.ToString());
            writer.WriteLine(this._stabilityCount.ToString());
            writer.WriteLine(this._capacity.ToString());
            // Save GUI settings
            writer.WriteLine(this.listView.Columns[0].Width);
            writer.WriteLine(this.listView.Columns[1].Width);
            writer.WriteLine(this.Height);
            writer.WriteLine(this.Width);
            writer.WriteLine(this.Left);
            writer.WriteLine(this.Top);
            // Save list
            for (int i = 0; i < this._pingPerformers.Count; i++)
            {
                writer.WriteLine(this._pingPerformers[i].DestinationName);
                writer.WriteLine(this._pingPerformers[i].DestinationAddress);
            }
            writer.Close();
            file.Close();
        }
        private void SaveToFileVersion4(string fileName)
        {
            string seperatorString = " <==> ";
            string userString = seperatorString + "*";
            string systemString = seperatorString + "!";
            FileStream file = new FileStream(fileName, FileMode.Create);
            StreamWriter writer = new StreamWriter(file);

            // Write version
            writer.WriteLine("Version 4.0");
            // Write control strings
            writer.WriteLine(seperatorString);
            writer.WriteLine(userString);
            writer.WriteLine(systemString);
            // Save settings
            writer.WriteLine(this._ttl.ToString());
            writer.WriteLine(this._bufferSize.ToString());
            writer.WriteLine(this._dontFragment.ToString());
            writer.WriteLine(this._timeout.ToString());
            writer.WriteLine(this._pingInterval.ToString());
            writer.WriteLine(this._stabilityCount.ToString());
            writer.WriteLine(this._capacity.ToString());
            // Save list
            for (int i = 0; i < this._pingPerformers.Count; i++)
            {
                // If the user enterd the seperator string, replace it with the userString
                string name = this._pingPerformers[i].DestinationName.Replace(seperatorString, userString);
                string address = this._pingPerformers[i].DestinationAddress.Replace(seperatorString, seperatorString + userString);                
                writer.WriteLine(name + systemString + address);
            }
            writer.Close();
            file.Close();
        }        

        private void ReadFromFile(string fileName)
        {
            try
            {
                // Read first line to determain which format it is (version 1, 2, etc.)
                FileStream file = new FileStream(fileName, FileMode.Open);
                StreamReader reader = new StreamReader(file);
                string line = reader.ReadLine();
                reader.Close();
                file.Close();

                if (line == "Version 3.0")
                    this.ReadFromFileVersion3(fileName);
                else if (line == "Version 2.0")
                    this.ReadFromFileVersion2(fileName);
                else if (line == "Version 4.0")
                    this.ReadFromFileVersion4(fileName);
                else
                    this.ReadFromFileVersion1(fileName);
            }
            catch { }
        }
        private void ReadFromFileVersion1(string fileName)
        {
            string seperatorChar = "$";

            // Open the file
            FileStream file;
            try { file = new FileStream(fileName, FileMode.Open); }
            catch { return; }

            // Open reader
            StreamReader reader;
            try { reader = new StreamReader(file); }
            catch
            {
                file.Close();
                return;
            }

            try
            {
                // Read settings
                this._ttl = int.Parse(reader.ReadLine());
                this._bufferSize = int.Parse(reader.ReadLine());
                this._dontFragment = bool.Parse(reader.ReadLine());
                this._timeout = int.Parse(reader.ReadLine());
                this._pingInterval = int.Parse(reader.ReadLine());
                this._stabilityCount = int.Parse(reader.ReadLine());
                this._capacity = int.Parse(reader.ReadLine());
                // Read list
                string line, name, address;
                int seperatorIndex;
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    seperatorIndex = line.IndexOf(seperatorChar);

                    name = line.Substring(0, seperatorIndex);
                    address = line.Substring(seperatorIndex + seperatorChar.Length);
                    this.AddNewPinger(name, address);
                }
            }
            catch { }

            reader.Close();
            file.Close();
        }
        private void ReadFromFileVersion2(string fileName)
        {
            // Open the file
            FileStream file;
            try { file = new FileStream(fileName, FileMode.Open); }
            catch { return; }

            // Open reader
            StreamReader reader;
            try { reader = new StreamReader(file); }
            catch 
            {
                file.Close();
                return; 
            }

            try
            {
                // Read version line
                reader.ReadLine();
                // Read settings
                this._ttl = int.Parse(reader.ReadLine());
                this._bufferSize = int.Parse(reader.ReadLine());
                this._dontFragment = bool.Parse(reader.ReadLine());
                this._timeout = int.Parse(reader.ReadLine());
                this._pingInterval = int.Parse(reader.ReadLine());
                this._stabilityCount = int.Parse(reader.ReadLine());
                this._capacity = int.Parse(reader.ReadLine());
                // Read list
                string name, address;
                while (!reader.EndOfStream)
                {
                    name = reader.ReadLine();
                    address = reader.ReadLine();

                    this.AddNewPinger(name, address);
                }
            }
            catch {}
            
            reader.Close();
            file.Close();
        }
        private void ReadFromFileVersion3(string fileName)
        {
            // Open the file
            FileStream file;
            try { file = new FileStream(fileName, FileMode.Open); }
            catch { return; }

            // Open reader
            StreamReader reader;
            try { reader = new StreamReader(file); }
            catch
            {
                file.Close();
                return;
            }

            try
            {
                // Read version line
                reader.ReadLine();
                // Read settings
                this._ttl = int.Parse(reader.ReadLine());
                this._bufferSize = int.Parse(reader.ReadLine());
                this._dontFragment = bool.Parse(reader.ReadLine());
                this._timeout = int.Parse(reader.ReadLine());
                this._pingInterval = int.Parse(reader.ReadLine());
                this._stabilityCount = int.Parse(reader.ReadLine());
                this._capacity = int.Parse(reader.ReadLine());
                // Save GUI settings
                this.listView.Columns[0].Width = int.Parse(reader.ReadLine());
                this.listView.Columns[1].Width = int.Parse(reader.ReadLine());
                this.Height = int.Parse(reader.ReadLine());
                this.Width = int.Parse(reader.ReadLine());
                this.Left = int.Parse(reader.ReadLine());
                this.Top = int.Parse(reader.ReadLine());
                // Read list
                string name, address;
                while (!reader.EndOfStream)
                {
                    name = reader.ReadLine();
                    address = reader.ReadLine();

                    this.AddNewPinger(name, address);
                }
            }
            catch { }
            
            reader.Close();
            file.Close();
        }
        private void ReadFromFileVersion4(string fileName)
        {
            // Open the file
            FileStream file;
            try { file = new FileStream(fileName, FileMode.Open); }
            catch { return; }

            // Open reader
            StreamReader reader;
            try { reader = new StreamReader(file); }
            catch
            {
                file.Close();
                return;
            }

            try
            {
                // Read version line
                reader.ReadLine();
                // Read control strings
                string seperatorString = reader.ReadLine();
                string userString = reader.ReadLine();
                string systemString = reader.ReadLine();                
                // Read settings
                this._ttl = int.Parse(reader.ReadLine());
                this._bufferSize = int.Parse(reader.ReadLine());
                this._dontFragment = bool.Parse(reader.ReadLine());
                this._timeout = int.Parse(reader.ReadLine());
                this._pingInterval = int.Parse(reader.ReadLine());
                this._stabilityCount = int.Parse(reader.ReadLine());
                this._capacity = int.Parse(reader.ReadLine());
                // Read list
                string line, name, address;
                int seperatorIndex;
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    // Find the sepeator location
                    seperatorIndex = 0;
                    /*while (true)
                    {
                        seperatorIndex = line.IndexOf(seperatorString, seperatorIndex);
                        if (seperatorIndex < 0) // Not found
                            break;
                        string textAfterSeperator = line.Substring(seperatorIndex + seperatorString.Length);
                        if (textAfterSeperator.StartsWith(uniqueString))
                            seperatorIndex++;
                        else
                            break;
                    }*/
                    seperatorIndex = line.IndexOf(systemString);

                    name = line.Substring(0, seperatorIndex).Replace(userString, seperatorString);
                    address = line.Substring(seperatorIndex + systemString.Length).Replace(userString, seperatorString);
                    this.AddNewPinger(name, address);
                }
            }
            catch { }

            reader.Close();
            file.Close();
        }


        private void UpdateLoadedFile(string fileName)
        {
            this.txtFileName.Tag = fileName;
            var file = new FileInfo(fileName);
            this.txtFileName.Text = Path.Combine(file.Directory.Name, file.Name);
            this.txtFileName.SelectionStart = this.txtFileName.Text.Length - 1;
            this.menuSave.Enabled = true;
        }
        #endregion
    }
}
