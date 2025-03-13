using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LinkUs
{
    public partial class profile : UserControl
    {
       // public static string fullName = "";
       // SqlConnection conn = new SqlConnection("Data Source=JUNOV;Initial Catalog=Linkus;Integrated Security=True");
        public profile()
        {
            InitializeComponent();
           // userDetails();
        }

       /* public void userDetails()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from usr WHERE username = '" + LogIn.lusername + "'", conn);
            //cmd.Parameters.AddWithValue("@username", LogIn.lusername);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            fullName = dr["FullName"].ToString();
            string gender = dr["Gender"].ToString();
            string email = dr["Email"].ToString();
            string address = dr["Address"].ToString();
            string phone = dr["Phone"].ToString();
            string dob = dr["dob"].ToString();


            ppLabel.Text = fullName;
            contactLabel.Text = $"Gender: {gender}\nEmail: {email}\nAddress: {address}\nPhone:{phone}\nDOB: {dob}";

            conn.Close();
        }*/
    }
}
