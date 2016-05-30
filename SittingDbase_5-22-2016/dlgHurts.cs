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
    public partial class dlgHurts : Form
    {
        public dlgHurts()
        {
            InitializeComponent();
        }

        public Hurts WhatHurts
        {
            get
            {
                return new Hurts()
                {
                    head = chkHead.Checked,
                    eyes = chkEyes.Checked,
                    hands = chkHands.Checked,
                    wrists = chkWrists.Checked,
                    neck = chkNeck.Checked,
                    elbows = chkElbows.Checked,
                    shoulders = chkShoulders.Checked,
                    back = chkBack.Checked,
                    legs = chkLegs.Checked,
                    knees = chkKnees.Checked,
                    feet = chkFeet.Checked
                };
            }
            private set
            {
                if (value != null)
                {
                    chkHead.Checked = value.head;
                    chkEyes.Checked = value.eyes;
                    chkHands.Checked = value.hands;
                    chkWrists.Checked = value.wrists;
                    chkNeck.Checked = value.neck;
                    chkElbows.Checked = value.elbows;
                    chkShoulders.Checked = value.shoulders;
                    chkBack.Checked = value.back;
                    chkLegs.Checked = value.legs;
                    chkKnees.Checked = value.knees;
                    chkFeet.Checked = value.feet;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; // also closes the dialog
        }

        private void dlgHurts_Activated(object sender, EventArgs e)
        {
            this.WhatHurts = Settings.WhatHurts;
        }
    }
}
