using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System.ewision.sahan.model
{
    public class Employee
    {
        public string Fname { get; set; }
        public string Lame { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public bool Status { get; set; }
        public string Title { get; set; }

        public Employee(string fname, string lame, string email, string mobile, bool status, string title)
        {
            Fname = fname;
            Lame = lame;
            Email = email;
            Mobile = mobile;
            Status = status;
            Title = title;
        }
    }
}
