using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System.Windows.Media;
using WhatsAppApi;
using System.Data.SqlClient;

namespace LinkUs
{
    public partial class Trial : Form
    {
        public static string fullName = "Rabin Ale";
        SqlConnection conn = new SqlConnection("Data Source=JUNOV;Initial Catalog=Linkus;Integrated Security=True");
        public Trial()
        {
            InitializeComponent();
            userDetails();
   
        }

        private void Trial_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void userDetails()
        {
            conn.Open();
            string ret = "select * from usr WHERE username ='"+LogIn.lusername+"'";
            SqlCommand cmd = new SqlCommand(ret, conn);
            //cmd.Parameters.AddWithValue("@username", LogIn.lusername);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.Read())
            {
                fullName = dr["FullName"].ToString();
                string gender = dr["Gender"].ToString();
                string email = dr["Email"].ToString();
                string address = dr["Address"].ToString();
                string phone = dr["Phone"].ToString();
                string dob = dr["dob"].ToString();

                label1.Text=fullName;
              //  ppLabel.Text = fullName;
                // contactLabel.Text = $"Gender: {gender}\nEmail: {email}\nAddress: {address}\nPhone:{phone}\nDOB: {dob}";
            }
            conn.Close();
        }

        // string verification_code = $"{DateTime.Now.Second}{DateTime.Now.Millisecond}";

        private void send_Click(object sender, EventArgs e)
        {/*
            timer1.Stop();
            *//*     if( WhatsAppApi.Register.WhatsRegisterV2.RequestCode(gmail.Text, out string password, "sms"))
                 {
                     MessageBox.Show("success");
                 }
                 else {
                     MessageBox.Show("failed");
                 }*//*

            string to, from, pass, mail;
            to = gmail.Text;
            mail = verification_code;
            from = "np.linkus@gmail.com";
            pass = "trpwxjerlafxrlnd";//    ymoghcndwawbgdlq
            MailMessage msg = new MailMessage();
            msg.To.Add(new MailAddress(to));
            msg.From = new MailAddress(from);
            msg.Subject = "Validation Code";
            msg.Body = mail;
            msg.IsBodyHtml = true;
            var SmtpClient = new SmtpClient("smtp.gmail.com")
            {

                EnableSsl = true,
                Port = 587,
                UseDefaultCredentials = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new System.Net.NetworkCredential(from, pass),
            };*/

            try
            {

           
            }
                /*// SmtpClient.TargetName="STARTTLS/smtp.gmail.com";
                SmtpClient.Send(msg);
                // SmtpClient.SendMailAsync(msg);

                MessageBox.Show("Email sent");
                MessageBox.Show("Check Your Email to verify", "Verification Code sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string emailVerification = Interaction.InputBox("Enter verification code :", "Email Verification");
                while (emailVerification == mail)
                {
                    MessageBox.Show("Login", "valid", MessageBoxButtons.OK);
                }*//*
            }*/
            catch (Exception xhr)
            {
                MessageBox.Show(xhr.Message);
            }
        }
    }
}


