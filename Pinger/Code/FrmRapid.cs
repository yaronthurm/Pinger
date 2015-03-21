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
        public FrmRapid()
        {
            InitializeComponent();
        }

        private void FrmRapid_Load(object sender, EventArgs e)
        {
            var rapid = new RapidPinger("127.0.0.1", 1, TimeSpan.FromSeconds(5), 10);
            rapid.ReplyRecieved += rapid_ReplyRecieved;
            rapid.Start();
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
    }
}