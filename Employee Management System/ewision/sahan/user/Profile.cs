﻿using Employee_Management_System.ewision.sahan.model;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Employee_Management_System.user_dashboard_pages
{
    public partial class Profile : Form
    {

        private User user = UserDashboard.User;
        public Profile()
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
            //string query = "SELECT * FROM `user` INNER JOIN `title` ON `user`.`title_id` = `title`.`id` INNER JOIN `status` ON `user`.`status_id` = `status`.`id` WHERE `uid` = '" + UserDashboard.User.UID + "'"; //admin
            string query = "SELECT * FROM `user` INNER JOIN `title` ON `user`.`title_id` = `title`.`id` INNER JOIN `department` ON `user`.`department_id` = `department`.`id` INNER JOIN `designation` ON `user`.`designation_id` = `designation`.`id` WHERE `uid` = '" + UserDashboard.User.UID + "'"; //user
            MySqlDataReader resultSet = MySQL.Execute(query);

            if (resultSet.Read())
            {
                //user.Dob = string.Format("{0:MM/dd/yyyy}", resultSet["dob"]);
                user.Designation = (string)resultSet["designation"];
                user.Department = (string)resultSet["department"];

                MySqlDataReader address = MySQL.Execute("SELECT * FROM `address` WHERE `user_uid`='" + user.UID + "'");

                if (resultSet.Read())
                {
                    textBox6.Text = (string)address["line1"];
                    textBox7.Text = (string)address["line2"];
                    textBox8.Text = (string)address["city"];
                    textBox9.Text = (string)address["pcode"];
                }
            }
            else
            {
                MessageBox.Show("Didn't found");
                user.Designation = "Not Found";
                user.Department = "Not Found";
            }

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
            label5.Text += user.Designation;
            label6.Text += user.Department + " Department";
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

            UpdateAddress();
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
                    } else
                    {
                        string query = "SELECT * FROM `user` WHERE `uid` = '" + UserDashboard.User.UID + "'"; //user
                        MySqlDataReader resultSet = MySQL.Execute(query);

                        if (resultSet.Read())
                        {
                            if ((string) resultSet["password"] != password)
                            {
                                MessageBox.Show("Please enter the your correct old Password to update your password");
                            } else
                            {
                                MySQL.Execute("UPDATE `user` SET `password`='" + newPass + "' WHERE `user_uid`='" + user.UID + "'");
                            }
                        } else
                        {
                            MessageBox.Show("Something failed.");
                        }
                    }
                }
            }
        }

        private void UpdateAddress()
        {
            string line1 = textBox6.Text;
            string line2 = textBox7.Text;
            string city = textBox8.Text;
            string pcode = textBox9.Text;


            if (!(line1.Trim().Equals("") || line2.Trim().Equals("") || city.Trim().Equals("") || pcode.Trim().Equals("")))
            {
                MySqlDataReader address = MySQL.Execute("SELECT * FROM `address` WHERE `user_uid`='" + user.UID + "'");

                if (address.Read())
                {
                    if ((string)address["line1"] != line1 || (string)address["line2"] != line2 || (string)address["city"] != city || (string)address["pcode"] != pcode)
                    {
                        MySQL.Execute("UPDATE `address` SET `line1`='" + line1 + "', `line2`='" + line2 + "', `city`='" + city + "', `pcode`='" + pcode + "' WHERE `user_uid`='" + user.UID + "'");
                    }
                }
                else
                {
                    MySQL.Execute("INSERT INTO `address` (`line1`, `line2`, `city`, `pcode`, `user_uid`) VALUES ('" + line1 + "', '" + line2 + "', '" + city + "', '" + pcode + "', '" + user.UID + "')");
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
