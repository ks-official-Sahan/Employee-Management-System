using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System.ewision.sahan.model
{
    internal class test
    {
        private void loadComboEmail()
        {
            string path = Directory.GetCurrentDirectory();
            string build = (path + "\\" + "email.txt");
            string[] lines = System.IO.File.ReadAllLines(build);

            //comboEmail.Items.AddRange(lines);
            //comboEmail.SelectedIndex = 0;
        }
    }
}
