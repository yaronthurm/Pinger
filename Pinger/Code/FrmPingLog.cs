using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PingTester
{
    public partial class FrmPingLog : Form
    {
        private int _capacity;
        private bool _showForm;        
        private List<string> _messages;


        
        public FrmPingLog()
        {
            InitializeComponent();
            this._capacity = 0;
            this._messages = new List<string>();
        }        

        public int Capacity
        {
            get { return this._capacity; }
            set { this._capacity = value; }
        }

        public bool ShowForm
        {
            get { return this._showForm; }
            set {this._showForm = value;}
        }

        delegate void AddMessageHandler(string msg);
        
        public void AddMessage(string msg)
        {
            lock (this)
            {
                this._messages.Add(msg);                
            }                        
        }        

        private void frmPingLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                this._showForm = false;
            }
        }
        
        private void timerUpdateLog_Tick(object sender, EventArgs e)
        {
            lock (this)
            {
                if (this._messages.Count == 0)
                    return;
            }

            // Suspend drawing
            this.listBox.BeginUpdate();

            // Save the current top-index
            int topIndex = this.listBox.TopIndex;

            // Add the new items
            lock (this)
            {
                for (int i = 0; i < this._messages.Count; i++)
                    this.listBox.Items.Add(this._messages[i]);

                this._messages.Clear();
            }
            
            // Remove the first items to comply with the capacity allowed
            int removedItemsCount = 0;
            while (this.listBox.Items.Count >= this._capacity)
            {
                this.listBox.Items.RemoveAt(0);
                removedItemsCount++;
            }
           
            // If "auto-scroll" is enabled, set the top index so the last item is shown
            if (this.checkAutoScroll.Checked)
            {
                // Calculate the top-index for the "auto-scroll" mode
                int itemsPerPage = (int)(this.listBox.Height / this.listBox.ItemHeight);
                this.listBox.TopIndex = this.listBox.Items.Count - itemsPerPage;

                // End updating
                this.listBox.EndUpdate();
            }
            else // "auto-scroll" is disabled
            {
                // Set the top item back to what it was by decreasing the top index
                if (topIndex >= removedItemsCount)
                    topIndex -= removedItemsCount;
                this.listBox.TopIndex = topIndex;

                // End updating
                this.listBox.EndUpdate();
            }
        }                              
    }
}
