using System;
using System.Drawing;
using System.Windows.Forms;

namespace BreakTime
{
    public partial class frmStretch : Form
    {
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
                this.txtDescription.Text = stretch.description;
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
            return !string.IsNullOrEmpty(this.txtDescription.Text);
        }

        public bool hasName()
        {
            return !string.IsNullOrEmpty(this.txtName.Text);
        }
    }
}
