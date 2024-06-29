

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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            LoadEmployees("");
            LoadSalaryData(false);
            hideLabels();
            dateLabel.Text = string.Format("{0:yyyy/MM/dd}", DateTime.Now);
        }

        private void LoadEmployees(string text)
        {
            string query = "SELECT * FROM `user` INNER JOIN `title` ON `user`.`title_id`=`title`.`id` INNER JOIN `status` ON `status`.`id` = `user`.`status_id` INNER JOIN `department` ON `department`.`id` = `user`.`department_id` INNER JOIN `designation` ON `designation`.`id` = `user`.`designation_id` WHERE `user_type_id`='2' AND (`email` LIKE '%" + text + "%' OR `fname` LIKE '%" + text + "%' OR `mobile` LIKE '%" + text + "%' OR `lname` LIKE '%" + text + "%') ORDER BY `fname` ASC";

            MySqlDataReader resultSet = MySQL.Execute(query);

            if (resultSet.HasRows)
            {
                employeeTable.Rows.Clear();

                while (resultSet.Read())
                {
                    DataGridViewRow newRow = new DataGridViewRow();

                    newRow.CreateCells(employeeTable);
                    newRow.Cells[0].Value = resultSet["uid"];
                    newRow.Cells[1].Value = resultSet["email"];
                    newRow.Cells[2].Value = resultSet["mobile"];
                    newRow.Cells[3].Value = resultSet["fname"] + " " + resultSet["lname"];
                    newRow.Cells[4].Value = resultSet["department"] + " " + resultSet["designation"];
                    newRow.Cells[5].Value = resultSet["status"];
                    newRow.Cells[6].Value = "Select";

                    employeeTable.Rows.Add(newRow);

                }
            }
        }
        private void LoadSalaryData(bool isSelected)
        {
            string query = "SELECT * FROM `salary` INNER JOIN `user` ON `salary`.`user_uid`=`user`.`uid` INNER JOIN `title` ON `user`.`title_id`=`title`.`id` INNER JOIN `status` ON `status`.`id` = `user`.`status_id` INNER JOIN `department` ON `department`.`id` = `user`.`department_id` INNER JOIN `designation` ON `designation`.`id` = `user`.`designation_id` WHERE `status_id`='1'";
            if (isSelected)
            {
                query += " AND `user_uid`='" + employerIdBox.Text + "'";
            }
            query += " ORDER BY `salary_date` DESC";

            MySqlDataReader resultSet = MySQL.Execute(query);

            salaryTable.Rows.Clear();
            if (resultSet.HasRows)
            {
                while (resultSet.Read())
                {
                    DataGridViewRow newRow = new DataGridViewRow();

                    newRow.CreateCells(salaryTable);
                    newRow.Cells[0].Value = resultSet["id"];
                    newRow.Cells[1].Value = resultSet["email"];
                    newRow.Cells[2].Value = resultSet["fname"] + " " + resultSet["lname"];
                    newRow.Cells[3].Value = resultSet["basic"];
                    newRow.Cells[4].Value = resultSet["day_count"];
                    newRow.Cells[5].Value = resultSet["bonus"];
                    newRow.Cells[6].Value = string.Format("{0:yyyy/MM/dd}", resultSet["salary_date"]);
                    newRow.Cells[7].Value = ((double)resultSet.GetDouble("basic") * (int)resultSet.GetInt32("day_count")) + (double)resultSet.GetDouble("bonus");

                    salaryTable.Rows.Add(newRow);
                }
            }
        }

        private void hideLabels()
        {
            employerIdBox.Visible = false;
            employerNameBox.Visible = false;
            employerPositionBox.Visible = false;
        }
        private void showLabels()
        {
            employerIdBox.Visible = true;
            employerNameBox.Visible = true;
            employerPositionBox.Visible = true;
        }
        private void reset()
        {
            employerIdBox.Text = "Employer ID";
            employerNameBox.Text = "Employer Name";
            employerPositionBox.Text = "Employer Position";
            hideLabels();

            bpdBox.Text = countBox.Text = bonusBox.Text = salaryLabel.Text = "0";

            dateLabel.Text = string.Format("{0:yyyy/MM/dd}", DateTime.Now);
            searchBox.Text = string.Empty;
            LoadEmployees("");
            LoadSalaryData(false);
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
                //Select
                string query = "UPDATE `user` SET `status_id`='1' WHERE `uid`='" + employeeTable.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";
                MySQL.Execute(query);
                MySQL.Execute("INSERT INTO `notification` (`content`, `date_time`, `user_type_id`, `target_id`) VALUES ('Claim of " + employeeTable.Rows[e.RowIndex].Cells[3].Value.ToString() + " on " + employeeTable.Rows[e.RowIndex].Cells[1].Value.ToString() + " for " + employeeTable.Rows[e.RowIndex].Cells[2].Value.ToString() + " has been approved by Admin." + "', '" + string.Format("{0:yyyy/MM/dd HH:mm:ss}", DateTime.Now) + "', 1, 2)");

                showLabels();
                string name = employeeTable.Rows[e.RowIndex].Cells[3].Value.ToString();
                string id = employeeTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                string position = employeeTable.Rows[e.RowIndex].Cells[4].Value.ToString();

                employerNameBox.Text = name;
                employerIdBox.Text = id;
                employerPositionBox.Text = position;

                LoadSalaryData(true);

                string email = employeeTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                searchBox.Text = email;
                LoadEmployees(email);
            }
        }

        private void calculateSalary()
        {
            string bpd = bpdBox.Text.Equals("") ? "0" : bpdBox.Text.Trim();
            string count = countBox.Text.Equals("") ? "0" : countBox.Text.Trim();
            string bonus = bonusBox.Text.Equals("") ? "0" : bonusBox.Text.Trim();

            try
            {
                double salary = (double.Parse(bpd) * int.Parse(count)) + double.Parse(bonus);
                salaryLabel.Text = salary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter integer values for salary generation!! " + ex.Message);
            }
        }

        private void generateSalary()
        {
            string bpd = bpdBox.Text.Equals("") ? "0" : bpdBox.Text.Trim();
            string count = countBox.Text.Equals("") ? "0" : countBox.Text.Trim();
            string bonus = bonusBox.Text.Equals("") ? "0" : bonusBox.Text.Trim();

            string date = string.Format("{0:yyyy/MM/dd}", DateTime.Now);

            string query = "INSERT INTO `salary` (`basic`, `day_count`, `user_uid`, `bonus`, `salary_date`) VALUES ('" + bpd + "', '" + count + "', '" + employerIdBox.Text + "', '" + bonus + "', '" + date + "')";
            MySQL.Execute(query);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            LoadEmployees(searchBox.Text);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            LoadEmployees(searchBox.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bpdBox_TextChanged(object sender, EventArgs e)
        {
            calculateSalary();
        }

        private void countBox_TextChanged(object sender, EventArgs e)
        {
            calculateSalary();
        }

        private void bonusBox_TextChanged(object sender, EventArgs e)
        {
            calculateSalary();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            generateSalary();
            bpdBox.Text = countBox.Text = bonusBox.Text = salaryLabel.Text = "0";
            LoadSalaryData(true);
        }
    }
}
