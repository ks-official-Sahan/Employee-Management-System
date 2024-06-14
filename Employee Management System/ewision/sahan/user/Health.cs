using Employee_Management_System.ewision.sahan.model;
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

namespace Employee_Management_System.user_dashboard_pages
{
    public partial class Health : Form

    {

            
        public Health()
        {
            InitializeComponent();
            DisplayTableData(dataGridView1);
        }
        public static void DisplayTableData(DataGridView dvg) {

            string query = "SELECT * FROM `user`";
           
             MySqlDataReader resultSet = MySQL.Execute(query);

            if (resultSet.Read())
            {
                dvg.Rows.Clear();

                while (resultSet.Read())
                {
                   
                        DataGridViewRow newRow = new DataGridViewRow();

                        newRow.CreateCells(dvg);
                        newRow.Cells[0].Value = resultSet["uid"];
                        newRow.Cells[1].Value = resultSet["fname"];
                        newRow.Cells[2].Value = resultSet["mobile"];
                        newRow.Cells[3].Value = resultSet["email"];

                        dvg.Rows.Add(newRow);
                    


                }



            }



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
