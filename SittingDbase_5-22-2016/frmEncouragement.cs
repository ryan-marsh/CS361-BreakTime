using System;
using System.Windows.Forms;

namespace BreakTime
{
    public partial class frmEncouragement : Form
    {
        private bool displayedSystemTrayBalloon;
        DateTime starttime;

        public frmEncouragement()
        {
            InitializeComponent();
        }

        public Encouragement GetEncouragement()
        {
            // see: https://msdn.microsoft.com/en-us/library/system.uribuilder(v=vs.110).aspx
            // for more information about the UriBuilder class
            UriBuilder builder = new UriBuilder();

            try
            {
                builder.Scheme = Settings.Scheme;
                builder.Host = Settings.Server;
                builder.Path = Settings.EncouragementPath;
                return HttpRequestHelper.RequestObject<Encouragement>(builder.ToString());
            }
            catch (Exception)
            {
            }

            return null; // failed
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan dt = DateTime.Now - starttime;
            if (dt > Settings.Interval)
            {
                systemTrayIcon.Text = "Time for a break!";
                // action on timeout goes here
                Popup(true);
            }
            else
            {
                TimeSpan remaining = Settings.Interval - dt;
                int seconds = (int)remaining.TotalSeconds;
                remaining = TimeSpan.FromSeconds(seconds);
                systemTrayIcon.Text = "Next break in " + remaining.ToString();
            }
        }

        private void frmEncouragement_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Popup(false);
            }
        }

        private void Popup(bool enable)
        {
            this.systemTrayIcon.Visible = !enable;
            this.Visible = enable;
            if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal;
            if (enable)
            {
                Encouragement encouragement = GetEncouragement();
                if (encouragement != null)
                {
                    this.txtEncouragement.Text = encouragement.description;
                }
            }
            else
            {
                if (!displayedSystemTrayBalloon)
                {
                    // IMPORTANT: NotifyIcon MUST BE VISIBLE in order for the balloon to be displayed.
                    systemTrayIcon.BalloonTipTitle = this.Text;
                    systemTrayIcon.BalloonTipText = this.Text + " has been minimized to the system tray.\nDouble-click this icon to restore.";
                    systemTrayIcon.ShowBalloonTip(10000);
                    displayedSystemTrayBalloon = true;
                }
                starttime = DateTime.Now;
            }
            this.lblPrompt.Text = string.Format(Settings.UserGreetingFormat, Settings.UserName);
            this.timer.Enabled = !enable;
        }

        bool quit = false;
        private void frmEncouragement_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.quit)
            {
                if (e.CloseReason == CloseReason.UserClosing) //prevent user from closing app
                {
                    e.Cancel = true;
                    this.WindowState = FormWindowState.Minimized;
                }
            }
        }

        private void frmEncouragement_Load(object sender, EventArgs e)
        {
            Popup(true);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            Popup(true);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.quit = true;
            this.Close();
        }

        private void btnNotNow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void systemTrayIcon_DoubleClick(object sender, EventArgs e)
        {
            Popup(true);
        }

        private void btnShowStretch_Click(object sender, EventArgs e)
        {
            frmStretch stretch = new frmStretch();
            stretch.ShowDialog(this);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            dlgSettings dlg = new dlgSettings();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                Settings.Interval = dlg.Interval;
                Settings.UserName = dlg.UserName;
                this.lblPrompt.Text = string.Format(Settings.UserGreetingFormat, Settings.UserName);
                Settings.WriteUserSettings(); // save user settings to disk if they have changed
            }
        }

        private void btnFileQuit_Click(object sender, EventArgs e)
        {
            this.quit = true;
            this.Close();
        }

        private void btnResources_Click(object sender, EventArgs e)
        {
            UriBuilder builder = new UriBuilder();

            try
            {
                builder.Scheme = Settings.Scheme;
                builder.Host = Settings.Server;
                builder.Path = Settings.ResourcesPath;
                System.Diagnostics.Process.Start(builder.ToString()); // will launch the user's default browser and display the specified page
            }
            catch (Exception) { }
        }

        private void btnWhatHurts_Click(object sender, EventArgs e)
        {
            dlgHurts dlg = new dlgHurts();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                Settings.WhatHurts = dlg.WhatHurts;
                Settings.WriteUserSettings(); // save user settings to disk if they have changed
            }
        }

        #region Public API for testing
        public String getTxtEncouragement()
        {
            return this.txtEncouragement.Text;
        }

        public void triggerTruePopup()
        {
            Popup(true);
        }

        public void triggerFalsePopup(bool displayTrayBalloon)
        {
            this.displayedSystemTrayBalloon = !displayTrayBalloon;
            Popup(false);
        }
        #endregion

    }
}
