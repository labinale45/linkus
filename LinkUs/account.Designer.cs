namespace LinkUs
{
    partial class account
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
            this.profile = new CaraTex_Framework.CaraTexCirculerImage();
            this.ppLabel = new System.Windows.Forms.Label();
            this.about = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contactLabel = new System.Windows.Forms.Label();
            this.bioLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usrName = new System.Windows.Forms.Label();
            this.uBtn = new System.Windows.Forms.Button();
            this.uMsg = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // profile
            // 
            this.profile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.profile.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.profile.BorderColor = System.Drawing.Color.Transparent;
            this.profile.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(81)))), ((int)(((byte)(114)))));
            this.profile.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.profile.BorderSize = 2;
            this.profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile.GradientAngle = 50F;
            this.profile.Image = global::LinkUs.Properties.Resources.male_user_50px;
            this.profile.Location = new System.Drawing.Point(206, 22);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(89, 89);
            this.profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profile.TabIndex = 8;
            this.profile.TabStop = false;
            this.profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // ppLabel
            // 
            this.ppLabel.AutoSize = true;
            this.ppLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ppLabel.Location = new System.Drawing.Point(12, 22);
            this.ppLabel.Name = "ppLabel";
            this.ppLabel.Size = new System.Drawing.Size(97, 18);
            this.ppLabel.TabIndex = 9;
            this.ppLabel.Text = "Profile Name";
            // 
            // about
            // 
            this.about.AutoSize = true;
            this.about.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about.ForeColor = System.Drawing.SystemColors.Control;
            this.about.Location = new System.Drawing.Point(12, 76);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(82, 18);
            this.about.TabIndex = 10;
            this.about.Text = "About Me :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.uBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 371);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.usrName);
            this.panel2.Controls.Add(this.contactLabel);
            this.panel2.Controls.Add(this.bioLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ppLabel);
            this.panel2.Controls.Add(this.about);
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(27, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 291);
            this.panel2.TabIndex = 11;
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.contactLabel.Location = new System.Drawing.Point(25, 167);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(97, 14);
            this.contactLabel.TabIndex = 13;
            this.contactLabel.Text = "Reach to the user";
            // 
            // bioLabel
            // 
            this.bioLabel.AutoSize = true;
            this.bioLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bioLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.bioLabel.Location = new System.Drawing.Point(25, 104);
            this.bioLabel.Name = "bioLabel";
            this.bioLabel.Size = new System.Drawing.Size(84, 14);
            this.bioLabel.TabIndex = 12;
            this.bioLabel.Text = "About the user";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Contact :";
            // 
            // usrName
            // 
            this.usrName.AutoSize = true;
            this.usrName.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrName.ForeColor = System.Drawing.SystemColors.Control;
            this.usrName.Location = new System.Drawing.Point(115, 22);
            this.usrName.Name = "usrName";
            this.usrName.Size = new System.Drawing.Size(82, 18);
            this.usrName.TabIndex = 14;
            this.usrName.Text = "User Name";
            // 
            // uBtn
            // 
            this.uBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.uBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.uBtn.Location = new System.Drawing.Point(310, 27);
            this.uBtn.Name = "uBtn";
            this.uBtn.Size = new System.Drawing.Size(75, 23);
            this.uBtn.TabIndex = 12;
            this.uBtn.Text = "Update";
            this.uBtn.UseVisualStyleBackColor = false;
            this.uBtn.Click += new System.EventHandler(this.uBtn_Click);
            // 
            // uMsg
            // 
            this.uMsg.AutoSize = true;
            this.uMsg.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uMsg.ForeColor = System.Drawing.SystemColors.Control;
            this.uMsg.Location = new System.Drawing.Point(250, 46);
            this.uMsg.Name = "uMsg";
            this.uMsg.Size = new System.Drawing.Size(0, 16);
            this.uMsg.TabIndex = 15;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.uMsg);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.panel1);
            this.Name = "account";
            this.Size = new System.Drawing.Size(522, 439);
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CaraTex_Framework.CaraTexCirculerImage profile;
        private System.Windows.Forms.Label ppLabel;
        private System.Windows.Forms.Label about;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label bioLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usrName;
        private System.Windows.Forms.Label uMsg;
        private System.Windows.Forms.Button uBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
