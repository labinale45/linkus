namespace LinkUs
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.channelPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoHome = new System.Windows.Forms.PictureBox();
            this.wcUser = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.lgP = new System.Windows.Forms.Panel();
            this.LogOut = new System.Windows.Forms.Label();
            this.acc = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.topBar = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Button();
            this.maximize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.account1 = new LinkUs.account();
            this.chatPanel1 = new LinkUs.chatPanel();
            this.channelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.bodyPanel.SuspendLayout();
            this.lgP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // channelPanel
            // 
            this.channelPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.channelPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.channelPanel.Controls.Add(this.pictureBox1);
            this.channelPanel.Controls.Add(this.logoHome);
            this.channelPanel.Controls.Add(this.wcUser);
            this.channelPanel.Location = new System.Drawing.Point(0, 24);
            this.channelPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.channelPanel.Name = "channelPanel";
            this.channelPanel.Size = new System.Drawing.Size(59, 485);
            this.channelPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::LinkUs.Properties.Resources.male_user_50px;
            this.pictureBox1.Location = new System.Drawing.Point(13, 423);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // logoHome
            // 
            this.logoHome.BackgroundImage = global::LinkUs.Properties.Resources.lo;
            this.logoHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoHome.Location = new System.Drawing.Point(13, 15);
            this.logoHome.Name = "logoHome";
            this.logoHome.Size = new System.Drawing.Size(37, 42);
            this.logoHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoHome.TabIndex = 1;
            this.logoHome.TabStop = false;
            this.logoHome.Click += new System.EventHandler(this.logoHome_Click);
            // 
            // wcUser
            // 
            this.wcUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.wcUser.AutoSize = true;
            this.wcUser.BackColor = System.Drawing.Color.Transparent;
            this.wcUser.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wcUser.ForeColor = System.Drawing.SystemColors.Control;
            this.wcUser.Location = new System.Drawing.Point(8, 461);
            this.wcUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wcUser.Name = "wcUser";
            this.wcUser.Size = new System.Drawing.Size(0, 14);
            this.wcUser.TabIndex = 1;
            this.wcUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wcUser.Click += new System.EventHandler(this.wcUser_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // bodyPanel
            // 
            this.bodyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(81)))), ((int)(((byte)(114)))));
            this.bodyPanel.Controls.Add(this.lgP);
            this.bodyPanel.Controls.Add(this.account1);
            this.bodyPanel.Controls.Add(this.chatPanel1);
            this.bodyPanel.Controls.Add(this.logo);
            this.bodyPanel.Location = new System.Drawing.Point(59, 27);
            this.bodyPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(885, 483);
            this.bodyPanel.TabIndex = 4;
            // 
            // lgP
            // 
            this.lgP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lgP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.lgP.Controls.Add(this.LogOut);
            this.lgP.Controls.Add(this.acc);
            this.lgP.Location = new System.Drawing.Point(-1, 418);
            this.lgP.Name = "lgP";
            this.lgP.Size = new System.Drawing.Size(68, 65);
            this.lgP.TabIndex = 1;
            this.lgP.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LogOut
            // 
            this.LogOut.AutoSize = true;
            this.LogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(81)))), ((int)(((byte)(114)))));
            this.LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOut.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.Location = new System.Drawing.Point(4, 35);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(61, 18);
            this.LogOut.TabIndex = 0;
            this.LogOut.Text = "Log Out";
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // acc
            // 
            this.acc.AutoSize = true;
            this.acc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(81)))), ((int)(((byte)(114)))));
            this.acc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acc.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acc.Location = new System.Drawing.Point(3, 14);
            this.acc.Name = "acc";
            this.acc.Size = new System.Drawing.Size(62, 18);
            this.acc.TabIndex = 1;
            this.acc.Text = "Account";
            this.acc.Click += new System.EventHandler(this.acc_Click);
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = global::LinkUs.Properties.Resources.LinkUs;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logo.Location = new System.Drawing.Point(4, 87);
            this.logo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(873, 325);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Link US";
            // 
            // topBar
            // 
            this.topBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.topBar.Controls.Add(this.minimize);
            this.topBar.Controls.Add(this.label1);
            this.topBar.Controls.Add(this.maximize);
            this.topBar.Controls.Add(this.close);
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(944, 33);
            this.topBar.TabIndex = 0;
            this.topBar.Paint += new System.Windows.Forms.PaintEventHandler(this.topBar_Paint);
            this.topBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseDown);
            this.topBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseMove);
            this.topBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseUp);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize.BackgroundImage")));
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.minimize.Location = new System.Drawing.Point(847, 3);
            this.minimize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(30, 18);
            this.minimize.TabIndex = 5;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // maximize
            // 
            this.maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize.BackColor = System.Drawing.Color.Transparent;
            this.maximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maximize.BackgroundImage")));
            this.maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.maximize.FlatAppearance.BorderSize = 0;
            this.maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.maximize.Location = new System.Drawing.Point(881, 3);
            this.maximize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maximize.Name = "maximize";
            this.maximize.Size = new System.Drawing.Size(30, 18);
            this.maximize.TabIndex = 4;
            this.maximize.UseVisualStyleBackColor = false;
            this.maximize.Click += new System.EventHandler(this.maximize_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.close.Location = new System.Drawing.Point(910, 2);
            this.close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 18);
            this.close.TabIndex = 3;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // account1
            // 
            this.account1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.account1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.account1.Location = new System.Drawing.Point(214, -2);
            this.account1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.account1.Name = "account1";
            this.account1.Size = new System.Drawing.Size(456, 482);
            this.account1.TabIndex = 4;
            // 
            // chatPanel1
            // 
            this.chatPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatPanel1.Location = new System.Drawing.Point(0, 0);
            this.chatPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chatPanel1.Name = "chatPanel1";
            this.chatPanel1.Size = new System.Drawing.Size(885, 483);
            this.chatPanel1.TabIndex = 5;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 509);
            this.Controls.Add(this.channelPanel);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.topBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Home";
            this.Text = "Link US";
            this.Load += new System.EventHandler(this.Home_Load);
            this.channelPanel.ResumeLayout(false);
            this.channelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.bodyPanel.ResumeLayout(false);
            this.lgP.ResumeLayout(false);
            this.lgP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel channelPanel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label wcUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button maximize;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logoHome;
        private System.Windows.Forms.Panel lgP;
        private System.Windows.Forms.Label acc;
        private System.Windows.Forms.Label LogOut;
        private account account1;
        private chatPanel chatPanel1;
        //  private friends friends1;
        // private chatPanel chatPanel1;
    }
}