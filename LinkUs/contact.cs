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
    public partial class contact : UserControl
    {

        public static string cName ="";
        public contact()
        {
            InitializeComponent();
        }

        private string title;

        public string ptitle
        {
            get { return title; }
            set
            {
                cName = value;
                title = value; contactName.Text = cName;
            } 
        }

        private Image _icon;

        public Image icon
        {
            get { return _icon; }
            set { _icon = value; profile.Image = value; }
        }

        private void contactName_Click(object sender, EventArgs e)
        {

        }

        private void contact_Load(object sender, EventArgs e)
        {

        }

        private void profile_Click(object sender, EventArgs e)
        {

        }
    }
}
