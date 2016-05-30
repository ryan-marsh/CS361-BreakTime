namespace BreakTime
{
    partial class dlgHurts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlgHurts));
            this.diagram = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkElbows = new System.Windows.Forms.CheckBox();
            this.chkWrists = new System.Windows.Forms.CheckBox();
            this.chkHands = new System.Windows.Forms.CheckBox();
            this.chkShoulders = new System.Windows.Forms.CheckBox();
            this.chkNeck = new System.Windows.Forms.CheckBox();
            this.chkBack = new System.Windows.Forms.CheckBox();
            this.chkKnees = new System.Windows.Forms.CheckBox();
            this.chkLegs = new System.Windows.Forms.CheckBox();
            this.chkFeet = new System.Windows.Forms.CheckBox();
            this.chkEyes = new System.Windows.Forms.CheckBox();
            this.chkHead = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.diagram)).BeginInit();
            this.SuspendLayout();
            // 
            // diagram
            // 
            this.diagram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diagram.Image = ((System.Drawing.Image)(resources.GetObject("diagram.Image")));
            this.diagram.Location = new System.Drawing.Point(12, 12);
            this.diagram.Name = "diagram";
            this.diagram.Size = new System.Drawing.Size(400, 533);
            this.diagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.diagram.TabIndex = 0;
            this.diagram.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(337, 557);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(256, 557);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // chkElbows
            // 
            this.chkElbows.AutoSize = true;
            this.chkElbows.BackColor = System.Drawing.Color.White;
            this.chkElbows.Location = new System.Drawing.Point(299, 167);
            this.chkElbows.Name = "chkElbows";
            this.chkElbows.Size = new System.Drawing.Size(60, 17);
            this.chkElbows.TabIndex = 6;
            this.chkElbows.Text = "Elbows";
            this.chkElbows.UseVisualStyleBackColor = false;
            // 
            // chkWrists
            // 
            this.chkWrists.AutoSize = true;
            this.chkWrists.BackColor = System.Drawing.Color.White;
            this.chkWrists.Location = new System.Drawing.Point(320, 105);
            this.chkWrists.Name = "chkWrists";
            this.chkWrists.Size = new System.Drawing.Size(55, 17);
            this.chkWrists.TabIndex = 4;
            this.chkWrists.Text = "Wrists";
            this.chkWrists.UseVisualStyleBackColor = false;
            // 
            // chkHands
            // 
            this.chkHands.AutoSize = true;
            this.chkHands.BackColor = System.Drawing.Color.White;
            this.chkHands.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkHands.Location = new System.Drawing.Point(38, 80);
            this.chkHands.Name = "chkHands";
            this.chkHands.Size = new System.Drawing.Size(57, 17);
            this.chkHands.TabIndex = 3;
            this.chkHands.Text = "Hands";
            this.chkHands.UseVisualStyleBackColor = false;
            // 
            // chkShoulders
            // 
            this.chkShoulders.AutoSize = true;
            this.chkShoulders.BackColor = System.Drawing.Color.White;
            this.chkShoulders.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkShoulders.Location = new System.Drawing.Point(127, 185);
            this.chkShoulders.Name = "chkShoulders";
            this.chkShoulders.Size = new System.Drawing.Size(73, 17);
            this.chkShoulders.TabIndex = 7;
            this.chkShoulders.Text = "Shoulders";
            this.chkShoulders.UseVisualStyleBackColor = false;
            // 
            // chkNeck
            // 
            this.chkNeck.AutoSize = true;
            this.chkNeck.BackColor = System.Drawing.Color.White;
            this.chkNeck.Location = new System.Drawing.Point(217, 128);
            this.chkNeck.Name = "chkNeck";
            this.chkNeck.Size = new System.Drawing.Size(52, 17);
            this.chkNeck.TabIndex = 5;
            this.chkNeck.Text = "Neck";
            this.chkNeck.UseVisualStyleBackColor = false;
            // 
            // chkBack
            // 
            this.chkBack.AutoSize = true;
            this.chkBack.BackColor = System.Drawing.Color.White;
            this.chkBack.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBack.Location = new System.Drawing.Point(149, 260);
            this.chkBack.Name = "chkBack";
            this.chkBack.Size = new System.Drawing.Size(51, 17);
            this.chkBack.TabIndex = 8;
            this.chkBack.Text = "Back";
            this.chkBack.UseVisualStyleBackColor = false;
            // 
            // chkKnees
            // 
            this.chkKnees.AutoSize = true;
            this.chkKnees.BackColor = System.Drawing.Color.White;
            this.chkKnees.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkKnees.Location = new System.Drawing.Point(111, 425);
            this.chkKnees.Name = "chkKnees";
            this.chkKnees.Size = new System.Drawing.Size(56, 17);
            this.chkKnees.TabIndex = 10;
            this.chkKnees.Text = "Knees";
            this.chkKnees.UseVisualStyleBackColor = false;
            // 
            // chkLegs
            // 
            this.chkLegs.AutoSize = true;
            this.chkLegs.BackColor = System.Drawing.Color.White;
            this.chkLegs.Location = new System.Drawing.Point(242, 370);
            this.chkLegs.Name = "chkLegs";
            this.chkLegs.Size = new System.Drawing.Size(49, 17);
            this.chkLegs.TabIndex = 9;
            this.chkLegs.Text = "Legs";
            this.chkLegs.UseVisualStyleBackColor = false;
            // 
            // chkFeet
            // 
            this.chkFeet.AutoSize = true;
            this.chkFeet.BackColor = System.Drawing.Color.White;
            this.chkFeet.Location = new System.Drawing.Point(289, 518);
            this.chkFeet.Name = "chkFeet";
            this.chkFeet.Size = new System.Drawing.Size(47, 17);
            this.chkFeet.TabIndex = 11;
            this.chkFeet.Text = "Feet";
            this.chkFeet.UseVisualStyleBackColor = false;
            // 
            // chkEyes
            // 
            this.chkEyes.AutoSize = true;
            this.chkEyes.BackColor = System.Drawing.Color.White;
            this.chkEyes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkEyes.Location = new System.Drawing.Point(118, 44);
            this.chkEyes.Name = "chkEyes";
            this.chkEyes.Size = new System.Drawing.Size(49, 17);
            this.chkEyes.TabIndex = 1;
            this.chkEyes.Text = "Eyes";
            this.chkEyes.UseVisualStyleBackColor = false;
            // 
            // chkHead
            // 
            this.chkHead.AutoSize = true;
            this.chkHead.BackColor = System.Drawing.Color.White;
            this.chkHead.Location = new System.Drawing.Point(261, 44);
            this.chkHead.Name = "chkHead";
            this.chkHead.Size = new System.Drawing.Size(52, 17);
            this.chkHead.TabIndex = 2;
            this.chkHead.Text = "Head";
            this.chkHead.UseVisualStyleBackColor = false;
            // 
            // dlgHurts
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(424, 592);
            this.Controls.Add(this.chkFeet);
            this.Controls.Add(this.chkLegs);
            this.Controls.Add(this.chkKnees);
            this.Controls.Add(this.chkBack);
            this.Controls.Add(this.chkEyes);
            this.Controls.Add(this.chkHead);
            this.Controls.Add(this.chkNeck);
            this.Controls.Add(this.chkShoulders);
            this.Controls.Add(this.chkHands);
            this.Controls.Add(this.chkWrists);
            this.Controls.Add(this.chkElbows);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.diagram);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(440, 630);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(440, 630);
            this.Name = "dlgHurts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Where Does It Hurt?";
            this.Activated += new System.EventHandler(this.dlgHurts_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.diagram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox diagram;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkElbows;
        private System.Windows.Forms.CheckBox chkWrists;
        private System.Windows.Forms.CheckBox chkHands;
        private System.Windows.Forms.CheckBox chkShoulders;
        private System.Windows.Forms.CheckBox chkNeck;
        private System.Windows.Forms.CheckBox chkBack;
        private System.Windows.Forms.CheckBox chkKnees;
        private System.Windows.Forms.CheckBox chkLegs;
        private System.Windows.Forms.CheckBox chkFeet;
        private System.Windows.Forms.CheckBox chkEyes;
        private System.Windows.Forms.CheckBox chkHead;
    }
}