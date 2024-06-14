namespace Employee_Management_System.admin_dashboard_pages
{
    partial class Notifications
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
            button1 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(26, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 603);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(66, 178, 167);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(419, 651);
            button1.Name = "button1";
            button1.Size = new Size(124, 43);
            button1.TabIndex = 27;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            // 
            // Notifications
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(971, 725);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Notifications";
            Text = "Notifications";
            Load += Notifications_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
    }
}