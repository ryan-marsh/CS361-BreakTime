using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace SittingDbase
{
    public partial class frmEncouragement : Form
    {
        private const string SERVER = "sittingdbase.appspot.com";

        public frmEncouragement()
        {
            InitializeComponent();
        }

        [DataContract]
        private class Encouragement
        {
            [DataMember]
            public long key;

            [DataMember]
            public string description;
        }

        public string GetEncouragement()
        {
            UriBuilder builder = new UriBuilder();
            HttpWebRequest request;
            HttpWebResponse response;
            Stream content;

            try
            {
                // see: https://msdn.microsoft.com/en-us/library/system.uribuilder(v=vs.110).aspx
                builder.Scheme = "http";
                builder.Host = SERVER;
                builder.Path = "encourage";
                // see: http://www.codeproject.com/Articles/6554/How-to-use-HttpWebRequest-and-HttpWebResponse-in-N
                // and: https://msdn.microsoft.com/en-us/library/system.net.httpwebrequest(v=vs.110).aspx
                request = WebRequest.CreateHttp(builder.ToString());
                response = request.GetResponse() as HttpWebResponse;
                if (response != null)
                {
                    // see: http://stackoverflow.com/questions/18242429/how-to-deserialize-json-data
                    content = response.GetResponseStream();
                    var s = new DataContractJsonSerializer(typeof(Encouragement));
                    var j = (Encouragement)s.ReadObject(content);
                    content.Dispose();
                    response.Dispose();
                    return j.description;
                }

            }
            catch (Exception)
            {
            }
            return null;
        }

        DateTime starttime;
        TimeSpan timeout = TimeSpan.FromSeconds(30.0);
        private void timer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now - starttime > timeout)
            {
                // action on timeout goes here
                Popup(true);
            }
        }

        private void frmEncouragement_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Popup(false);
            }
        }

        private bool displayedSystemTrayBalloon;
        private void Popup(bool enable)
        {
            this.systemTrayIcon.Visible = !enable;
            this.Visible = enable;
            if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal;
            if (enable)
            {
                this.txtEncouragement.Text = GetEncouragement();
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
    }
}
