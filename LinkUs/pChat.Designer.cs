namespace LinkUs
{
    partial class pChat
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
            this.cBox = new System.Windows.Forms.Label();
            this.cProfile = new CaraTex_Framework.CaraTexCirculerImage();
            ((System.ComponentModel.ISupportInitialize)(this.cProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // cBox
            // 
            this.cBox.AutoSize = true;
            this.cBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox.ForeColor = System.Drawing.SystemColors.Control;
            this.cBox.Location = new System.Drawing.Point(48, 10);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(38, 16);
            this.cBox.TabIndex = 2;
            this.cBox.Text = "label1";
            // 
            // cProfile
            // 
            this.cProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cProfile.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.cProfile.BorderColor = System.Drawing.Color.Transparent;
            this.cProfile.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(81)))), ((int)(((byte)(114)))));
            this.cProfile.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.cProfile.BorderSize = 2;
            this.cProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cProfile.GradientAngle = 50F;
            this.cProfile.Image = global::LinkUs.Properties.Resources.profile_pic__12_;
            this.cProfile.Location = new System.Drawing.Point(1, -1);
            this.cProfile.Name = "cProfile";
            this.cProfile.Size = new System.Drawing.Size(41, 41);
            this.cProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cProfile.TabIndex = 9;
            this.cProfile.TabStop = false;
            // 
            // pChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(12)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.cProfile);
            this.Controls.Add(this.cBox);
            this.Name = "pChat";
            this.Size = new System.Drawing.Size(403, 41);
            this.Load += new System.EventHandler(this.pChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cBox;
        private CaraTex_Framework.CaraTexCirculerImage cProfile;
    }
}
