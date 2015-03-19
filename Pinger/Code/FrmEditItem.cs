using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PingTester
{
    public partial class FrmEditItem : Form
    {
        private List<PingPerformer> _pingers;
        public event EventHandler OKClicked;

        public FrmEditItem()
        {
            InitializeComponent();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmEditItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
        
        public void EditItems(List<PingPerformer> pingers)
        {
            if (pingers == null || pingers.Count == 0)
                return;

            this._pingers = pingers;
 
            this.lblEditMultipleItems.Visible = pingers.Count > 1;
            this.checkName.Visible = pingers.Count > 1;
            this.checkAddress.Visible = pingers.Count > 1;
            
            this.checkAddress.Checked = pingers.Count == 1;
            this.checkName.Checked = true;
            
            this.txtDestinationAddress.Text = pingers[0].DestinationAddress;
            this.txtDestinationAddress.Enabled = this.checkAddress.Checked;

            this.txtDestinationName.Text = pingers[0].DestinationName;
            this.txtDestinationName.Enabled = this.checkName.Checked;
            
            this.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtDestinationAddress.Text == "")
                return;

            foreach (PingPerformer pinger in this._pingers)
            {
                if (this.checkAddress.Checked && pinger.DestinationAddress != this.txtDestinationAddress.Text)
                    pinger.DestinationAddress = this.txtDestinationAddress.Text;

                if (this.checkName.Checked && pinger.DestinationName != this.txtDestinationName.Text)
                    pinger.DestinationName = this.txtDestinationName.Text;
            }

            if (this.OKClicked != null)
                this.OKClicked(this._pingers, EventArgs.Empty);

            this.Hide();
        }

        private void txtDestinationName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.btnOK_Click(this, EventArgs.Empty);
        }

        private void txtDestinationAddress_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.btnOK_Click(this, EventArgs.Empty);
        }

        private void checkName_CheckedChanged(object sender, EventArgs e)
        {
            this.txtDestinationName.Enabled = this.checkName.Checked;
        }

        private void checkAddress_CheckedChanged(object sender, EventArgs e)
        {
            this.txtDestinationAddress.Enabled = this.checkAddress.Checked;
        }
    }
}
