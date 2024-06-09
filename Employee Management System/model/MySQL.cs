using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using Mysqlx.Prepare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System.model
{
    class MySQL
    {

        private static MySqlConnection connection = GetConnection();
        private static MySqlConnection GetConnection()
        {
            string connectionString = "datasource=localhost;port=3306;username=sahan;password=Sahan@123;database=EMS";

            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open(); //open connection
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        //Console.WriteLine(ex.Message);
                        MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }

            return connection;
        }

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

        public static void Select1(string query)
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

        public static MySqlDataReader Select(string query)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Query Execution Error! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static MySqlDataReader Execute(string query)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                if (query.StartsWith("SELECT"))
                {
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    return dataReader;
                } else
                {
                    cmd.ExecuteNonQuery(); //Execute command

                    MessageBox.Show("Query Executed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Query Execution Error! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }



        //Close connection
        private static bool CloseConnection()
        {
            try
            {
                connection.Close(); //close connection
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}