using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Web;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace SittingDbase
{
    public partial class frmStretch : Form
    {
        private const string SERVER = "sittingdbase.appspot.com";

        public frmStretch()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            GetRandomStretch();
        }

        private void GetRandomStretch()
        {
            // see: https://msdn.microsoft.com/en-us/library/system.uribuilder(v=vs.110).aspx
            // for more information about the UriBuilder class
            UriBuilder builder = new UriBuilder();
            Stretch stretch = null;
            Image image = null;

            try
            {
                // get stretch object
                builder.Scheme = Settings.Scheme;
                builder.Host = Settings.Server;
                builder.Path = Settings.StretchPath;
                stretch = HttpRequestHelper.RequestObject<Stretch>(builder.ToString());

                // get image
                builder.Path = stretch.imgURL;
                image = HttpRequestHelper.RequestImage(builder.ToString());

                // populate dialog
                Image existing = this.pictureStretch.Image;
                this.pictureStretch.Image = image;
                if (existing != null) existing.Dispose(); // clean up

                this.txtName.Text = stretch.name;
                this.txtDescription.Text = "Description:\r\n" + stretch.description;
                this.txtStatus.Text = string.Format("Retrieved: {0}", DateTime.Now);
            }
            catch (Exception)
            {
            }
        }

        private void frmStretch_Load(object sender, EventArgs e)
        {
            GetRandomStretch();
        }


        // Public API for testing
        public void callGetRandomStretch()
        {
            this.GetRandomStretch();
        }

        public bool hasImage()
        {
            return this.pictureStretch.Image != null;
        }

        public bool hasDescription()
        {
            return this.txtDescription.Text != "Description:\r\n";
        }

        public bool hasName()
        {
            return this.txtName.Text != null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (!this.quit)
        //    {
        //        if (e.CloseReason == CloseReason.UserClosing) //prevent user from closing app
        //        {
        //            e.Cancel = true;
        //            this.WindowState = FormWindowState.Minimized;
        //        }
        //    }
        //}

        //private bool displayedSystemTrayBalloon;

        //private void Form1_Resize(object sender, EventArgs e)
        //{
        //    if (this.WindowState == FormWindowState.Minimized)
        //    {
        //        Popup(false);
        //    }
        //}

        //private void Popup(bool enable)
        //{

        //    //this.systemTrayIcon.Visible = !enable;
        //    this.Visible = enable;
        //    this.timer.Enabled = !enable;
        //    if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal;

        //    if (enable)
        //    {
        //        btnRandom_Click(null, null);
        //    }
        //    else
        //    {
        //        if (!displayedSystemTrayBalloon)
        //        {
        //            // IMPORTANT: NotifyIcon MUST BE VISIBLE in order for the balloon to be displayed.
        //            systemTrayIcon.BalloonTipTitle = this.Text;
        //            systemTrayIcon.BalloonTipText = this.Text + " has been minimized to the system tray.\nDouble-click this icon to restore.";
        //            systemTrayIcon.ShowBalloonTip(10000);
        //            displayedSystemTrayBalloon = true;
        //        }
        //        starttime = DateTime.Now;
        //    }
        //}

        //private void systemTrayIcon_BalloonTipClicked(object sender, EventArgs e)
        //{
        //    Popup(true);
        //}

        //private void systemTrayIcon_DoubleClick(object sender, EventArgs e)
        //{
        //    Popup(true);
        //}

        //private void btnRestore_Click(object sender, EventArgs e)
        //{
        //    Popup(true);
        //}

        //private bool quit;
        //private void btnQuit_Click(object sender, EventArgs e)
        //{
        //    this.quit = true;
        //    this.Close();
        //}

        //TimeSpan timeout = TimeSpan.FromSeconds(30.0);
        //private void timer_Tick(object sender, EventArgs e)
        //{
        //    if (DateTime.Now - starttime > timeout)
        //    {
        //        Popup(true);
        //    }
        //}

        //DateTime starttime;
        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    //starttime = DateTime.Now;
        //}

        //private void frmStretch_FormClosed(object sender, FormClosedEventArgs e)
        //{

        //    //this.systemTrayIcon.Dispose();
        //}

        //private void systemTrayIcon_BalloonTipShown(object sender, EventArgs e)
        //{
        //    System.Diagnostics.Debug.WriteLine("shown!");
        //}
    }
}
