﻿using System;
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
    public partial class user_login : Form
    {
        public user_login()
        {
            InitializeComponent();
        }

        private void user_login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            if (username.Equals(""))
            {
                Console.WriteLine("Username is required");
                MessageBox.Show("Username is required", "Warning");
            } else if (password.Equals(""))
            {
                Console.WriteLine("Password is required");
                MessageBox.Show("Password is required", "Warning");
            }
            else
            {

                user_dashboard user_dashboard = new user_dashboard();
                user_dashboard.Show();
                this.Hide();
            }
        }
    }
}
