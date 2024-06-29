using Employee_Management_System.ewision.developer.model;
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

namespace Employee_Management_System.user_dashboard_pages
{
    public partial class Health : Form
    {
        public Health()
        {
            InitializeComponent();
            Init();
        }

        private User user;

        private void Init()
        {
            user = UserDashboard.User;
            LoadStatus();
            reset();
        }

        private void AddStatus()
        {
            DateTime dateTime = dateTimePicker1.Value;
            string selectedDate = string.Format("{0:yyyy/MM/dd}", dateTime);

            string reason = reasonBox.Text;

            DateTime now = DateTime.Now;
            string appliedOn = string.Format("{0:yyyy/MM/dd HH:mm:ss}", now);

            if (reasonBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter the reason and description.");
            }
            else
            {
                MySQL.Execute("INSERT INTO `health_status` (`date`, `reason`, `updated_on`, `user_uid`) VALUES ('" + selectedDate + "', '" + reason + "', '" + appliedOn + "', '" + user.UID + "')");

                MySQL.Execute("INSERT INTO `notification` (`content`, `date_time`, `user_type_id`, `target_id`) VALUES ('" + user.Fname + " " + user.Lname + " :" + user.UID + " has submitted a status." + "', '" + appliedOn + "', 1, 1)");
            }

        }

        private void LoadStatus()
        {
            string query = "SELECT `id`,`date`,`reason`,`updated_on` FROM `health_status`";
            //string query = "SELECT `id`,`date`,`reason`,`updated_on` FROM `health_status` WHERE `user_uid`='"+user.UID+"'";

            MySqlDataReader resultSet = MySQL.Execute(query);

            if (resultSet.HasRows)
            {
                dvg.Rows.Clear();

                while (resultSet.Read())
                {
                    DataGridViewRow newRow = new DataGridViewRow();

                    newRow.CreateCells(dvg);
                    newRow.Cells[0].Value = resultSet["id"];
                    newRow.Cells[1].Value = string.Format("{0:yyyy/MM/dd}", resultSet["date"]);
                    newRow.Cells[2].Value = resultSet["reason"];
                    newRow.Cells[3].Value = resultSet["updated_on"];

                    dvg.Rows.Add(newRow);
                }
            }

        }

        private void reset()
        {
            reasonBox.Text = string.Empty;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStatus();
            reset();
            LoadStatus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadStatus();
        }
    }
}
