using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employee_Management_System.ewision.developer.model;
using MongoDB.Bson;
using MongoDB.Driver;
using MySql.Data.MySqlClient;

namespace Employee_Management_System
{
    public partial class admin_reg : Form
    {
        private IMongoCollection<BsonDocument> userCollection;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public admin_reg()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            LoadTitles();
        }

        private Dictionary<string, string> titleMap = new Dictionary<string, string>();

        private void LoadTitles()
        {
            string query = "SELECT * FROM `title` ORDER BY `title` ASC";
            MySqlDataReader dataReader = MySQL.Execute(query);

            titleComboBox.Items.Clear();
            titleComboBox.Items.Add("Select");
            //string[] titles = { "Select" };

            while (dataReader.Read())
            {
                string title = dataReader.GetString("title");
                //string title = dataReader["title"];

                //titles.Append(title);
                titleComboBox.Items.Add(title);
                titleMap.Add(title, dataReader["id"].ToString());
            }

            //titleComboBox.Items.AddRange(titles);
            //titleComboBox.SelectedIndex = 0;
            titleComboBox.SelectedItem = "Select";
        }

        private void admin_reg_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegisterAdmin()
        {
            string title = titleComboBox.SelectedItem == null ? "Mr." : (string)titleComboBox.SelectedItem;

            string fname = fnameBox.Text;
            string lname = lnameBox.Text;
            string mobile = mobileBox.Text;
            string email = emailBox.Text;

            string accessCode = accessCodeBox.Text;

            string pass = passwordBox.Text;
            string cPass = cPasswordBox.Text;

            if (title.Equals("Select"))
            {
                MessageBox.Show("Please select Title!");
            }
            else if (fname.Trim().Equals(""))
            {
                MessageBox.Show("Please enter First Name!");
            }
            else if (lname.Trim().Equals(""))
            {
                MessageBox.Show("Please enter Last Name!");
            }
            else if (accessCode.Trim().Equals(""))
            {
                MessageBox.Show("Please enter the Access Code!");
            }
            else if (mobile.Trim().Equals(""))
            {
                MessageBox.Show("Please enter Mobile Number!");
            }
            else if (email.Trim().Equals(""))
            {
                MessageBox.Show("Please enter Email Address!");
            }
            else if (pass.Trim().Equals(""))
            {
                MessageBox.Show("Please enter the Password!");
            }
            else if (cPass.Trim().Equals(""))
            {
                MessageBox.Show("Please enter the Confirm Password!");
            }
            else if (!pass.Equals(cPass))
            {
                MessageBox.Show("Passwords doesn't match!");
            }
            else
            {
                try
                {
                    string code = GetAccessCode();
                    if (code == "")
                    {
                        code = "EMS@QC24";
                    }

                    if (accessCode != code)
                    {
                        MessageBox.Show("Invalid Access Code!");
                    }
                    else
                    {

                        MySqlDataReader dataReader = MySQL.Execute("SELECT * FROM `user` WHERE `email`='" + email + "' OR `mobile`='" + mobile + "'");
                        if (dataReader.Read())
                        {
                            MessageBox.Show("admin email or mobile already exists!");
                        }
                        else
                        {

                            string query = "INSERT INTO `user` (`fname`, `lname`, `email`, `mobile`, `password`, `user_type_id`, `title_id`, `status_id`) " +
                            "VALUES ('" + fname + "', '" + lname + "', '" + email + "', '" + mobile + "', '" + pass + "', '1', '" + titleMap[title] + "', '1')";
                            //MySQL.Execute(query);
                            int uid = MySQL.Insert(query);

                            MessageBox.Show("Registered Successfully");
                            new AdminLogin().Show();
                            this.Hide();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something Failed! " + ex.Message);
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private string GetAccessCode()
        {
            try
            {
                string query = "SELECT * FROM `code`";
                MySqlDataReader dataReader = MySQL.Execute(query);

                if (dataReader.Read())
                {
                    string accessCode = dataReader.GetString("code");
                    if (accessCode != "")
                    {
                        return accessCode;
                    }
                    else
                    {
                        return "EMS@QC24";
                    }
                }
                else
                {
                    return "EMS@QC24";
                }
            }
            catch (MySqlException e)
            {
                if (e.Number == 1146)
                {
                    return "EMS@QC24";
                }
                return "";
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Something Failed! " + ex.Message);
                //Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            RegisterAdmin();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AdminLogin().Show();
            this.Hide();
        }
    }
}
