namespace LinkUs
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.panelHead = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.CreateIcon = new System.Windows.Forms.PictureBox();
            this.creatLink = new System.Windows.Forms.LinkLabel();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Bgif = new System.Windows.Forms.PictureBox();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bgif)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(12)))), ((int)(((byte)(32)))));
            this.panelHead.Controls.Add(this.minimize);
            this.panelHead.Controls.Add(this.close);
            this.panelHead.Controls.Add(this.pictureBox1);
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(809, 32);
            this.panelHead.TabIndex = 0;
            this.panelHead.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHead_Paint);
            this.panelHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHead_MouseDown);
            this.panelHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHead_MouseMove);
            this.panelHead.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHead_MouseUp);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize.BackgroundImage")));
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Location = new System.Drawing.Point(730, 4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(31, 25);
            this.minimize.TabIndex = 4;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Location = new System.Drawing.Point(767, 4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(34, 25);
            this.close.TabIndex = 1;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // loginbtn
            // 
            this.loginbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.loginbtn.BackColor = System.Drawing.Color.Transparent;
            this.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.loginbtn.Location = new System.Drawing.Point(455, 321);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(72, 28);
            this.loginbtn.TabIndex = 35;
            this.loginbtn.Text = "Log In";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // CreateIcon
            // 
            this.CreateIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateIcon.BackColor = System.Drawing.Color.Transparent;
            this.CreateIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CreateIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateIcon.Image = ((System.Drawing.Image)(resources.GetObject("CreateIcon.Image")));
            this.CreateIcon.Location = new System.Drawing.Point(14, 401);
            this.CreateIcon.Name = "CreateIcon";
            this.CreateIcon.Size = new System.Drawing.Size(29, 25);
            this.CreateIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CreateIcon.TabIndex = 31;
            this.CreateIcon.TabStop = false;
            // 
            // creatLink
            // 
            this.creatLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.creatLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.creatLink.AutoSize = true;
            this.creatLink.BackColor = System.Drawing.Color.Transparent;
            this.creatLink.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatLink.LinkColor = System.Drawing.Color.Silver;
            this.creatLink.Location = new System.Drawing.Point(49, 410);
            this.creatLink.Name = "creatLink";
            this.creatLink.Size = new System.Drawing.Size(100, 16);
            this.creatLink.TabIndex = 34;
            this.creatLink.TabStop = true;
            this.creatLink.Text = "Create Account";
            this.creatLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creatLink_LinkClicked_1);
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Location = new System.Drawing.Point(268, 302);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(261, 20);
            this.password.TabIndex = 32;
            this.password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(265, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Password";
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Location = new System.Drawing.Point(268, 212);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(261, 20);
            this.username.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(265, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(308, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 37);
            this.label1.TabIndex = 27;
            this.label1.Text = "L  O  G  I  N";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Bgif
            // 
            this.Bgif.Image = global::LinkUs.Properties.Resources.network;
            this.Bgif.Location = new System.Drawing.Point(0, 26);
            this.Bgif.Name = "Bgif";
            this.Bgif.Size = new System.Drawing.Size(809, 449);
            this.Bgif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bgif.TabIndex = 36;
            this.Bgif.TabStop = false;
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.BackColor = System.Drawing.Color.Transparent;
            this.chkRemember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkRemember.FlatAppearance.BorderSize = 0;
            this.chkRemember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkRemember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRemember.ForeColor = System.Drawing.Color.Black;
            this.chkRemember.Location = new System.Drawing.Point(317, 334);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(12, 11);
            this.chkRemember.TabIndex = 37;
            this.chkRemember.UseVisualStyleBackColor = false;
            this.chkRemember.CheckedChanged += new System.EventHandler(this.chkRemember_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(333, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "Remember Login";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 473);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkRemember);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.CreateIcon);
            this.Controls.Add(this.creatLink);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.Bgif);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bgif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.PictureBox CreateIcon;
        private System.Windows.Forms.LinkLabel creatLink;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Bgif;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.Label label4;
    }
}

