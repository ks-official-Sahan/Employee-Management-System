namespace Employee_Management_System
{
    partial class UserDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelMenu = new FlowLayoutPanel();
            Health = new Button();
            Profile = new Button();
            Leave = new Button();
            insuarance = new Button();
            notification = new Button();
            community = new Button();
            panelDesktopPane = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 40);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(76, 10);
            label1.Name = "label1";
            label1.Size = new Size(228, 20);
            label1.TabIndex = 1;
            label1.Text = "Employee Management system";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(22, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 128, 255);
            panelMenu.Controls.Add(Health);
            panelMenu.Controls.Add(Profile);
            panelMenu.Controls.Add(Leave);
            panelMenu.Controls.Add(insuarance);
            panelMenu.Controls.Add(notification);
            panelMenu.Controls.Add(community);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 40);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(234, 822);
            panelMenu.TabIndex = 1;
            // 
            // Health
            // 
            Health.BackColor = Color.FromArgb(0, 128, 255);
            Health.Cursor = Cursors.Hand;
            Health.FlatAppearance.BorderSize = 0;
            Health.FlatStyle = FlatStyle.Flat;
            Health.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Health.ForeColor = Color.White;
            Health.ImageAlign = ContentAlignment.MiddleLeft;
            Health.Location = new Point(3, 3);
            Health.Name = "Health";
            Health.Size = new Size(234, 83);
            Health.TabIndex = 3;
            Health.Text = "Health Status";
            Health.UseVisualStyleBackColor = false;
            Health.Click += Health_Click;
            // 
            // Profile
            // 
            Profile.BackColor = Color.FromArgb(0, 128, 255);
            Profile.Cursor = Cursors.Hand;
            Profile.FlatAppearance.BorderSize = 0;
            Profile.FlatStyle = FlatStyle.Flat;
            Profile.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Profile.ForeColor = Color.White;
            Profile.ImageAlign = ContentAlignment.MiddleLeft;
            Profile.Location = new Point(3, 92);
            Profile.Name = "Profile";
            Profile.Size = new Size(234, 88);
            Profile.TabIndex = 2;
            Profile.Text = "My Profile";
            Profile.UseVisualStyleBackColor = false;
            Profile.Click += Profile_Click;
            // 
            // Leave
            // 
            Leave.BackColor = Color.FromArgb(0, 128, 255);
            Leave.Cursor = Cursors.Hand;
            Leave.FlatAppearance.BorderSize = 0;
            Leave.FlatStyle = FlatStyle.Flat;
            Leave.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Leave.ForeColor = Color.White;
            Leave.ImageAlign = ContentAlignment.MiddleLeft;
            Leave.Location = new Point(3, 186);
            Leave.Name = "Leave";
            Leave.Size = new Size(234, 88);
            Leave.TabIndex = 4;
            Leave.Text = "   Submit a Leave";
            Leave.UseVisualStyleBackColor = false;
            Leave.Click += Leave_Click;
            // 
            // insuarance
            // 
            insuarance.BackColor = Color.FromArgb(0, 128, 255);
            insuarance.Cursor = Cursors.Hand;
            insuarance.FlatAppearance.BorderSize = 0;
            insuarance.FlatStyle = FlatStyle.Flat;
            insuarance.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            insuarance.ForeColor = Color.White;
            insuarance.ImageAlign = ContentAlignment.MiddleLeft;
            insuarance.Location = new Point(3, 280);
            insuarance.Name = "insuarance";
            insuarance.Size = new Size(234, 88);
            insuarance.TabIndex = 5;
            insuarance.Text = "     Insuarance Claim";
            insuarance.UseVisualStyleBackColor = false;
            insuarance.Click += insuarance_Click;
            // 
            // notification
            // 
            notification.BackColor = Color.FromArgb(0, 128, 255);
            notification.Cursor = Cursors.Hand;
            notification.FlatAppearance.BorderSize = 0;
            notification.FlatStyle = FlatStyle.Flat;
            notification.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            notification.ForeColor = Color.White;
            notification.ImageAlign = ContentAlignment.MiddleLeft;
            notification.Location = new Point(3, 374);
            notification.Name = "notification";
            notification.Size = new Size(234, 88);
            notification.TabIndex = 6;
            notification.Text = "Notifications";
            notification.UseVisualStyleBackColor = false;
            notification.Click += notification_Click;
            // 
            // community
            // 
            community.BackColor = Color.FromArgb(0, 128, 255);
            community.Cursor = Cursors.Hand;
            community.FlatAppearance.BorderSize = 0;
            community.FlatStyle = FlatStyle.Flat;
            community.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            community.ForeColor = Color.White;
            community.ImageAlign = ContentAlignment.MiddleLeft;
            community.Location = new Point(3, 468);
            community.Name = "community";
            community.Size = new Size(234, 88);
            community.TabIndex = 7;
            community.Text = "     Community Forum";
            community.UseVisualStyleBackColor = false;
            community.Click += community_Click;
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.BackColor = Color.LightGray;
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(234, 40);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(950, 822);
            panelDesktopPane.TabIndex = 3;
            // 
            // user_dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 862);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelMenu);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "user_dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "user_dashboard";
            Load += user_dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private FlowLayoutPanel panelMenu;
        private Button Profile;
        private Button Health;
        private Button Leave;
        private Button insuarance;
        private Button notification;
        private Button community;
        private Panel panelDesktopPane;
    }
}