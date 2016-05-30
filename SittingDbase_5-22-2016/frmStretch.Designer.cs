namespace BreakTime
{
    partial class frmStretch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStretch));
            this.toolstrip = new System.Windows.Forms.ToolStrip();
            this.btnRandom = new System.Windows.Forms.ToolStripButton();
            this.txtDescription = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.pictureStretch = new System.Windows.Forms.PictureBox();
            this.status = new System.Windows.Forms.StatusStrip();
            this.txtStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.toolstrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStretch)).BeginInit();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolstrip
            // 
            this.toolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRandom});
            this.toolstrip.Location = new System.Drawing.Point(0, 0);
            this.toolstrip.Name = "toolstrip";
            this.toolstrip.Size = new System.Drawing.Size(419, 25);
            this.toolstrip.TabIndex = 0;
            this.toolstrip.Text = "toolStrip1";
            // 
            // btnRandom
            // 
            this.btnRandom.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnRandom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRandom.Image = ((System.Drawing.Image)(resources.GetObject("btnRandom.Image")));
            this.btnRandom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(115, 22);
            this.btnRandom.Text = "Get Another Stretch";
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.AutoEllipsis = true;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(211, 84);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 252);
            this.txtDescription.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.AutoEllipsis = true;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(5, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(406, 41);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureStretch
            // 
            this.pictureStretch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureStretch.Location = new System.Drawing.Point(5, 69);
            this.pictureStretch.Name = "pictureStretch";
            this.pictureStretch.Size = new System.Drawing.Size(200, 267);
            this.pictureStretch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureStretch.TabIndex = 0;
            this.pictureStretch.TabStop = false;
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtStatus});
            this.status.Location = new System.Drawing.Point(0, 343);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(419, 22);
            this.status.TabIndex = 1;
            // 
            // txtStatus
            // 
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(38, 17);
            this.txtStatus.Text = "status";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(211, 69);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(94, 18);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // frmStretch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 365);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.pictureStretch);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.toolstrip);
            this.Controls.Add(this.status);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStretch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stretch";
            this.Load += new System.EventHandler(this.frmStretch_Load);
            this.toolstrip.ResumeLayout(false);
            this.toolstrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStretch)).EndInit();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolstrip;
        private System.Windows.Forms.ToolStripButton btnRandom;
        private System.Windows.Forms.Label txtDescription;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.PictureBox pictureStretch;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel txtStatus;
        private System.Windows.Forms.Label lblDescription;
    }
}

