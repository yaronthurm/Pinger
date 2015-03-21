﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PingTester {
    public partial class FrmRapid : Form {
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
                this.label1.Text = "Success: " + e.TotalSuccess + "  Fail: " + e.TotalFail;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string host = this.txtDestination.Text;
            int usersCount = (int)this.numericUsersCount.Value;
            int durationInSec = (int)this.numericDuration.Value;
            var rapid = new RapidPinger(host, usersCount, TimeSpan.FromSeconds(durationInSec), 10);
            rapid.ReplyRecieved += rapid_ReplyRecieved;
            rapid.Start();
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
    }
}