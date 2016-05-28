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

        [DataContract]
        private class Stretch
        {
            // see: https://msdn.microsoft.com/en-us/library/bb410770(v=vs.110).aspx
            [DataMember]
            public long key;

            [DataMember]
            public string name;

            [DataMember]
            public string imgURL;

            [DataMember]
            public string description;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            GetRandomStretch();
        }

        private void GetRandomStretch()
        {

            // see: https://msdn.microsoft.com/en-us/library/system.uribuilder(v=vs.110).aspx
            UriBuilder builder = new UriBuilder();
            builder.Scheme = "http";
            builder.Host = SERVER;
            builder.Path = "stretch";

            // see: http://www.codeproject.com/Articles/6554/How-to-use-HttpWebRequest-and-HttpWebResponse-in-N
            // and: https://msdn.microsoft.com/en-us/library/system.net.httpwebrequest(v=vs.110).aspx
            HttpWebRequest request = WebRequest.CreateHttp(builder.ToString());
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            if (response != null)
            {
                // see: http://stackoverflow.com/questions/18242429/how-to-deserialize-json-data
                Stream content = response.GetResponseStream();
                var s = new DataContractJsonSerializer(typeof(Stretch));
                var j = (Stretch)s.ReadObject(content);
                content.Dispose();
                response.Dispose();

                builder.Path = j.imgURL;
                request = WebRequest.CreateHttp(builder.ToString());
                response = request.GetResponse() as HttpWebResponse;

                // see: https://msdn.microsoft.com/en-us/library/1kcb3wy4(v=vs.110).aspx
                Image img = Image.FromStream(response.GetResponseStream());
                content.Dispose();
                response.Dispose();

                Image existing = this.pictureStretch.Image;
                this.pictureStretch.Image = img;
                if (existing != null) existing.Dispose(); // clean up

                this.txtName.Text = j.name;

                this.txtDescription.Clear();
                this.txtDescription.AppendText("Description:\r\n" + j.description);
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
