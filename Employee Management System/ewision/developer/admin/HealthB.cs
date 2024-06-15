using Employee_Management_System.ewision.developer.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Employee_Management_System.admin_dashboard_pages
{
    public partial class HealthB : Form
    {

        public HealthB()
        {
            InitializeComponent();
            LoadStatus(dataGridView1);
        }

        public static void LoadStatus(DataGridView dvg)
        {
            string query = "SELECT `id`,`date`,`reason`,`updated_on`,`user_uid`, `fname`, `lname` FROM `health_status` INNER JOIN `user` ON `health_status`.`user_uid`=`user`.`uid`";

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
                    newRow.Cells[4].Value = resultSet["user_uid"] + ": " + resultSet["fname"] + " " + resultSet["lname"];

                    dvg.Rows.Add(newRow);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadStatus(dataGridView1);
        }
    }
}
