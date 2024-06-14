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

namespace Employee_Management_System.admin_dashboard_pages
{
    public partial class LeaveA : Form
    {
        public LeaveA()
        {
            InitializeComponent();
            DisplayLeaveData(leaaveTable);
        }

        public static void DisplayLeaveData(DataGridView dvg)
        {

            string query = "SELECT * FROM `leaves` INNER JOIN `user` ON `user`.`uid`=`leaves`.`user_uid` INNER JOIN `status` ON `status`.`id` = `leaves`.`status_id`";

            MySqlDataReader resultSet = MySQL.Execute(query);

            if (resultSet.HasRows)
            {
                dvg.Rows.Clear();

                while (resultSet.Read())
                {

                    DataGridViewRow newRow = new DataGridViewRow();

                    newRow.CreateCells(dvg);
                    newRow.Cells[0].Value = resultSet["id"];
                    newRow.Cells[1].Value = resultSet["date"];
                    newRow.Cells[2].Value = resultSet["reason"];
                    newRow.Cells[3].Value = resultSet["uid"] + ": " + resultSet["fname"] + " " + resultSet["lname"];
                    newRow.Cells[4].Value = resultSet["status"];
                    newRow.Cells[5].Value = "Accept";
                    newRow.Cells[6].Value = "Reject";


                    dvg.Rows.Add(newRow);

                }
            }
        }

        private void Leave_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void leaaveTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                //accept
                string query = "UPDATE `leaves` SET `status_id`='1' WHERE `id`='" + leaaveTable.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";
                MySQL.Execute(query);
            }
            if (e.ColumnIndex == 6)
            {
                //decline
                string query = "UPDATE `leaves` SET `status_id`='2' WHERE `id`='" + leaaveTable.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";
                MySQL.Execute(query);
            }
            DisplayLeaveData(leaaveTable);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayLeaveData(leaaveTable);
        }
    }
}
