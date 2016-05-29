namespace SittingDbase
{
    partial class frmEncouragement
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEncouragement));
            this.txtEncouragement = new System.Windows.Forms.Label();
            this.toolstrip = new System.Windows.Forms.ToolStrip();
            this.btnResources = new System.Windows.Forms.ToolStripButton();
            this.mnuFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFileQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShowStretch = new System.Windows.Forms.Button();
            this.btnNotNow = new System.Windows.Forms.Button();
            this.contextMenuSystemTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnContextRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnContextQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.systemTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolstrip.SuspendLayout();
            this.contextMenuSystemTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEncouragement
            // 
            this.txtEncouragement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncouragement.AutoEllipsis = true;
            this.txtEncouragement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncouragement.Location = new System.Drawing.Point(12, 25);
            this.txtEncouragement.Name = "txtEncouragement";
            this.txtEncouragement.Size = new System.Drawing.Size(424, 120);
            this.txtEncouragement.TabIndex = 2;
            // 
            // toolstrip
            // 
            this.toolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnResources,
            this.mnuFile});
            this.toolstrip.Location = new System.Drawing.Point(0, 0);
            this.toolstrip.Name = "toolstrip";
            this.toolstrip.Size = new System.Drawing.Size(448, 25);
            this.toolstrip.TabIndex = 3;
            this.toolstrip.Text = "toolStrip1";
            // 
            // btnResources
            // 
            this.btnResources.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnResources.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnResources.Image = ((System.Drawing.Image)(resources.GetObject("btnResources.Image")));
            this.btnResources.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnResources.Name = "btnResources";
            this.btnResources.Size = new System.Drawing.Size(73, 22);
            this.btnResources.Text = "&Resources...";
            this.btnResources.Click += new System.EventHandler(this.btnResources_Click);
            // 
            // mnuFile
            // 
            this.mnuFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSettings,
            this.toolStripSeparator2,
            this.btnFileQuit});
            this.mnuFile.Image = ((System.Drawing.Image)(resources.GetObject("mnuFile.Image")));
            this.mnuFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(38, 22);
            this.mnuFile.Text = "&File";
            // 
            // btnSettings
            // 
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(152, 22);
            this.btnSettings.Text = "Settings...";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // btnFileQuit
            // 
            this.btnFileQuit.Name = "btnFileQuit";
            this.btnFileQuit.Size = new System.Drawing.Size(152, 22);
            this.btnFileQuit.Text = "&Quit";
            this.btnFileQuit.Click += new System.EventHandler(this.btnFileQuit_Click);
            // 
            // btnShowStretch
            // 
            this.btnShowStretch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowStretch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowStretch.Location = new System.Drawing.Point(273, 153);
            this.btnShowStretch.Name = "btnShowStretch";
            this.btnShowStretch.Size = new System.Drawing.Size(163, 23);
            this.btnShowStretch.TabIndex = 0;
            this.btnShowStretch.Text = "Show Me A Stretch!";
            this.btnShowStretch.UseVisualStyleBackColor = true;
            this.btnShowStretch.Click += new System.EventHandler(this.btnShowStretch_Click);
            // 
            // btnNotNow
            // 
            this.btnNotNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotNow.Location = new System.Drawing.Point(207, 153);
            this.btnNotNow.Name = "btnNotNow";
            this.btnNotNow.Size = new System.Drawing.Size(60, 23);
            this.btnNotNow.TabIndex = 1;
            this.btnNotNow.Text = "Not Now";
            this.btnNotNow.UseVisualStyleBackColor = true;
            this.btnNotNow.Click += new System.EventHandler(this.btnNotNow_Click);
            // 
            // contextMenuSystemTray
            // 
            this.contextMenuSystemTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnContextRestore,
            this.toolStripSeparator1,
            this.btnContextQuit});
            this.contextMenuSystemTray.Name = "contextMenuSystemTray";
            this.contextMenuSystemTray.Size = new System.Drawing.Size(114, 54);
            // 
            // btnContextRestore
            // 
            this.btnContextRestore.Name = "btnContextRestore";
            this.btnContextRestore.Size = new System.Drawing.Size(113, 22);
            this.btnContextRestore.Text = "Restore";
            this.btnContextRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(110, 6);
            // 
            // btnContextQuit
            // 
            this.btnContextQuit.Name = "btnContextQuit";
            this.btnContextQuit.Size = new System.Drawing.Size(113, 22);
            this.btnContextQuit.Text = "Quit";
            this.btnContextQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // timer
            // 
            this.timer.Interval = 250;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // systemTrayIcon
            // 
            this.systemTrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.systemTrayIcon.ContextMenuStrip = this.contextMenuSystemTray;
            this.systemTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("systemTrayIcon.Icon")));
            this.systemTrayIcon.Visible = true;
            this.systemTrayIcon.DoubleClick += new System.EventHandler(this.systemTrayIcon_DoubleClick);
            // 
            // frmEncouragement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 188);
            this.Controls.Add(this.btnNotNow);
            this.Controls.Add(this.btnShowStretch);
            this.Controls.Add(this.toolstrip);
            this.Controls.Add(this.txtEncouragement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEncouragement";
            this.Text = "Break Time!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEncouragement_FormClosing);
            this.Load += new System.EventHandler(this.frmEncouragement_Load);
            this.Resize += new System.EventHandler(this.frmEncouragement_Resize);
            this.toolstrip.ResumeLayout(false);
            this.toolstrip.PerformLayout();
            this.contextMenuSystemTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtEncouragement;
        private System.Windows.Forms.ToolStrip toolstrip;
        private System.Windows.Forms.Button btnShowStretch;
        private System.Windows.Forms.Button btnNotNow;
        private System.Windows.Forms.ContextMenuStrip contextMenuSystemTray;
        private System.Windows.Forms.ToolStripMenuItem btnContextRestore;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnContextQuit;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NotifyIcon systemTrayIcon;
        private System.Windows.Forms.ToolStripButton btnResources;
        private System.Windows.Forms.ToolStripDropDownButton mnuFile;
        private System.Windows.Forms.ToolStripMenuItem btnSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem btnFileQuit;
    }
}