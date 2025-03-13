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
    public partial class pChat : UserControl
    {
        public pChat()
        {
            InitializeComponent();
        }

        private string title;
        public string Title
        {
            get 
            { 
                return title; 
            } 
            set
            {
                title = value; cBox.Text = value;
            }
            }

        private Image _icon;
        public Image icon
        {
            get
            {
                return _icon;
            }
            set
            {
                _icon = value; cProfile.Image = value; AddHeighttext();
            }
        }
        void AddHeighttext()
        {
            pChat cb = new pChat();
            cb.BringToFront();
            cBox.Height = uiList.GeTTextHeight(cBox) + 10;
            cb.Height = cBox.Top + cBox.Height;
            this.Height = cb.Bottom + 10;
        }

        private void pChat_Load(object sender, EventArgs e)
        {
            AddHeighttext(); 
        }
    }
}
