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
        }

        private void AddLeave()
        {
            DateTime dateTime = dateTimePicker1.Value;
            string selectedDate = string.Format("{0:MM/dd/yyyy}",dateTime);

            string reason = reasonBox.Text;

            DateTime appliedOn = DateTime.Now;

            MySQL.Execute("INSERT INTO `leaves` (`date`, `reason`, `applied_on`, `user_uid`, `status_id`) VALUES ('" + selectedDate + "', '" + reason + "', '" + appliedOn + "', '" + user.UID + "', '3')");

            MySQL.Execute("INSERT INTO `notification` (`content`, `date_time`, `user_type_id`, `target_id`) VALUES ('" + user.Fname + " " + user.Lname + " :" + user.UID + " has submitted a leave." + "', '" + appliedOn + "', 2, 2)");
        }

        private void LoadLeaves()
        {
            MySqlDataReader dataReader = MySQL.Execute("SELECT * FROM `leaves` WHERE `user_uid`='" + user.UID + "'");
            while (dataReader.Read()) {
                // Load Table
            }
        }

        private void Leave_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
