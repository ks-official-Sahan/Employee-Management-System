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

            string query = "SELECT * FROM `leaves` INNER JOIN `user` ON `user`.`uid`=`leaves`.`user_uid`";

            MySqlDataReader resultSet = MySQL.Execute(query);

            if (resultSet.HasRows)
            {
                dvg.Rows.Clear();

                while (resultSet.Read())
                {

                    DataGridViewRow newRow = new DataGridViewRow();

                    newRow.CreateCells(dvg);
                    newRow.Cells[0].Value = resultSet["fname"] + " " + resultSet["lname"];
                    newRow.Cells[1].Value = resultSet["mobile"];
                    newRow.Cells[2].Value = resultSet["reason"];
                    newRow.Cells[3].Value = "Accept";
                    newRow.Cells[4].Value = "Reject";


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
            if (e.ColumnIndex == 3) {
                return;
            }
            if (e.ColumnIndex == 4) {


                string query = "UPDATE `leaves` SET     ";

                MySqlDataReader resultSet = MySQL.Execute(query);

            }
        }
    }
}
