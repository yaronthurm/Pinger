using System;
using System.Windows.Forms;

namespace PingTester
{
    public partial class FrmSettings : Form
    {
        public event EventHandler OKClicked;

        public FrmSettings()
        {
            InitializeComponent();

            this.numericTTL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numeric_KeyDown);
            this.numericBufferSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numeric_KeyDown);
            this.numericTimeout.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numeric_KeyDown);
            this.numericPingInterval.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numeric_KeyDown);
            this.numericMsgCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numeric_KeyDown);
            this.numericHistoryCapacity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numeric_KeyDown);
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SetNumeric(NumericUpDown numeric, int value)
        {
            if (value > numeric.Maximum)
                value = (int)numeric.Maximum;
            if (value < numeric.Minimum)
                value = (int)numeric.Minimum;

            /* Bug fix (from 24.04.2009, by Yaron Thurm):
             * When the user deletes the value in a numeric-box and exits the form (either
             * by closing it or pressing Cancel/Ok), the form is not actually closed, it
             * is hidden. The next time the user opens the form, the form re-shows itself,
             * but the numeric-box that was previously cleared, is still empty and doesn't show its value.
             * The only way I was able to force the numeric-box to show its value again is
             * by changing it, and then assiging back the real value.
             * So, the next lines of code is doing the changing,
             * and the line after it is doing the assignment.             
             * 
             * Already tried the following aproaches and failed:
             * numeric.BringToFront(), numeric.Focus(), numeric.Hide() and then numeric.Show(), 
             * numeric.Invalidate(), numeric.PerformLayout(), numeric.Refresh(), numeric.ResetText(),
             * numeric.ResumeLayout(), numeric.Select(), numeric.Update(), numeric.Validate();            
             */

            // We need to change the current value so we need to find a new value that will always be
            // a valid one. We don't want an exception if we tried to change to a value
            // out of range (greater than the maximum value or less than the minimum value). 
            // So, we temporarlly increase the valid range by increasing the maximum value by one.
            // Then we change the current value to be the new maximum, and we know it is 100% safe and 
            // that it is really a change.
            // Then, we restore the maximum value, and we can then assign the value we actually want.
            numeric.Maximum++;
            numeric.Value = numeric.Maximum;
            numeric.Maximum--;

            numeric.Value = value;
        }
        
        public void SetSettings(int ttl, int bufferSize, bool dontFragment, int timeout,
            int pingInterval, int lastMsgCount, int capacity)
        {
            this.SetNumeric(this.numericTTL, ttl);
            this.SetNumeric(this.numericBufferSize, bufferSize);
            this.SetNumeric(this.numericTimeout, timeout);
            this.SetNumeric(this.numericPingInterval, pingInterval);
            this.SetNumeric(this.numericMsgCount, lastMsgCount);
            this.SetNumeric(this.numericHistoryCapacity, capacity);

            this.checkBoxDontFragment.Checked = dontFragment;
        }        

        public int TTL
        {
            get { return (int)this.numericTTL.Value; }
        }

        public int BufferSize
        {
            get { return (int)this.numericBufferSize.Value; }
        }

        public bool DontFragment
        {
            get { return this.checkBoxDontFragment.Checked; }
        }

        public int Timeout
        {
            get { return (int)this.numericTimeout.Value; }
        }

        public int PingInterval
        {
            get { return (int)this.numericPingInterval.Value; }
        }

        public int StabilityCount
        {
            get { return (int)this.numericMsgCount.Value; }
        }

        public int Capacity
        {
            get { return (int)this.numericHistoryCapacity.Value; }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.OKClicked != null)
                this.OKClicked.BeginInvoke(this, EventArgs.Empty, null, null);

            this.Hide();
        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void numeric_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.btnOK_Click(this, EventArgs.Empty);
        }        
    }
}
