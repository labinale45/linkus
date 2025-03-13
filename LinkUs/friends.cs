using Microsoft.VisualBasic;
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
using System.Windows.Documents;
using System.Windows.Forms;

namespace LinkUs
{
    public partial class friends : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=JUNOV;Initial Catalog=Linkus;Integrated Security=True");

        public friends()
        {
            InitializeComponent();
            UserItem();
            msgBox.Visible = false;

        }
        private void UserItem()
        {
            contactPanel.Controls.Clear();
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select * from usr", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table != null)
            {
                if (table.Rows.Count > 0)
                {
                    contact[] contacts = new contact[table.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            contacts[i] = new contact();
                            MemoryStream stream = new MemoryStream((byte[])row["image"]);
                            contacts[i].icon = new Bitmap(stream);
                            contacts[i].ptitle = row["username"].ToString();
                            if (contacts[i].ptitle == account.userName)
                            {
                                contactPanel.Controls.Remove(contacts[i]);
                            }
                            else
                            {
                                contactPanel.Controls.Add(contacts[i]);
                            }
                            contacts[i].Click += new System.EventHandler(this.contact2_Click);

                        }
                    }

                }
            }
        }



        private void contact2_Click(object sender, EventArgs e)
        {
            if (msgBox.Visible == false)
            {
                msgBox.Visible = true;
            }

            contact ctrl = (contact)sender;
            uName.Text = ctrl.ptitle;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from usr WHERE username = '" + ctrl.ptitle + "'", conn);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    string userName = dr["username"].ToString();
                    string fullName = dr["FullName"].ToString();
                    string gender = dr["Gender"].ToString();
                    string email = dr["Email"].ToString();
                    string address = dr["Address"].ToString();
                    string phone = dr["Phone"].ToString();
                    string dob = dr["dob"].ToString();
                    byte[] images = (byte[])dr["Image"];

                    fName.Text = "Full Name : " + fullName;
                    bioLabel.Text = $"Email: {email}\nAddress: {address}\nPhone:{phone}\nDOB: {dob}";
                    MemoryStream img = new MemoryStream(images);
                    profile.Image = Image.FromStream(img);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                fDetail.Controls.Clear();
                bioLabel.Text = "Error Loading user Details ";
            }
            MesssageChat();
        }

        private void B_send_Click_1(object sender, EventArgs e)
        {
            cfPanel.Controls.Clear();
            string query = "insert into chat(userOne,userTwo,message)values(@usrOne,@usrTwo,@msg)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@msg", SChat.Text);
            cmd.Parameters.AddWithValue("@usrOne", LogIn.lusername);
            cmd.Parameters.AddWithValue("@usrTwo", uName.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MesssageChat();
            SChat.Clear();
        }



        private void MesssageChat()
        {
            cfPanel.Controls.Clear();
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select * from chat", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table != null)
            {
                if (table.Rows.Count > 0)
                {
                    pChat[] usr2 = new pChat[table.Rows.Count];
                    chatBox[] usr1 = new chatBox[table.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            if (LogIn.lusername == row["userOne"].ToString() && uName.Text == row["userTwo"].ToString())
                            {
                                usr1[i] = new chatBox();
                                usr1[i].Dock = DockStyle.Top;
                                usr1[i].BringToFront();
                                usr1[i].Title = row["message"].ToString();
                                usr1[i].icon = account.snUsr;
                                cfPanel.Controls.Add(usr1[i]);
                                cfPanel.ScrollControlIntoView(usr1[i]);
                            }
                            else if (uName.Text == row["userOne"].ToString() && LogIn.lusername == row["userTwo"].ToString())
                            {
                                usr2[i] = new pChat();
                                usr2[i].Dock = DockStyle.Top;
                                usr2[i].BringToFront();
                                usr2[i].Title = row["message"].ToString();
                                usr2[i].icon = profile.Image;

                                cfPanel.Controls.Add(usr2[i]);
                                cfPanel.ScrollControlIntoView(usr2[i]);

                            }
                        }
                    }
                }
            }
        }

        private void searchBox_TextChanged_1(object sender, EventArgs e)
        {
            contactPanel.Controls.Clear();
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select * from usr where username like @search + '%' OR Phone like @search + '%' OR FullName like @search + '%'", conn);
            adapter.SelectCommand.Parameters.AddWithValue("@search", searchBox.Text.Trim());
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table != null)
            {
                if (table.Rows.Count > 0)
                {
                    contact[] contacts = new contact[table.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            contacts[i] = new contact();
                            MemoryStream stream = new MemoryStream((byte[])row["Image"]);
                            contacts[i].icon = new Bitmap(stream);
                            contacts[i].ptitle = row["username"].ToString();
                            if (contacts[i].ptitle == account.userName)
                            {
                                contactPanel.Controls.Remove(contacts[i]);
                            }
                            else
                            {
                                contactPanel.Controls.Add(contacts[i]);
                            }
                            contacts[i].Click += new System.EventHandler(this.contact2_Click);

                        }
                    }

                }
            }
        }
    

}
}
