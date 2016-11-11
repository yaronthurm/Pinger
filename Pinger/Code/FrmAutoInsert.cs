using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace PingTester
{
    public partial class FrmAutoInsert : Form
    {
        public event EventHandler OKClicked;

        #region Members
        private NumericUpDown[] _numericCustomMaxs;
        private NumericUpDown[] _numericCustomMins;
        private Label[] _lblCustomArgumentsTitles;
        private int _numberOfFormats = 0;
        private int _previousNumberOfFormats;
        private bool _isFormatStringOK = false;

        private NumericUpDown[] _numericIPStarts;
        private NumericUpDown[] _numericIPEnds;
        
        private int[] _absoluteMinimums;
        private int[] _absoluteMaximums;
        private int[] _startValues;
        private int[] _endValues;

        private long _totalElements;
        private string _expression = "";
        #endregion


        #region Constructor
        public FrmAutoInsert()
        {
            InitializeComponent();

            this._numericIPStarts = new NumericUpDown[] {
                this.numericStart0, this.numericStart1, this.numericStart2, this.numericStart3};
            this._numericIPEnds = new NumericUpDown[] {
                this.numericEnd0, this.numericEnd1, this.numericEnd2, this.numericEnd3};

            foreach (NumericUpDown numeric in this._numericIPStarts)
            {
                numeric.ValueChanged += new EventHandler(this.numericIPStarts_ValueChanged);
                numeric.Click += new EventHandler(this.numeric_Click);
                numeric.Enter += new EventHandler(this.numeric_Enter);
                numeric.KeyDown += new KeyEventHandler(this.numericIPStarts_KeyDown);
            }
            foreach (NumericUpDown numeric in this._numericIPEnds)
            {
                numeric.ValueChanged += new EventHandler(this.numericIPEnds_ValueChanged);
                numeric.Click += new EventHandler(this.numeric_Click);
                numeric.Enter += new EventHandler(this.numeric_Enter);
                numeric.KeyDown += new KeyEventHandler(this.numericIPEnds_KeyDown);
            }
        }        
        #endregion


        #region Form event handlers
        
        private void frmAutoInsert_Load(object sender, EventArgs e)
        {
            this.radioIP.Checked = true;
        }
        private void numericIPEnds_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Find index
                int index = -1;
                for (int i = 0; i < this._numericIPEnds.Length; i++)
                {
                    if ((NumericUpDown)sender == this._numericIPEnds[i])
                    {
                        index = i;
                        break;
                    }
                }
                if (index < 0)
                    return;

                // Select the next numeric
                if (index < 3)
                    this._numericIPEnds[index + 1].Select();
            }
        }
        private void numericIPStarts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Find index
                int index = -1;
                for (int i = 0; i < this._numericIPStarts.Length; i++)
                {
                    if ((NumericUpDown)sender == this._numericIPStarts[i])
                    {
                        index = i;
                        break;
                    }
                }
                if (index < 0)
                    return;

                // Select the next numeric
                if (index <  3)
                    this._numericIPStarts[index + 1].Select();
            }            
        }
        private void numericIPStarts_ValueChanged(object sender, EventArgs e)
        {
            // Find index
            int index = -1;
            for (int i = 0; i < this._numericIPStarts.Length; i++)
            {
                if ((NumericUpDown)sender == this._numericIPStarts[i])
                {
                    index = i;
                    break;
                }
            }
            if (index < 0)
                return;

            // Set minimums for the end-numerics accordingly
            if (index == 0)
                this._numericIPEnds[index].Minimum = this._numericIPStarts[index].Value;
            else if (this._numericIPEnds[index - 1].Value == this._numericIPStarts[index - 1].Value)
                this._numericIPEnds[index].Minimum = this._numericIPStarts[index].Value;

            // Calculate the total number of elements
            this._totalElements = this.GetTotalElementsForIP();
            this.lblTotalElements.Text = this._totalElements.ToString("#,#");
        }
        private void numericIPEnds_ValueChanged(object sender, EventArgs e)
        {
            // Find index
            int index = -1;
            for (int i = 0; i < this._numericIPEnds.Length; i++)
            {
                if ((NumericUpDown)sender == this._numericIPEnds[i])
                {
                    index = i;
                    break;
                }
            }
            if (index < 0)
                return;

            // Set minimums for the end-numerics accordingly
            if (index < 3)
            {
                if (this._numericIPEnds[index].Value > this._numericIPStarts[index].Value)
                    this._numericIPEnds[index + 1].Minimum = 0;
                else
                    this._numericIPEnds[index + 1].Minimum = this._numericIPStarts[index + 1].Value;
            }

            // Calculate the total number of elements
            this._totalElements = this.GetTotalElementsForIP();
            this.lblTotalElements.Text = this._totalElements.ToString("#,#");
        }
        private void numeric_Click(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;

            // Select the text of the numeric
            numeric.Select(0, numeric.Value.ToString().Length);
        }
        private void numeric_Enter(object sender, EventArgs e)
        {
            this.numeric_Click(sender, e);            
        }
        private void numericsCustoms_ValueChanged(object sender, EventArgs e)
        {
            // Calculate the total number of elements
            this._totalElements = this.GetTotalElementsForCustom();
            this.lblTotalElements.Text = this._totalElements.ToString("#,#");
        }        
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.OKClicked != null)
            {                
                if (this.radioIP.Checked)
                {
                    this._expression = "{0}.{1}.{2}.{3}";
                    this._absoluteMinimums = new int[] { 0, 0, 0, 0 };
                    this._absoluteMaximums = new int[] { 255, 255, 255, 255 };

                    this._startValues = new int[] {
                        (int)this.numericStart0.Value, 
                        (int)this.numericStart1.Value, 
                        (int)this.numericStart2.Value, 
                        (int)this.numericStart3.Value};

                    this._endValues = new int[] {
                        (int)this.numericEnd0.Value, 
                        (int)this.numericEnd1.Value, 
                        (int)this.numericEnd2.Value, 
                        (int)this.numericEnd3.Value};
                }
                else if (this.radioCustomize.Checked)
                {
                    if (!this._isFormatStringOK)
                    {
                        MessageBox.Show("שגיאה בהכנסת המחרוזת", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.txtInsertFormatString.Focus();
                        return;
                    }

                    this._expression = this.txtInsertFormatString.Text;                    
                    this._absoluteMinimums = new int[this._numericCustomMins.Length];
                    this._absoluteMaximums = new int[this._numericCustomMaxs.Length];
                    this._startValues = new int[this._numericCustomMins.Length];
                    this._endValues = new int[this._numericCustomMaxs.Length];

                    for (int i = 0; i < this._absoluteMinimums.Length; i++)
                    {
                        this._absoluteMinimums[i] = 
                            this._startValues[i] = (int)this._numericCustomMins[i].Value;                        

                        this._absoluteMaximums[i] = 
                            this._endValues[i] = (int)this._numericCustomMaxs[i].Value;
                    }                    
                }

                // Disable the form temporarly
                this.Enabled = false;
                // Raise the event
                this.OKClicked(this, EventArgs.Empty);
                // Enable the form again
                this.Enabled = true;
            }
            this.Hide();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void frmAutoInsert_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }                
        private void radioIP_CheckedChanged(object sender, EventArgs e)
        {
            this.panelIP.Enabled = this.radioIP.Checked;
            if (this.radioIP.Checked)
            {
                this.btnOK.TabIndex = this.numericEnd3.TabIndex + 1;
                this.btnCancel.TabIndex = this.btnOK.TabIndex + 1;

                this._totalElements = this.GetTotalElementsForIP();
            }
            else
            {
                this._totalElements = this.GetTotalElementsForCustom();
            }
            this.lblTotalElements.Text = this._totalElements.ToString("#,#");
        }
        private void radioCustomize_CheckedChanged(object sender, EventArgs e)
        {
            this.panelCustomize.Enabled = this.radioCustomize.Checked;
            this.txtInsertFormatString.Focus();
        }       
        private void txtInsertFormatString_TextChanged(object sender, EventArgs e)
        {
            this._previousNumberOfFormats = this._numberOfFormats;

            this._expression = this.txtInsertFormatString.Text;

            // Find out how many formats in the input string (up to 10 are supported)
            for (int i = 0; i <= 10; i++)
            {
                try
                {
                    object[] objectsArray = Enumerable.Range(0, i).Cast<object>().ToArray();
                    this.lblExample.Text = string.Format(this._expression, objectsArray);
                    this._isFormatStringOK = true;
                    this._numberOfFormats = i;
                    break;
                }
                catch (Exception)
                {
                    this._isFormatStringOK = false;
                }
            }
            if (!this._isFormatStringOK)
            {
                this.lblExample.Text = "שגיאה במחרוזת";
                this._numberOfFormats = this._previousNumberOfFormats;
            }
            else if (this._numberOfFormats != this._previousNumberOfFormats)
            {                
                this.SetCustomNumerics();
            }
        }
        private void lblTotalElements_SizeChanged(object sender, EventArgs e)
        {
            // Locate the label on the left of its title label
            this.lblTotalElements.Left = this.lblTotalElementsTitle.Left - this.lblTotalElements.Width;
        }
        
        #endregion


        #region Public methods
        
        public object[] GetFirstIterators()
        {
            object[] ret = new object[this._startValues.Length];
            for (int i = 0; i < this._startValues.Length; i++)
                ret[i] = this._startValues[i];            
            
            return ret;
        }
        public bool HasNext(object[] currentIterator)
        {
            for (int i = 0; i < currentIterator.Length; i++)
            {
                if ((int)currentIterator[i] < this._endValues[i])
                    return true;
            }

            return false;
        }
        public bool IsLast(object[] currentIterator)
        {
            return (!this.HasNext(currentIterator));
        }        
        public void GetNextIterators(ref object[] currentIterator)
        {
            int index = currentIterator.Length - 1;
            bool continueLoop = true;
            while (this.HasNext(currentIterator) && continueLoop && index >= 0)
            {
                currentIterator[index] = (int)currentIterator[index] + 1;
                if ((int)currentIterator[index] > this._absoluteMaximums[index])
                {
                    currentIterator[index] = this._absoluteMinimums[index];
                    index--;
                    // (continue the loop with the smaller index)
                }
                else
                {
                    continueLoop = false;
                }
            }

            if (index < 0)
                throw new ArgumentOutOfRangeException();
        }
        
        #endregion


        #region Private methods
        
        private void SetCustomNumerics()
        {
            // Dispose old instances (numericCustomMaxs)
            if (this._numericCustomMaxs != null)
                foreach (NumericUpDown numeric in this._numericCustomMaxs)
                    numeric.Dispose();

            // Dispose old instances (numericCustomMins)
            if (this._numericCustomMins != null)
                foreach (NumericUpDown numeric in this._numericCustomMins)
                    numeric.Dispose();

            // Dispose old instances (lblCustomArgumentsTitles)
            if (this._lblCustomArgumentsTitles != null)
                foreach (Label lbl in this._lblCustomArgumentsTitles)
                    lbl.Dispose();

            // Set new arrays
            this._numericCustomMaxs = new NumericUpDown[_numberOfFormats];
            this._numericCustomMins = new NumericUpDown[_numberOfFormats];
            this._lblCustomArgumentsTitles = new Label[_numberOfFormats];

            // Set first vertical location
            int yPosition = this.lblArgumentTitle.Bottom + 10;

            // Loop for every item
            for (int i = 0; i < this._numberOfFormats; i++)
            {
                // Create items (numerics and label)
                this._numericCustomMaxs[i] = new NumericUpDown();
                this._numericCustomMins[i] = new NumericUpDown();
                this._lblCustomArgumentsTitles[i] = new Label();

                // Add items to the panel
                this.panelInsertArguments.Controls.Add(_lblCustomArgumentsTitles[i]);
                this.panelInsertArguments.Controls.Add(this._numericCustomMaxs[i]);
                this.panelInsertArguments.Controls.Add(this._numericCustomMins[i]);

                // Set properties for the label
                this._lblCustomArgumentsTitles[i].AutoSize = false;
                this._lblCustomArgumentsTitles[i].Text = i.ToString();
                this._lblCustomArgumentsTitles[i].Location = new Point(this.lblArgumentTitle.Left, yPosition - 3);
                this._lblCustomArgumentsTitles[i].Width = this.lblArgumentTitle.Width;
                this._lblCustomArgumentsTitles[i].TextAlign = ContentAlignment.MiddleCenter;

                // Set properties for the numerics (numericCustomMaxs)
                this._numericCustomMaxs[i].Location = new Point(this.lblMaxTitle.Left, yPosition);
                this._numericCustomMaxs[i].Width = this.lblMaxTitle.Width;
                this._numericCustomMaxs[i].Minimum = decimal.MinValue;
                this._numericCustomMaxs[i].Maximum = decimal.MaxValue;
                this._numericCustomMaxs[i].TabIndex = 2 * i + 1;
                this._numericCustomMaxs[i].ValueChanged += new EventHandler(this.numericsCustoms_ValueChanged);
                this._numericCustomMaxs[i].Click += new EventHandler(this.numeric_Click);
                this._numericCustomMaxs[i].Enter += new EventHandler(this.numeric_Enter);


                // Set properties for the numerics (numericCustomMins)
                this._numericCustomMins[i].Location = new Point(this.lblMinTitle.Left, yPosition);
                this._numericCustomMins[i].Width = this.lblMinTitle.Width;
                this._numericCustomMins[i].Minimum = decimal.MinValue;
                this._numericCustomMins[i].Maximum = decimal.MaxValue;
                this._numericCustomMins[i].TabIndex = 2 * i;
                this._numericCustomMins[i].ValueChanged += new EventHandler(this.numericsCustoms_ValueChanged);
                this._numericCustomMins[i].Click += new EventHandler(this.numeric_Click);
                this._numericCustomMins[i].Enter += new EventHandler(this.numeric_Enter);

                yPosition += this._numericCustomMins[i].Height + 5;
            }
            // Set visibility of "panelInsertArguments"
            this.panelInsertArguments.Visible = (this._numberOfFormats > 0);

            // Set tab stop index for "btnOK"
            if (this._numberOfFormats > 0)
                this.btnOK.TabIndex = this._numericCustomMaxs[this._numericCustomMaxs.Length - 1].TabIndex + 1;            
        }
        private long GetTotalElementsForCustom()
        {
            long totalElements = 1;
            if (this._numericCustomMaxs != null)
            {
                for (int i = 0; i < this._numericCustomMaxs.Length; i++)
                {
                    this._numericCustomMaxs[i].Minimum = this._numericCustomMins[i].Value;
                    totalElements *= (long)
                        (this._numericCustomMaxs[i].Value -
                        this._numericCustomMins[i].Value + 1);
                }
            }

            return totalElements;
        }
        private long GetTotalElementsForIP()
        {
            long startValue = (long)
                (256 * 256 * 256 * this.numericStart0.Value +
                256 * 256 * this.numericStart1.Value +
                256 * this.numericStart2.Value +
                1 * this.numericStart3.Value);

            long endValue = (long)
                (256 * 256 * 256 * this.numericEnd0.Value +
                256 * 256 * this.numericEnd1.Value +
                256 * this.numericEnd2.Value +
                1 * this.numericEnd3.Value);

            long totalElements = endValue - startValue + 1;
            return totalElements;
        }
        
        #endregion


        #region Properties
        public string Expression
        {
            get { return this._expression; }
        }

        public long TotalElements
        {
            get { return this._totalElements; }
        }
        
        #endregion        
        
    }
}