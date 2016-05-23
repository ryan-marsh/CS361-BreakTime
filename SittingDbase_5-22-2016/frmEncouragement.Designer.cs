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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnShowStretch = new System.Windows.Forms.Button();
            this.btnNotNow = new System.Windows.Forms.Button();
            this.contextMenuSystemTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.systemTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
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
            this.txtEncouragement.Location = new System.Drawing.Point(12, 28);
            this.txtEncouragement.Name = "txtEncouragement";
            this.txtEncouragement.Size = new System.Drawing.Size(424, 251);
            this.txtEncouragement.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(448, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnShowStretch
            // 
            this.btnShowStretch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowStretch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowStretch.Location = new System.Drawing.Point(273, 285);
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
            this.btnNotNow.Location = new System.Drawing.Point(207, 285);
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
            this.btnRestore,
            this.toolStripSeparator1,
            this.btnQuit});
            this.contextMenuSystemTray.Name = "contextMenuSystemTray";
            this.contextMenuSystemTray.Size = new System.Drawing.Size(114, 54);
            // 
            // btnRestore
            // 
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(113, 22);
            this.btnRestore.Text = "Restore";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(110, 6);
            // 
            // btnQuit
            // 
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(113, 22);
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // timer
            // 
            this.timer.Interval = 250;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // systemTrayIcon
            // 
            this.systemTrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.systemTrayIcon.BalloonTipText = "some text";
            this.systemTrayIcon.BalloonTipTitle = "some title";
            this.systemTrayIcon.ContextMenuStrip = this.contextMenuSystemTray;
            this.systemTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("systemTrayIcon.Icon")));
            this.systemTrayIcon.Text = "my text";
            this.systemTrayIcon.Visible = true;
            this.systemTrayIcon.DoubleClick += new System.EventHandler(this.systemTrayIcon_DoubleClick);
            // 
            // frmEncouragement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 320);
            this.Controls.Add(this.btnNotNow);
            this.Controls.Add(this.btnShowStretch);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtEncouragement);
            this.Name = "frmEncouragement";
            this.Text = "Break Time!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEncouragement_FormClosing);
            this.Load += new System.EventHandler(this.frmEncouragement_Load);
            this.Resize += new System.EventHandler(this.frmEncouragement_Resize);
            this.contextMenuSystemTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtEncouragement;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button btnShowStretch;
        private System.Windows.Forms.Button btnNotNow;
        private System.Windows.Forms.ContextMenuStrip contextMenuSystemTray;
        private System.Windows.Forms.ToolStripMenuItem btnRestore;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnQuit;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NotifyIcon systemTrayIcon;
    }
}