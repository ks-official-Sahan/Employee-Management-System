using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System.ewision.sahan.model
{
    public class User
    {
        public string UID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Dob { get; set; }

        public bool Status { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }

        public User(string fname, string lame, string email, string mobile, object dob)
        {
            Fname = fname;
            Lname = lame;
            Email = email;
            Mobile = mobile;
            Dob = string.Format("{0:MM/dd/yyyy}", dob);
        }
        public User(string uid,string fname, string lame, string email, string mobile, object dob)
        {
            UID = uid;
            Fname = fname;
            Lname = lame;
            Email = email;
            Mobile = mobile;
            Dob = string.Format("{0:MM/dd/yyyy}", dob);
        }
    }
}
