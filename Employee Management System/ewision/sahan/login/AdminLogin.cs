using Employee_Management_System.ewision.sahan.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ewision.sahan.model.User user = new ewision.sahan.model.User("5", "Sahan", "Sahan", "Sahan@gmail.com", "0761234567", "2004/06/11");
            //openAdminDashboard(user);

            signIn();
        }

        private void openAdminDashboard(ewision.sahan.model.User user)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.SetUser(user);
            adminDashboard.Show();
            this.Hide();
        }

        private void signIn()
        {
            string username = usernameBox.Text;
            string password = textBox2.Text;

            if (username.Equals(""))
            {
                Console.WriteLine("Username is required");
                MessageBox.Show("Username is required!", "Warning");
            }
            else if (password.Equals(""))
            {
                Console.WriteLine("Password is required");
                MessageBox.Show("Password is required!", "Warning");
            }
            else
            {

                //string query = "SELECT * FROM `user` WHERE `email` = '" + username + "' AND `user_type_id` = '1'"; //admin
                string query = "SELECT * FROM `user` WHERE `email` = '" + username + "' AND `user_type_id` <> '1'"; //user
                MySql.Data.MySqlClient.MySqlDataReader resultSet = MySQL.Execute(query);

                if (resultSet.Read())
                {
                    if (((string)resultSet["password"]).Equals(password))
                    {
                        if ((sbyte)resultSet["status_id"] == 1)
                        {
                            ewision.sahan.model.User user;
                            user = new ewision.sahan.model.User(((int)resultSet["uid"]).ToString(), (string)resultSet["fname"], (string)resultSet["lname"], (string)resultSet["email"], (string)resultSet["mobile"], resultSet["dob"]);
                            user.UID = ((int)resultSet["uid"]).ToString();

                            openAdminDashboard(user);
                        }
                        else
                        {
                            MessageBox.Show("User has been blocked!", "Warning");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password!", "Warning");
                    }

                }
                else
                {
                    MessageBox.Show("Can't find any users with the username!", "Warning");
                }

            }

        }
    }
}
