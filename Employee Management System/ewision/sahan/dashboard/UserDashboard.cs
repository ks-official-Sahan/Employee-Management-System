using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class UserDashboard : Form
    {
        private Button currentButton;
        private Random random;
        //private int tempIndex;
        private Form activeForm;

        public UserDashboard()
        {
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = Color.White;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void user_dashboard_Load(object sender, EventArgs e)
        {

        }

        private void Health_Click(object sender, EventArgs e)
        {
            OpenChildForm(new user_dashboard_pages.Health(), sender);
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new user_dashboard_pages.Profile(), sender);
        }

        private void Leave_Click(object sender, EventArgs e)
        {
            OpenChildForm(new user_dashboard_pages.Leave(), sender);
        }

        private void insuarance_Click(object sender, EventArgs e)
        {
            OpenChildForm(new user_dashboard_pages.Insuarance(), sender);
        }

        private void notification_Click(object sender, EventArgs e)
        {
            OpenChildForm(new user_dashboard_pages.Notifications(), sender);
        }

        private void community_Click(object sender, EventArgs e)
        {
            OpenChildForm(new user_dashboard_pages.Community(), sender);
        }
    }
}
