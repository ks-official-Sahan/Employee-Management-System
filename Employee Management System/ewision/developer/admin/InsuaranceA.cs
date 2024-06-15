using Employee_Management_System.ewision.developer.model;
using Microsoft.VisualBasic.ApplicationServices;
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

namespace Employee_Management_System.admin_dashboard_pages
{
    public partial class InsuaranceA : Form
    {
        public InsuaranceA()
        {
            InitializeComponent();
            DisplayClaimsData(claimsTable);
        }

        public static void DisplayClaimsData(DataGridView claimsTable)
        {

            string query = "SELECT * FROM `claim` INNER JOIN `user` ON `user`.`uid`=`claim`.`user_uid` INNER JOIN `status` ON `status`.`id` = `claim`.`status_id`";

            MySqlDataReader resultSet = MySQL.Execute(query);

            if (resultSet.HasRows)
            {
                claimsTable.Rows.Clear();

                while (resultSet.Read())
                {

                    DataGridViewRow newRow = new DataGridViewRow();

                    newRow.CreateCells(claimsTable);
                    newRow.Cells[0].Value = resultSet["id"];
                    newRow.Cells[1].Value = resultSet["date"];
                    newRow.Cells[2].Value = resultSet["reason"];
                    newRow.Cells[3].Value = resultSet["uid"] + ": " + resultSet["fname"] + " " + resultSet["lname"];
                    newRow.Cells[4].Value = resultSet["status"];
                    newRow.Cells[5].Value = "Accept";
                    newRow.Cells[6].Value = "Reject";


                    claimsTable.Rows.Add(newRow);

                }
            }
        }


        private void Insuarance_Load(object sender, EventArgs e)
        {

        }

        private void claimsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void claimsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                //accept
                string query = "UPDATE `claim` SET `status_id`='1' WHERE `id`='" + claimsTable.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";
                MySQL.Execute(query);

                MySQL.Execute("INSERT INTO `notification` (`content`, `date_time`, `user_type_id`, `target_id`) VALUES ('Claim of "+ claimsTable.Rows[e.RowIndex].Cells[3].Value.ToString() + " on "+ claimsTable.Rows[e.RowIndex].Cells[1].Value.ToString() + " for " + claimsTable.Rows[e.RowIndex].Cells[2].Value.ToString() + " has been approved by Admin." + "', '" + string.Format("{0:yyyy/MM/dd HH:mm:ss}", DateTime.Now) + "', 2, 3)");
            }
            if (e.ColumnIndex == 6)
            {
                //decline
                string query = "UPDATE `claim` SET `status_id`='2' WHERE `id`='" + claimsTable.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";
                MySQL.Execute(query);

                MySQL.Execute("INSERT INTO `notification` (`content`, `date_time`, `user_type_id`, `target_id`) VALUES ('Claim of " + claimsTable.Rows[e.RowIndex].Cells[3].Value.ToString() + " on " + claimsTable.Rows[e.RowIndex].Cells[1].Value.ToString() + " for " + claimsTable.Rows[e.RowIndex].Cells[2].Value.ToString() + " has been declined by Admin." + "', '" + string.Format("{0:yyyy/MM/dd HH:mm:ss}", DateTime.Now) + "', 2, 3)");
            }
            DisplayClaimsData(claimsTable);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayClaimsData(claimsTable);
        }
    }
}
