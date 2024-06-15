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

namespace Employee_Management_System.admin_dashboard_pages
{
    public partial class Employers : Form
    {
        public Employers()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            DisplayEmployeeData(employeeTable, "");
        }

        public static void DisplayEmployeeData(DataGridView table, string text)
        {
            string query = "SELECT * FROM `user` INNER JOIN `title` ON `user`.`title_id`=`title`.`id` INNER JOIN `status` ON `status`.`id` = `user`.`status_id` INNER JOIN `department` ON `department`.`id` = `user`.`department_id` INNER JOIN `designation` ON `designation`.`id` = `user`.`designation_id` WHERE `user_type_id`='2' AND (`email` LIKE '%" + text + "%' OR `fname` LIKE '%" + text + "%' OR `mobile` LIKE '%" + text + "%' OR `lname` LIKE '%" + text + "%') ORDER BY `fname` ASC";

            MySqlDataReader resultSet = MySQL.Execute(query);

            if (resultSet.HasRows)
            {
                table.Rows.Clear();

                while (resultSet.Read())
                {
                    DataGridViewRow newRow = new DataGridViewRow();

                    newRow.CreateCells(table);
                    newRow.Cells[0].Value = resultSet["uid"];
                    newRow.Cells[1].Value = resultSet["email"];
                    newRow.Cells[2].Value = resultSet["mobile"];
                    newRow.Cells[3].Value = resultSet["fname"] + " " + resultSet["lname"];
                    newRow.Cells[4].Value = resultSet["department"] + " " + resultSet["designation"];
                    newRow.Cells[5].Value = resultSet["status"];
                    newRow.Cells[6].Value = "Activate";
                    newRow.Cells[7].Value = "Block";

                    table.Rows.Add(newRow);

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
            if (e.ColumnIndex == 6)
            {
                //Active
                string query = "UPDATE `user` SET `status_id`='1' WHERE `uid`='" + employeeTable.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";
                MySQL.Execute(query);
                MySQL.Execute("INSERT INTO `notification` (`content`, `date_time`, `user_type_id`, `target_id`) VALUES ('Claim of " + employeeTable.Rows[e.RowIndex].Cells[3].Value.ToString() + " on " + employeeTable.Rows[e.RowIndex].Cells[1].Value.ToString() + " for " + employeeTable.Rows[e.RowIndex].Cells[2].Value.ToString() + " has been approved by Admin." + "', '" + string.Format("{0:yyyy/MM/dd HH:mm:ss}", DateTime.Now) + "', 1, 2)");
            }
            if (e.ColumnIndex == 7)
            {
                //Block
                string query = "UPDATE `user` SET `status_id`='2' WHERE `uid`='" + employeeTable.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";
                MySQL.Execute(query);
                MySQL.Execute("INSERT INTO `notification` (`content`, `date_time`, `user_type_id`, `target_id`) VALUES ('Claim of " + employeeTable.Rows[e.RowIndex].Cells[3].Value.ToString() + " on " + employeeTable.Rows[e.RowIndex].Cells[1].Value.ToString() + " for " + employeeTable.Rows[e.RowIndex].Cells[2].Value.ToString() + " has been declined by Admin." + "', '" + string.Format("{0:yyyy/MM/dd HH:mm:ss}", DateTime.Now) + "', 1, 2)");
            }
            DisplayEmployeeData(employeeTable, "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayEmployeeData(employeeTable, "");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            DisplayEmployeeData(employeeTable, searchBox.Text);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            DisplayEmployeeData(employeeTable, searchBox.Text);
        }
    }
}
