using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakTime
{
    public partial class dlgSettings : Form
    {
        public dlgSettings()
        {
            InitializeComponent();
        }

        public TimeSpan Interval
        {
            get
            {
                return TimeSpan.FromMinutes((double)this.numInterval.Value);
            }
            private set
            {
                this.numInterval.Value = (decimal)value.TotalMinutes;
            }
        }

        public string UserName
        {
            get { return this.txtUserName.Text; }
            private set { this.txtUserName.Text = value; }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; // also closes the dialog
        }

        private void dlgSettings_Activated(object sender, EventArgs e)
        {
            this.Interval = Settings.Interval;
            this.UserName = Settings.UserName;
        }
    }
}
