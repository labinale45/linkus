using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.Win32;

namespace LinkUs
{
    public partial class SignUp : Form
    {
        //   MySqlConnection conn=new MySqlConnection("server=localhost;port=3306;username=root;password=;database=linkus");
       
        public SignUp()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        SqlConnection conn = new SqlConnection("Data Source=JUNOV;Initial Catalog=Linkus;Integrated Security=True");

        private void SignUp_Load(object sender, EventArgs e)
        {
            signUpbtn.Parent = Bgif;
            label1.Parent = Bgif;
            label2.Parent = Bgif;
            label3.Parent = Bgif;
            label4.Parent = Bgif;
            label5.Parent = Bgif;
            label6.Parent = Bgif;
            label7.Parent = Bgif;
            label8.Parent = Bgif;
            label9.Parent = Bgif;
            logo.Parent = Bgif;
            haveAccount.Parent = Bgif;
            dateOfBirth.Parent = Bgif;
            profile.Parent = Bgif;
        }
        
        public void login()
        {
            LogIn obj = new LogIn();
            this.Hide();
            obj.ShowDialog();
        }
        private void haveAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login();
        }

        private void Bgif_Click(object sender, EventArgs e)
        {

        }


        //Generating verification code
          string verification_code = $"{DateTime.Now.Second}{DateTime.Now.Millisecond}";


        //SignUp
        private void signUpbtn_Click(object sender, EventArgs e)
        {
            try
            {
               
                //Open connection 
                conn.Open();


                //create variable
                string usrname = userName.Text;
                string fname = fullName.Text;
                String mail = email.Text;
                string pass = password.Text;
                string confirmpass = cpassword.Text;
                string gen = gender.Text;
                string phone = contact.Text;
                string address = adres.Text;
                string dateBirth = date.Value.ToLongDateString();

                //Age abstraction
                DateTime bdate = Convert.ToDateTime(dateBirth);
                DateTime today = DateTime.Today;


                int Age = today.Year - bdate.Year;

                //Email Validation
                var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)$";
                var emailv = new Regex(pattern);
                var valid = emailv.IsMatch(mail)?"true":"false";

                //number validation
                var callP = @"(\+977?)?[9][6-9]\d{8}";
                var callv=new Regex(callP);
                var cValid= callv.IsMatch(phone)?"true":"false";

                //conditions
                if (usrname == "" || fname == "" || mail == "" || pass == "" || gen == "" || phone == "" || dateBirth == "")
                {
                    MessageBox.Show("Please Fill up the empty fields", "Missing Information");
                    conn.Close();
                }
                else if (confirmpass != pass)
                {
                    MessageBox.Show("Password not matched", "Password error");
                    cpassword.Text = null;
                    cpassword.Focus();
                    conn.Close();
                }
                else if (Age < 18)
                {
                    MessageBox.Show("Your are too young to be here ..", "Age validation");
                    date.Focus();
                    conn.Close();
                }
                else if (valid == "false")
                {
                    MessageBox.Show("Please enter valid Email", "Email validation");
                    conn.Close();
                }
                else if (cValid == "false")
                {
                    MessageBox.Show("Please enter valid Phone Number", "Contact validation");
                    conn.Close();
                }
               
                else
                {
                    // Email Verification
                    timer.Stop();
                    string to, from, passw, gmail;

                    to = mail;
                    from = "np.linkus@gmail.com"; //myemail
                    gmail = verification_code;
                    passw = "trpwxjerlafxrlnd";//emailpass  

                    MailMessage message = new MailMessage();
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Subject = "LinkUS Verification Code";
                    message.Body = gmail;

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential(from, passw);
                    try
                    {

                        //sent OTP code
                        smtp.Send(message);
                        MessageBox.Show("Ceck Your Email to verify", "Verification Code sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string emailVerification = Interaction.InputBox("Enter verification code :", "Email Verification");

                        if (emailVerification == gmail)
                        {
                            // creating query
                            string Query = "insert into usr(username,FullName,Email,Password,Gender,Address,Phone,dob,Age,Image)values(@usrName,@fullName,@email,@pass,@gender,@address,@phone,@dob,@age,@image)";
                            //MemoryStream ms = new MemoryStream();
                            SqlCommand cmd = new SqlCommand(Query,conn);
                            cmd.Parameters.AddWithValue("@usrName", userName.Text);
                            cmd.Parameters.AddWithValue("@fullName",  fullName.Text);
                            cmd.Parameters.AddWithValue("@email",  email.Text);
                            cmd.Parameters.AddWithValue("@pass", password.Text);
                            cmd.Parameters.AddWithValue("@gender",   gender.Text);
                            cmd.Parameters.AddWithValue("@address", address);
                            cmd.Parameters.AddWithValue("@phone", contact.Text);
                            cmd.Parameters.AddWithValue("@dob", dateBirth);
                            cmd.Parameters.AddWithValue("@age", Age);
                            MemoryStream imgM = new MemoryStream();
                            profile.Image.Save(imgM, profile.Image.RawFormat);
                            cmd.Parameters.AddWithValue("@image", imgM.ToArray());

                            cmd.ExecuteNonQuery();

                            conn.Close();
                            login();

                    /*        userName.Clear();
                            fullName.Clear();
                            email.Clear();
                            password.Clear();
                            gender.SelectedValue = null;
                            adres.Clear();
                            contact.Clear();
                            date.Value = default;*/
                        }
                        else if (emailVerification == "" || emailVerification != gmail)
                        {
                            MessageBox.Show("Invalid Code", "Invalid");
                            conn.Close();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         conn.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
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
