using DnsClient.Protocol;
using Employee_Management_System.ewision.sahan.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Employee_Management_System.admin_dashboard_pages
{
    public partial class EmployeeRegister : Form
    {
        public EmployeeRegister()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string title = titleComboBox.SelectedItem == null ? "Mr." : (string)titleComboBox.SelectedItem;

            string fname = fnameBox.Text;
            string lname = lnameBox.Text;
            string mobile = mobileBox.Text;
            string email = emailBox.Text;

            string pass = passwordBox.Text;
            string cPass = cPaswordBox.Text;

            if (fname.Trim().Equals(""))
            {
                MessageBox.Show("Please enter First Name of Employee!");
            }
            else if (lname.Trim().Equals(""))
            {
                MessageBox.Show("Please enter Last Name of Employee!");
            }
            else if (email.Trim().Equals(""))
            {
                MessageBox.Show("Please enter Email of Employee!");
            }
            else if (mobile.Trim().Equals(""))
            {
                MessageBox.Show("Please enter Mobile of Employee!");
            }
            else if (pass.Trim().Equals(""))
            {
                MessageBox.Show("Please enter Password of Employee!");
            }
            else if (cPass.Trim().Equals(""))
            {
                MessageBox.Show("Please enter Confirm Password!");
            }
            else if (!pass.Equals(cPass))
            {
                MessageBox.Show("Passwords doesn't match!");
            }
            else
            {
                string query = "INSERT INTO `user` (`fname`, `lname`, `email`, `mobile`, `password`, `user_type_id`, `title_id`, `status_id`) " +
                "VALUES ('" + fname + "', '" + lname + "', '" + email + "', '" + mobile + "', '" + pass + "', '2', '1', '1')";
                MySQL.Execute(query);

                int uid = MySQL.LastInsertID();
                RegisterPosition(uid);
                RegisterAddress(uid);
            }
        }

        private void RegisterPosition(int uid)
        {
            if (departmentComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select Department of Employee!");
            }
            else if (designationComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select Designation of Employee!");
            }
            else
            {
                string department = departmentComboBox.SelectedItem == null ? "1" : (string)departmentComboBox.SelectedItem;
                string designation = designationComboBox.SelectedItem == null ? "4" : (string)designationComboBox.SelectedItem;

                string query = "UPDATE `user` SET `department_id`='1', `designation_id`='1' WHERE `uid`='" + uid + "'";
                MySQL.Execute(query);
            }
        }

        private void RegisterAddress(int uid)
        {
            string line1 = line1Box.Text;
            string line2 = line2Box.Text;
            string city = cityBox.Text;
            string pcode = pcodeBox.Text;

            if (!(line1.Trim().Equals("") || line2.Trim().Equals("") || city.Trim().Equals("") || pcode.Trim().Equals("")))
            {
                if (line1.Trim().Equals(""))
                {
                    MessageBox.Show("Please enter Line 1 of Employee Address!");
                }
                else if (city.Trim().Equals(""))
                {
                    MessageBox.Show("Please enter City of Employee Address!");
                }
                else if (pcode.Trim().Equals(""))
                {
                    MessageBox.Show("Please enter Postal Code of Employee Address!");
                }
                else
                {
                    string query = "INSERT INTO `address` (`user_uid`, `line1`, `line2`, `city`, `pcode`) VALUES ('" + uid + "', '" + line1 + "', '" + line2 + "', '" + city + "', '" + pcode + "')";
                    MySQL.Execute(query);
                }
            }

        }
    }
}
