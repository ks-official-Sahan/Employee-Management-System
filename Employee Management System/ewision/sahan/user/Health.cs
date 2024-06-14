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
        }

        private void AddStatus()
        {
            DateTime dateTime = dateTimePicker1.Value;
            string selectedDate = string.Format("{0:MM/dd/yyyy}", dateTime);

            string reason = reasonBox.Text;

            DateTime appliedOn = DateTime.Now;

            MySQL.Execute("INSERT INTO `health_status` (`date`, `reason`, `updated_on`, `user_uid`) VALUES ('" + selectedDate + "', '" + reason + "', '" + appliedOn + "', '" + user.UID + "')");

            MySQL.Execute("INSERT INTO `notification` (`content`, `date_time`, `user_type_id`, `target_id`) VALUES ('" + user.Fname + " " + user.Lname + " :" + user.UID + " has submitted a status." + "', '" + appliedOn + "', 2, 1)");
        }

        private void LoadStatus()
        {
            MySqlDataReader dataReader = MySQL.Execute("SELECT * FROM `health_status` WHERE `user_uid`='" + user.UID + "'");
            while (dataReader.Read())
            {
                // Load Table
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStatus();
        }
    }
}
