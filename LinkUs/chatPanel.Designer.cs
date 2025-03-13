namespace LinkUs
{
    partial class chatPanel
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
            this.contactPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.contact2 = new LinkUs.contact();
            this.subChannel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Head = new System.Windows.Forms.Panel();
            this.searchPanel = new CaraTex_Framework.CaraTexModernPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.msgBox = new System.Windows.Forms.Panel();
            this.profile = new CaraTex_Framework.CaraTexCirculerImage();
            this.fDetail = new System.Windows.Forms.Panel();
            this.fName = new System.Windows.Forms.Label();
            this.bioLabel = new System.Windows.Forms.Label();
            this.uName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cfPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.B_send = new System.Windows.Forms.Button();
            this.SChat = new System.Windows.Forms.RichTextBox();
            this.contactPanel.SuspendLayout();
            this.subChannel.SuspendLayout();
            this.Head.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.msgBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            this.fDetail.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactPanel
            // 
            this.contactPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.contactPanel.Controls.Add(this.contact2);
            this.contactPanel.Location = new System.Drawing.Point(5, 41);
            this.contactPanel.Name = "contactPanel";
            this.contactPanel.Size = new System.Drawing.Size(120, 352);
            this.contactPanel.TabIndex = 5;
            // 
            // contact2
            // 
            this.contact2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(81)))), ((int)(((byte)(114)))));
            this.contact2.icon = null;
            this.contact2.Location = new System.Drawing.Point(3, 3);
            this.contact2.Name = "contact2";
            this.contact2.ptitle = null;
            this.contact2.Size = new System.Drawing.Size(112, 46);
            this.contact2.TabIndex = 0;
            this.contact2.Click += new System.EventHandler(this.contact2_Click);
            // 
            // subChannel
            // 
            this.subChannel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.subChannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(12)))), ((int)(((byte)(32)))));
            this.subChannel.Controls.Add(this.contactPanel);
            this.subChannel.Controls.Add(this.label1);
            this.subChannel.Location = new System.Drawing.Point(0, 33);
            this.subChannel.Name = "subChannel";
            this.subChannel.Size = new System.Drawing.Size(138, 458);
            this.subChannel.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(35, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contacts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Head
            // 
            this.Head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(12)))), ((int)(((byte)(32)))));
            this.Head.Controls.Add(this.searchPanel);
            this.Head.Location = new System.Drawing.Point(0, -1);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(138, 34);
            this.Head.TabIndex = 17;
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
            this.searchPanel.Location = new System.Drawing.Point(5, 5);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(130, 23);
            this.searchPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LinkUs.Properties.Resources.search_50px1;
            this.pictureBox1.Location = new System.Drawing.Point(7, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.SystemColors.Control;
            this.searchBox.Location = new System.Drawing.Point(26, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(95, 20);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged_1);
            // 
            // msgBox
            // 
            this.msgBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msgBox.Controls.Add(this.profile);
            this.msgBox.Controls.Add(this.fDetail);
            this.msgBox.Controls.Add(this.panel2);
            this.msgBox.Controls.Add(this.panel3);
            this.msgBox.Location = new System.Drawing.Point(138, 0);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(619, 458);
            this.msgBox.TabIndex = 18;
            // 
            // profile
            // 
            this.profile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.profile.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.profile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(12)))), ((int)(((byte)(32)))));
            this.profile.BorderColor2 = System.Drawing.Color.Transparent;
            this.profile.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.profile.BorderSize = 2;
            this.profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile.GradientAngle = 50F;
            this.profile.Image = global::LinkUs.Properties.Resources.profile_pic__12_;
            this.profile.Location = new System.Drawing.Point(394, 63);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(91, 91);
            this.profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profile.TabIndex = 47;
            this.profile.TabStop = false;
            // 
            // fDetail
            // 
            this.fDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(72)))), ((int)(((byte)(102)))));
            this.fDetail.Controls.Add(this.fName);
            this.fDetail.Controls.Add(this.bioLabel);
            this.fDetail.Controls.Add(this.uName);
            this.fDetail.Controls.Add(this.label2);
            this.fDetail.Location = new System.Drawing.Point(383, 139);
            this.fDetail.Name = "fDetail";
            this.fDetail.Size = new System.Drawing.Size(236, 315);
            this.fDetail.TabIndex = 48;
            // 
            // fName
            // 
            this.fName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fName.AutoSize = true;
            this.fName.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.ForeColor = System.Drawing.SystemColors.Control;
            this.fName.Location = new System.Drawing.Point(5, 74);
            this.fName.MaximumSize = new System.Drawing.Size(230, 0);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(52, 16);
            this.fName.TabIndex = 45;
            this.fName.Text = "PPname";
            // 
            // bioLabel
            // 
            this.bioLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bioLabel.AutoSize = true;
            this.bioLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bioLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.bioLabel.Location = new System.Drawing.Point(9, 128);
            this.bioLabel.MaximumSize = new System.Drawing.Size(230, 0);
            this.bioLabel.Name = "bioLabel";
            this.bioLabel.Size = new System.Drawing.Size(87, 14);
            this.bioLabel.TabIndex = 44;
            this.bioLabel.Text = "About the user ";
            // 
            // uName
            // 
            this.uName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uName.AutoSize = true;
            this.uName.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uName.ForeColor = System.Drawing.SystemColors.Control;
            this.uName.Location = new System.Drawing.Point(5, 43);
            this.uName.MaximumSize = new System.Drawing.Size(230, 0);
            this.uName.Name = "uName";
            this.uName.Size = new System.Drawing.Size(40, 16);
            this.uName.TabIndex = 42;
            this.uName.Text = "label1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(5, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "About:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(12)))), ((int)(((byte)(32)))));
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 34);
            this.panel2.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel3.Controls.Add(this.cfPanel);
            this.panel3.Controls.Add(this.B_send);
            this.panel3.Controls.Add(this.SChat);
            this.panel3.Location = new System.Drawing.Point(-27, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(471, 422);
            this.panel3.TabIndex = 41;
            // 
            // cfPanel
            // 
            this.cfPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cfPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(72)))), ((int)(((byte)(102)))));
            this.cfPanel.Location = new System.Drawing.Point(34, 6);
            this.cfPanel.Name = "cfPanel";
            this.cfPanel.Size = new System.Drawing.Size(403, 366);
            this.cfPanel.TabIndex = 2;
            // 
            // B_send
            // 
            this.B_send.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.B_send.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.B_send.FlatAppearance.BorderSize = 3;
            this.B_send.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.B_send.Location = new System.Drawing.Point(371, 382);
            this.B_send.Name = "B_send";
            this.B_send.Size = new System.Drawing.Size(66, 23);
            this.B_send.TabIndex = 1;
            this.B_send.Text = "Send";
            this.B_send.UseVisualStyleBackColor = true;
            this.B_send.Click += new System.EventHandler(this.B_send_Click_1);
            // 
            // SChat
            // 
            this.SChat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SChat.Location = new System.Drawing.Point(34, 378);
            this.SChat.Name = "SChat";
            this.SChat.Size = new System.Drawing.Size(320, 27);
            this.SChat.TabIndex = 0;
            this.SChat.Text = "";
            // 
            // chatPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.Head);
            this.Controls.Add(this.subChannel);
            this.Name = "chatPanel";
            this.Size = new System.Drawing.Size(820, 491);
            this.contactPanel.ResumeLayout(false);
            this.subChannel.ResumeLayout(false);
            this.subChannel.PerformLayout();
            this.Head.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.msgBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            this.fDetail.ResumeLayout(false);
            this.fDetail.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel contactPanel;
       // private contact contact1;
        private System.Windows.Forms.Panel subChannel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Head;
        private CaraTex_Framework.CaraTexModernPanel searchPanel;
        private System.Windows.Forms.TextBox searchBox;
        private contact contact1;
        private contact contact2;
        private System.Windows.Forms.Panel msgBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel cfPanel;
        private System.Windows.Forms.Button B_send;
        private System.Windows.Forms.RichTextBox SChat;
        private CaraTex_Framework.CaraTexCirculerImage profile;
        private System.Windows.Forms.Panel fDetail;
        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.Label bioLabel;
        private System.Windows.Forms.Label uName;
        private System.Windows.Forms.Label label2;
    }
}
