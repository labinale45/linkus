using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkUs
{
    public partial class chatBox : UserControl
    {     
        public chatBox()
        {
            InitializeComponent();
        }
        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value; cbLabel.Text = value;
            }
        }

        private Image _icon;

        public Image icon
        {
            get { return _icon; }
            set { _icon = value; cProfile.Image = value; AddHeighttext(); }
        }
        void AddHeighttext()
        {
            chatBox cb = new chatBox();
            cb.BringToFront();
            cbLabel.Height = uiList.GeTTextHeight(cbLabel) + 10;
            cb.Height = cbLabel.Top + cbLabel.Height;
            this.Height = cb.Bottom + 10;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void chatBox_Load(object sender, EventArgs e)
        {
            AddHeighttext(); 
        }
    }
}
