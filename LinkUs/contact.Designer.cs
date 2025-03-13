namespace LinkUs
{
    partial class contact
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contactName = new System.Windows.Forms.Label();
            this.profile = new CaraTex_Framework.CaraTexCirculerImage();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            this.SuspendLayout();
            // 
            // contactName
            // 
            this.contactName.AutoSize = true;
            this.contactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactName.ForeColor = System.Drawing.SystemColors.Control;
            this.contactName.Location = new System.Drawing.Point(47, 14);
            this.contactName.Name = "contactName";
            this.contactName.Size = new System.Drawing.Size(41, 15);
            this.contactName.TabIndex = 1;
            this.contactName.Text = "label1";
            this.contactName.Click += new System.EventHandler(this.contactName_Click);
            // 
            // profile
            // 
            this.profile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.profile.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.profile.BorderColor = System.Drawing.Color.Black;
            this.profile.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(81)))), ((int)(((byte)(114)))));
            this.profile.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.profile.BorderSize = 2;
            this.profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile.GradientAngle = 50F;
            this.profile.Image = global::LinkUs.Properties.Resources.profile_pic__12_;
            this.profile.Location = new System.Drawing.Point(2, 1);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(41, 41);
            this.profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profile.TabIndex = 9;
            this.profile.TabStop = false;
            this.profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(81)))), ((int)(((byte)(114)))));
            this.Controls.Add(this.profile);
            this.Controls.Add(this.contactName);
            this.Name = "contact";
            this.Size = new System.Drawing.Size(112, 46);
            this.Load += new System.EventHandler(this.contact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label contactName;
        private CaraTex_Framework.CaraTexCirculerImage profile;
    }
}
