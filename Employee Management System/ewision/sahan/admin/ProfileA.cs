using Employee_Management_System.ewision.sahan.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Employee_Management_System.admin_dashboard_pages
{
    public partial class ProfileA : Form
    {

        private User user = AdminDashboard.User;
        public ProfileA()
        {
            InitializeComponent();

            Init();
        }
        private void Init()
        {
            LoadUserData();
        }

        private void LoadUserData()
        {
            SetUserData();
        }

        private void SetUserData()
        {
            textBox2.Text = user.Mobile;
            textBox1.Text = user.Email;

            label1.Text += user.Email;
            label2.Text += user.Fname;
            label3.Text += user.Lname;
            label4.Text += user.Dob;
        }

        private void UpdateUser()
        {
            string email = textBox1.Text;
            string mobile = textBox2.Text;

            if (email != user.Email || mobile != user.Mobile)
            {
                MySQL.Execute("UPDATE `user` SET `email`='" + email + "', `mobile`='" + mobile + "' WHERE `user_uid`='" + user.UID + "'");
            }

            updatePassword();

        }

        private void updatePassword()
        {
            string password = textBox3.Text;
            string newPass = textBox4.Text;
            string rePass = textBox5.Text;

            if (!newPass.Equals("") || newPass != null)
            {
                if (password.Equals("") || password == null)
                {
                    MessageBox.Show("Please enter Current Password to update your password");
                }
                else if (rePass.Equals("") || rePass == null)
                {
                    MessageBox.Show("Please re-enter New Password in Confirm Password to update your password");
                }
                else
                {
                    if (newPass != rePass)
                    {
                        MessageBox.Show("Passwords doesn't match");
                    }
                    else
                    {
                        string query = "SELECT * FROM `user` WHERE `uid` = '" + UserDashboard.User.UID + "'"; //user
                        MySqlDataReader resultSet = MySQL.Execute(query);

                        if (resultSet.Read())
                        {
                            if ((string)resultSet["password"] != password)
                            {
                                MessageBox.Show("Please enter the your correct old Password to update your password");
                            }
                            else
                            {
                                MySQL.Execute("UPDATE `user` SET `password`='" + newPass + "' WHERE `user_uid`='" + user.UID + "'");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Something failed.");
                        }
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateUser();
        }
    }
}
