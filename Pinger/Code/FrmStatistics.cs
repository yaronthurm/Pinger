using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PingTester
{
    public partial class FrmStatistics : Form
    {
        private enum StateImageID { Success = 2, Failure = 1, Stopped = 0 };

        private ulong _currentStateCounter = 0;
        private PingPerformer _pinger;
        private PingTester.State _currentState;
        private List<long> _roundTrips = new List<long>();


        public FrmStatistics()
        {
            InitializeComponent();

            this._currentState = State.Unknown;
        }

        delegate void SetStatisticsHandler(PingPerformer pinger, long? roundTrip);
        public void SetStatistics(PingPerformer pinger, long? roundTrip)
        {
            if (this.InvokeRequired)
            {
                SetStatisticsHandler del = new SetStatisticsHandler(this.SetStatistics);
                this.Invoke(del, new object[] { pinger, roundTrip });
            }
            else
            {
                this._pinger = pinger;
                this.lblFailed.Text = pinger.FaildPingsCount.ToString();
                this.lblSuccessed.Text = pinger.SuccessfullPingsCount.ToString();

                if (pinger.FaildPingsCount + pinger.SuccessfullPingsCount > 0)
                {
                    decimal percent = (decimal)(pinger.SuccessfullPingsCount) /
                        (decimal)(pinger.FaildPingsCount + pinger.SuccessfullPingsCount) * 100;
                    this.lblPercent.Text = percent.ToString("F2") + "%";
                }

                PingTester.State pingerState = pinger.PingState;
                // Treat transiet as success
                if (pingerState == State.Transient)
                    pingerState = State.Success;

                // Check if state has changed
                if (this._currentState != pingerState)
                    this.SetNewState(pingerState);
                else
                    this._currentStateCounter++;

                if (roundTrip != null)
                    _roundTrips.Add(roundTrip.Value);
            }
        }
        
        private void SetNewState(PingTester.State newState)
        {            
            {
                // Treat transiet as success
                if (newState == State.Transient || newState == State.Success)
                    newState = State.Success;

                // Check if really changed
                if (this._currentState == newState)
                    return;

                // Save new state
                this._currentState = newState;

                // Set value of last state
                int lastIndex = this.listView.Items.Count - 1;
                if (lastIndex >= 0)
                    this.listView.Items[lastIndex].SubItems[1].Text = this._currentStateCounter.ToString();
                
                // Set new item
                ListViewItem item = new ListViewItem();

                item.Text = System.DateTime.Now.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem());

                this._currentStateCounter = 1;
                item.SubItems[1].Text = this._currentStateCounter.ToString();

                if (newState == State.Success)
                {
                    item.BackColor = System.Drawing.Color.Lime;
                    item.ImageIndex = (int)StateImageID.Success;
                }
                else if (newState == State.Failure)
                {
                    item.BackColor = System.Drawing.Color.Red;
                    item.ImageIndex = (int)StateImageID.Failure;
                }

                this.listView.BeginUpdate();
                this.listView.Items.Add(item);
                item.EnsureVisible();
                this.listView.EndUpdate();
            }
        }

        private void frmStatistics_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();                
            }
        }

        private void btnResetStatistics_Click(object sender, EventArgs e)
        {
            this.lblSuccessed.Text = "0";
            this.lblFailed.Text = "0";
            this.lblPercent.Text = "N/A";

            this._currentStateCounter = 0;
            this._pinger.ResetStatistics();            
            
            this.listView.Items.Clear();
            this._currentState = State.Unknown;
            this.SetNewState(this._pinger.PingState);
        }

        private void timerUpdateView_Tick(object sender, EventArgs e)
        {
            // Set value of last state
            int lastIndex = this.listView.Items.Count - 1;
            if (lastIndex >= 0)
                this.listView.Items[lastIndex].SubItems[1].Text = this._currentStateCounter.ToString();

        }
    }
}
