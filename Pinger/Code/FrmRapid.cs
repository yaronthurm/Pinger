using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PingTester {
    public partial class FrmRapid : Form {
        private RapidPinger _rapidPinger;
        private int _countDown;

        public FrmRapid()
        {
            InitializeComponent();
        }

        private void rapid_ReplyRecieved(RapidPinger sender, RapidPingerEventArgs e)
        {
            if (this.InvokeRequired) {
                RapidPingerReplyRecievedHandler eh = new RapidPingerReplyRecievedHandler(this.rapid_ReplyRecieved);
                this.Invoke(eh, new object[] { sender, e });
            }
            else {
                this.lblStatus.Text = "Count down: " +_countDown + "   Success: " + e.TotalSuccess + "   Fail: " + e.TotalFail;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string host = this.txtDestination.Text;
            int usersCount = (int)this.numericUsersCount.Value;
            _countDown = (int)this.numericDuration.Value;
            _rapidPinger = new RapidPinger(host, usersCount, 10);
            _rapidPinger.ReplyRecieved += rapid_ReplyRecieved;
            _rapidPinger.Start();

            this.btnStart.Enabled = false;
            this.btnStop.Enabled = true;
            this.timer1.Enabled = true;
            this.txtMessages.Text = "";
            this.txtMessages.Visible = false;
        }

        public void SetDestination(string destination)
        {
            this.txtDestination.Text = destination;
        }

        private void FrmRapid_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;

            _rapidPinger.Stop();

            this.btnStart.Enabled = true;
            this.btnStop.Enabled = false;
            if (_rapidPinger.FailureMessages.Count > 0) {
                this.txtMessages.Text = string.Join("\r\n", _rapidPinger.FailureMessages);
                this.txtMessages.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_countDown == 0)
                btnStop_Click(null, null);
            else
                _countDown--;
        }
    }
}