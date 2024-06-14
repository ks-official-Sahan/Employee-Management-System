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

namespace Employee_Management_System.user_dashboard_pages
{
    public partial class Leave : Form
    {
        public Leave()
        {
            InitializeComponent();
            Init();
        }

        private User user;

        private void Init()
        {
            user = UserDashboard.User;
            LoadLeaves();
            reset();
        }

        private void AddLeave()
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
                MySQL.Execute("INSERT INTO `leaves` (`date`, `reason`, `applied_on`, `user_uid`, `status_id`) VALUES ('" + selectedDate + "', '" + reason + "', '" + appliedOn + "', '" + user.UID + "', '3')");

                MySQL.Execute("INSERT INTO `notification` (`content`, `date_time`, `user_type_id`, `target_id`) VALUES ('" + user.Fname + " " + user.Lname + " :" + user.UID + " has submitted a leave." + "', '" + appliedOn + "', 1, 2)");
            }
        }

        private void LoadLeaves()
        {
            string query = "SELECT * FROM `leaves` INNER JOIN `status` ON `status`.`id` = `leaves`.`status_id`";
            //string query = "SELECT * FROM `leaves` INNER JOIN `status` ON `status`.`id` = `leaves`.`status_id` WHERE `user_uid`='" + user.UID + "'";

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
                    newRow.Cells[3].Value = resultSet["applied_on"];
                    newRow.Cells[4].Value = resultSet["status"];

                    dvg.Rows.Add(newRow);
                }
            }
        }

        private void reset()
        {
            reasonBox.Text = string.Empty;
        }

        private void Leave_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddLeave();
            reset();
            LoadLeaves();
        }
    }
}
