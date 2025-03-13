namespace LinkUs
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.Head = new System.Windows.Forms.Panel();
            this.searchPanel = new CaraTex_Framework.CaraTexModernPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.subChannel = new System.Windows.Forms.Panel();
            this.addBtn = new System.Windows.Forms.Button();
            this.userList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.onlineRader = new CaraTexCirculerProgressbar();
            this.SChat = new System.Windows.Forms.RichTextBox();
            this.B_send = new System.Windows.Forms.Button();
            this.Pname = new System.Windows.Forms.Label();
            this.chatPanel = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.profile = new CaraTex_Framework.CaraTexCirculerImage();
            this.coverP = new System.Windows.Forms.PictureBox();
            this.Head.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.subChannel.SuspendLayout();
            this.chatPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverP)).BeginInit();
            this.SuspendLayout();
            // 
            // Head
            // 
            this.Head.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(12)))), ((int)(((byte)(32)))));
            this.Head.Controls.Add(this.searchPanel);
            this.Head.Location = new System.Drawing.Point(0, 0);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(275, 34);
            this.Head.TabIndex = 4;
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.White;
            this.searchPanel.BorderRaduis = 20;
            this.searchPanel.Controls.Add(this.pictureBox1);
            this.searchPanel.Controls.Add(this.searchBox);
            this.searchPanel.ForeColor = System.Drawing.Color.Black;
            this.searchPanel.GradientAngle = 90F;
            this.searchPanel.GradientBottomColor = System.Drawing.SystemColors.Control;
            this.searchPanel.GradientTopColor = System.Drawing.SystemColors.Control;
            this.searchPanel.Location = new System.Drawing.Point(4, 5);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(130, 23);
            this.searchPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LinkUs.Properties.Resources.search_50px1;
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.SystemColors.Control;
            this.searchBox.Location = new System.Drawing.Point(25, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(95, 20);
            this.searchBox.TabIndex = 0;
            // 
            // subChannel
            // 
            this.subChannel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.subChannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(12)))), ((int)(((byte)(32)))));
            this.subChannel.Controls.Add(this.addBtn);
            this.subChannel.Controls.Add(this.userList);
            this.subChannel.Controls.Add(this.label1);
            this.subChannel.Location = new System.Drawing.Point(0, 34);
            this.subChannel.Name = "subChannel";
            this.subChannel.Size = new System.Drawing.Size(138, 458);
            this.subChannel.TabIndex = 5;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 415);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(118, 23);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // userList
            // 
            this.userList.FormattingEnabled = true;
            this.userList.Location = new System.Drawing.Point(10, 27);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(120, 355);
            this.userList.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(34, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contacts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(12)))), ((int)(((byte)(32)))));
            this.panel1.Location = new System.Drawing.Point(138, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 34);
            this.panel1.TabIndex = 5;
            // 
            // onlineRader
            // 
            this.onlineRader.BackColor = System.Drawing.Color.Lime;
            this.onlineRader.ForeColor = System.Drawing.Color.Lime;
            this.onlineRader.Location = new System.Drawing.Point(776, 153);
            this.onlineRader.Name = "onlineRader";
            this.onlineRader.Size = new System.Drawing.Size(8, 8);
            this.onlineRader.TabIndex = 9;
            this.onlineRader.Text = "caraTexCirculerProgressbar1";
            // 
            // SChat
            // 
            this.SChat.Location = new System.Drawing.Point(17, 408);
            this.SChat.Name = "SChat";
            this.SChat.Size = new System.Drawing.Size(411, 27);
            this.SChat.TabIndex = 0;
            this.SChat.Text = "";
            // 
            // B_send
            // 
            this.B_send.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.B_send.FlatAppearance.BorderSize = 3;
            this.B_send.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.B_send.Location = new System.Drawing.Point(434, 409);
            this.B_send.Name = "B_send";
            this.B_send.Size = new System.Drawing.Size(66, 23);
            this.B_send.TabIndex = 1;
            this.B_send.Text = "Send";
            this.B_send.UseVisualStyleBackColor = true;
            // 
            // Pname
            // 
            this.Pname.AutoSize = true;
            this.Pname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pname.Location = new System.Drawing.Point(743, 164);
            this.Pname.Name = "Pname";
            this.Pname.Size = new System.Drawing.Size(91, 15);
            this.Pname.TabIndex = 11;
            this.Pname.Text = "Profile Name";
            this.Pname.Click += new System.EventHandler(this.Pname_Click);
            // 
            // chatPanel
            // 
            this.chatPanel.Controls.Add(this.webBrowser1);
            this.chatPanel.Controls.Add(this.B_send);
            this.chatPanel.Controls.Add(this.SChat);
            this.chatPanel.Location = new System.Drawing.Point(144, 40);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Size = new System.Drawing.Size(519, 439);
            this.chatPanel.TabIndex = 13;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(17, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(483, 384);
            this.webBrowser1.TabIndex = 2;
            // 
            // profile
            // 
            this.profile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.profile.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.profile.BorderColor = System.Drawing.Color.Transparent;
            this.profile.BorderColor2 = System.Drawing.Color.Transparent;
            this.profile.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.profile.BorderSize = 2;
            this.profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile.GradientAngle = 50F;
            this.profile.Image = global::LinkUs.Properties.Resources.profile_pic__12_;
            this.profile.Location = new System.Drawing.Point(686, 97);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(75, 75);
            this.profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profile.TabIndex = 7;
            this.profile.TabStop = false;
            // 
            // coverP
            // 
            this.coverP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coverP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coverP.Image = global::LinkUs.Properties.Resources.pp;
            this.coverP.Location = new System.Drawing.Point(669, 33);
            this.coverP.Name = "coverP";
            this.coverP.Size = new System.Drawing.Size(230, 114);
            this.coverP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverP.TabIndex = 8;
            this.coverP.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(897, 491);
            this.Controls.Add(this.chatPanel);
            this.Controls.Add(this.Pname);
            this.Controls.Add(this.onlineRader);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.subChannel);
            this.Controls.Add(this.Head);
            this.Controls.Add(this.coverP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "main";
            this.Head.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.subChannel.ResumeLayout(false);
            this.subChannel.PerformLayout();
            this.chatPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coverP;
        private System.Windows.Forms.Panel Head;
        private System.Windows.Forms.Panel subChannel;
        private System.Windows.Forms.Panel panel1;
        private CaraTex_Framework.CaraTexCirculerImage profile;
        private CaraTexCirculerProgressbar onlineRader;
        private CaraTex_Framework.CaraTexModernPanel searchPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox SChat;
        private System.Windows.Forms.Button B_send;
        private System.Windows.Forms.Label Pname;
        private System.Windows.Forms.Panel chatPanel;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.Button addBtn;
    }
}