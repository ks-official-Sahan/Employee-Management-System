using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using Mysqlx.Prepare;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Employee_Management_System.ewision.sahan.model
{
    class MySQL
    {

        private static MySqlConnection connection = GetConnection();
        private static MySqlConnection GetConnection()
        {
            string connectionString = "datasource=localhost;port=3306;username=sahan;password=Sahan@123;database=EMS";
            //string connectionString = "datasource=localhost;port=3306;username=root;password=LeaveMe@666;database=EMS";
            //string connectionString = "datasource=localhost;port=3306;username=root;password=LeaveMe@666;database=EMS";

            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open(); //open connection
                //MessageBox.Show("Database Connected");
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid database username/password, please try again");
                        break;
                    default:
                        //Console.WriteLine(ex.Message);
                        MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }

            return connection;
        }

        /* Method 1

        public static void iud(string query)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, connection); //create command and assign the query and connection

                cmd.ExecuteNonQuery(); //Execute command

                MessageBox.Show("Query Executed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Query Execution Error! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static MySqlDataReader Search(string query)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                MessageBox.Show("Query Executed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return dataReader;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Query Execution Error! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        */


        /* Mehtod 2 */

        public static MySqlDataReader Execute(string query)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, GetConnection());

                if (query.StartsWith("SELECT"))
                {
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //MessageBox.Show("Query Executed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CloseConnection();
                    return dataReader;
                }
                else
                {
                    cmd.ExecuteNonQuery(); //Execute command
                    //MessageBox.Show("Query Executed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CloseConnection();
                    return null;
                }

            }
            catch (MySqlException ex) 
            {
                MessageBox.Show("Query Execution Error! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public static int Insert(string query)
        {
            try
            {
                MySqlConnection conn = GetConnection() as MySqlConnection;
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.ExecuteNonQuery(); //Execute command
                //MessageBox.Show("Query Executed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                object result = MySqlHelper.ExecuteScalar(conn, "SELECT LAST_INSERT_ID()");
                if (result != null)
                {
                    string id = ((UInt64)result).ToString();
                    //MessageBox.Show(id);
                    CloseConnection();
                    return Int32.Parse(id);
                }
                CloseConnection();
                return 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Query Execution Error! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public static void SearchToTable(string query)
        {
            try
            {
                MySqlConnection conn = GetConnection() as MySqlConnection;
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //cmd.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                //this.grvItems.DataSource = dataSet;
                //this.grvItems.DataBind();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Query Execution Error! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SearchToTable(string query, DataGridView dgv)
        {
            try
            {
                MySqlConnection conn = GetConnection() as MySqlConnection;
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //cmd.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Query Execution Error! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //public static void Main(string[] args)
        //{
        /* Create Connection */
        //MySqlConnection mySqlConnection = GetConnection();

        /* Insert Data */
        //string query = "INSERT INTO `user` " +
        //    "(`fname`, `lname`, `email`, `password`, `user_type_id`, `mobile`, `title_id`,`status_id`) " +
        //    "VALUES " +
        //    "('Chathura', 'Chathura', 'Chathura@gmail.com', 'Sahan123', 1, '0710123456', 1, 1)";
        //iud(query);

        /* Update Data */
        //string query = "UPDATE `user` SET `department_id` = NULL WHERE `uid`='1'";
        //iud(query);

        /* Delete Data */
        //string query = "DELETE FROM `user` WHERE `uid`='3'";
        //iud(query);

        /* Select Data */
        //string query = "SELECT * FROM `user`";
        //MySqlDataReader dataReader = Search(query);
        //if (dataReader != null)
        //{
        //    while (dataReader.Read())
        //    {
        //        MessageBox.Show((string?) dataReader["fname"] + " " + (string?) dataReader["lname"]);
        //    }
        //}

        /* Execute Test */
        //string query = "INSERT INTO `user` " +
        //    "(`fname`, `lname`, `email`, `password`, `user_type_id`, `mobile`, `title_id`,`status_id`) " +
        //    "VALUES " +
        //    "('Chathura', 'Chathura', 'Chathura@gmail.com', 'Sahan123', 1, '0710123456', 1, 1)";
        //string id = "2";
        //string query = "SELECT * FROM `user` WHERE `uid` = '"+id+"'";
        //string query = "DELETE FROM `user` WHERE `uid`='"+id+"'";
        //string query = "UPDATE `user` SET `department_id` = '1' WHERE `uid`='"+id+"'";

        //Execute(query);

        //MySqlDataReader dataReader =  Execute(query);
        //if (dataReader != null)
        //{
        //    while (dataReader.Read())
        //    {
        //        MessageBox.Show((string?) dataReader["fname"] + " " + (string?) dataReader["lname"]);
        //    }
        //}
        //}


        //Close connection
        private static bool CloseConnection()
        {
            try
            {
                connection.Close(); //close connection
                //MessageBox.Show("Database Disconnected");
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }




        /*  Practice Methods
         
                public static void iud1(string query)
        {
            //            if (query != null)
            //            {
            //                Console.WriteLine(query);
            //            }
            //            else
            //            {
            query = "INSERT INTO `user` " +
                "(`fname`, `lname`, `email`, `password`, `user_type_id`, `mobile`, `title_id`,`status_id`) " +
                "VALUES " +
                "('Chathura', 'Chathura', 'Chathura@gmail.com', 'Sahan123', 1, '0710123456', 1, 1)";
            //            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, connection); //create command and assign the query and connection

                cmd.ExecuteNonQuery(); //Execute command

                MessageBox.Show("Query Executed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Query Execution Error! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void Search1(string query)
        {
            try
            {
                //Create a list to store the result
                List<string>[] list = new List<string>[3];
                list[0] = new List<string>();
                list[1] = new List<string>();
                list[2] = new List<string>();

                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                MessageBox.Show("Query Executed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["name"] + "");
                    list[2].Add(dataReader["age"] + "");
                }

                //close Data Reader
                dataReader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Query Execution Error! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

         
         */
    }
}