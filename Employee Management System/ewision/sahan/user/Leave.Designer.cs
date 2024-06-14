namespace Employee_Management_System.user_dashboard_pages
{
    partial class Leave
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
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            panel1 = new Panel();
            reasonBox = new TextBox();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(34, 733);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(208, 25);
            dateTimePicker1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(66, 178, 167);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(774, 722);
            button1.Name = "button1";
            button1.Size = new Size(150, 49);
            button1.TabIndex = 25;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(34, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(902, 668);
            panel1.TabIndex = 26;
            // 
            // reasonBox
            // 
            reasonBox.Location = new Point(264, 722);
            reasonBox.Multiline = true;
            reasonBox.Name = "reasonBox";
            reasonBox.Size = new Size(490, 49);
            reasonBox.TabIndex = 27;
            // 
            // Leave
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(971, 822);
            Controls.Add(reasonBox);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Name = "Leave";
            Text = "Leave";
            Load += Leave_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Panel panel1;
        private TextBox reasonBox;
    }
}