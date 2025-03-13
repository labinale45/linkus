using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppApi;
using System.Windows.Forms.VisualStyles;
namespace LinkUs
{
    public partial class Home : Form
    {
        bool drag = false;
        Point startPoint = new Point(0, 0);
        public Home()
        {
            InitializeComponent();
            this.CenterToScreen();
            lgP.Visible = false;
            wcUser.Text = LogIn.lusername.Trim();
            pictureBox1.Image = account.snUsr;
            chatPanel1.Visible=false;
            account1.Visible=false;
            
         }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void topBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void topBar_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void topBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void topBar_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }


        private void logoHome_Click(object sender, EventArgs e)
        {
            if (chatPanel1.Visible == false)
            {
                
                chatPanel1.BringToFront();
                chatPanel1.Visible = true;
            }
            else
            {
                chatPanel1.Visible = false;
            }
            

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void wcUser_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (lgP.Visible == false)
            {
                lgP.Visible = true;
                lgP.BringToFront();

                
            }
            else
            {
                lgP.Visible = false;
            }
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void acc_Click(object sender, EventArgs e)
        {

            if (account1.Visible == false)
            {
                account1.Visible = true;
                account1.BringToFront();
                Home hobj = new Home();
                hobj.Enabled = false;
            }
            else {
                account1.Visible = false;
                  Home hobj = new Home();
                hobj.Enabled = true;
            }

        }

        private void chatPanel1_Load(object sender, EventArgs e)
        {
            
        }
    }
    } 

