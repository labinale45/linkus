using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Xml.Serialization;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using static System.Windows.Forms.LinkLabel;

namespace LinkUs
{
    public partial class LogIn : Form
    {
        //connection mysqldbs
        //MySqlConnection conn =new MySqlConnection("server=localhost;port=3306;username=root;password=;database=linkus");
        SqlConnection conn = new SqlConnection("Data Source = JUNOV; Initial Catalog = Linkus; Integrated Security = True");


        //top dock properties
        bool drag = false;
        Point startPoint = new Point(0, 0);
        public static string lusername = "";
      


        public LogIn()
        {
            InitializeComponent();
            this.CenterToScreen();
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = Bgif;
            label2.Parent = Bgif;
            label3.Parent = Bgif;
            label4.Parent = Bgif;
            loginbtn.Parent = Bgif;
            creatLink.Parent = Bgif;
            CreateIcon.Parent = Bgif;
            chkRemember.Parent = Bgif;

            
            if(Properties.Settings.Default.Remember)
            {
                username.Text = Properties.Settings.Default.PhoneNumber;
                password.Text = Properties.Settings.Default.Password;
                chkRemember.Checked = Properties.Settings.Default.Remember;
            }

        }


        private void panelHead_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panelHead_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void panelHead_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void maximize_Click(object sender, EventArgs e)
        //{
        //    if (WindowState == FormWindowState.Normal)
        //    {
        //        WindowState = FormWindowState.Maximized;
        //    }
        //    else
        //    {
        //        WindowState = FormWindowState.Normal;
        //    }

        //}

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //signup
        public void signup()
        {
            SignUp obj = new SignUp();
            this.Hide();
            obj.Show();
        }
        //Home
        public void home()
        {
            Home hObj = new Home();
            this.Hide();
            hObj.Show();
            
        }
        private void creatLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup(); 
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                conn.Open();

                lusername = username.Text;
                string lpass = password.Text.Trim();

                string selectQuery = "SELECT * FROM usr WHERE username ='"+lusername+"' AND Password ='"+lpass+"'";
                SqlCommand cmd = new SqlCommand(selectQuery,conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (lusername==""||lpass=="")
                {
                    MessageBox.Show("Username Or Password missing!","Empty fields");
                }
                else if (reader.Read())
                {
                    home();    
                }
                else
                {
                    MessageBox.Show("Incorrect username OR Password", "Error loging in !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not connected to database","Error");
            }
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelHead_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkRemember_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Remember = chkRemember.Checked;
            Properties.Settings.Default.PhoneNumber = username.Text;
            Properties.Settings.Default.Password = password.Text;
            Properties.Settings.Default.Save();
        }
    }
}
