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
    public partial class Notifications : Form
    {
        public Notifications()
        {
            InitializeComponent();
            LoadNotifications();
        }

        private void LoadNotifications()
        {
            //string query = "SELECT * FROM `notification` INNER JOIN `target` ON `target`.`id` = `notification`.`target_id` WHERE `user_type_id` IN (SELECT * FROM `user_type` WHERE `type`='User')";
            string query = "SELECT * FROM `notification` INNER JOIN `target` ON `target`.`id` = `notification`.`target_id` WHERE `user_type_id`='2' ORDER BY `date_time` DESC";

            MySqlDataReader resultSet = MySQL.Execute(query);

            dvg.Rows.Clear();

            while (resultSet.Read())
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dvg);
                newRow.Cells[0].Value = resultSet["target"];
                newRow.Cells[1].Value = resultSet["content"];
                newRow.Cells[2].Value = string.Format("{0:yyyy/MM/dd HH:mm:ss}", resultSet["date_time"]);

                dvg.Rows.Add(newRow);
            }
        }

        private void Notifications_Load(object sender, EventArgs e)
        {

        }

        private void dvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
