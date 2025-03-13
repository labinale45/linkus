using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkUs
{
    public partial class account : UserControl

    {
        public static Image snUsr;
        public static string fullName = "";
        public static string userName = "";
        SqlConnection conn = new SqlConnection("Data Source=JUNOV;Initial Catalog=Linkus;Integrated Security=True");
        public account()
        {
            InitializeComponent();
            userDetails();
           
        }
        public void userDetails()
        {
            try {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from usr WHERE username = '" + LogIn.lusername + "'", conn);
                //cmd.Parameters.AddWithValue("@username", LogIn.lusername);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows) {
                    dr.Read();
                    userName = dr["username"].ToString();
                    fullName = dr["FullName"].ToString();
                    string gender = dr["Gender"].ToString();
                    string email = dr["Email"].ToString();
                    string address = dr["Address"].ToString();
                    string phone = dr["Phone"].ToString();
                    string dob = dr["dob"].ToString();

                    byte[] images = (byte[])dr["Image"];

                    usrName.Text = "(" + userName + ")";
                    ppLabel.Text = fullName;
                    contactLabel.Text = $"Gender: {gender}\nEmail: {email}\nAddress: {address}\nPhone: {phone}\nDOB: {dob}";
                    MemoryStream img = new MemoryStream(images);
                    snUsr = profile.Image = Image.FromStream(img);
                }
                conn.Close();
            }catch(Exception ex)
            {
                panel2.Controls.Clear();
                ppLabel.Text = "Error Loading user Details";
            }
            }
        private void uBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=JUNOV;Initial Catalog=Linkus;Integrated Security=True"))
                {
                    conn.Open();

                    string query1 = "update usr set Image=@image where username=@username";
                    SqlCommand ucmd = new SqlCommand(query1, conn);
                    MemoryStream imgM = new MemoryStream();
                    profile.Image.Save(imgM, profile.Image.RawFormat);
                    ucmd.Parameters.AddWithValue("@image", imgM.ToArray());
                    ucmd.Parameters.AddWithValue("@username", LogIn.lusername);

                    int rowsAffected = ucmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        uMsg.Text = "Successfully Updated";
                        userDetails();
                    }
                    else
                    {
                        uMsg.Text = "No records were updated.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed Updating: " + ex.Message);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void profile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "select Image(*Jpg; *.png; *Gif|*.Jpg;*png;*Gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                profile.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
    }

