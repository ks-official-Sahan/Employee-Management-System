namespace Employee_Management_System
{
    partial class admin_reg
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
            name = new TextBox();
            position = new ComboBox();
            label2 = new Label();
            last = new TextBox();
            first = new TextBox();
            label3 = new Label();
            Title = new ComboBox();
            label1 = new Label();
            panel2 = new Panel();
            Register = new Button();
            confirm = new TextBox();
            password = new TextBox();
            email = new TextBox();
            phone = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 239, 220);
            panel1.Controls.Add(name);
            panel1.Controls.Add(position);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(last);
            panel1.Controls.Add(first);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Title);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(112, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(498, 570);
            panel1.TabIndex = 0;
            // 
            // name
            // 
            name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            name.BackColor = Color.White;
            name.BorderStyle = BorderStyle.None;
            name.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.ForeColor = Color.DimGray;
            name.Location = new Point(44, 329);
            name.MaximumSize = new Size(383, 28);
            name.MinimumSize = new Size(153, 28);
            name.Name = "name";
            name.Size = new Size(376, 20);
            name.TabIndex = 11;
            name.Text = " Name With Initials";
            // 
            // position
            // 
            position.AutoCompleteCustomSource.AddRange(new string[] { "Director", "Manager" });
            position.BackColor = Color.White;
            position.ForeColor = Color.Black;
            position.FormattingEnabled = true;
            position.Items.AddRange(new object[] { "Select", "Director", "Manager" });
            position.Location = new Point(44, 274);
            position.MaximumSize = new Size(359, 0);
            position.MinimumSize = new Size(379, 0);
            position.Name = "position";
            position.Size = new Size(379, 25);
            position.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(44, 248);
            label2.Name = "label2";
            label2.Size = new Size(79, 23);
            label2.TabIndex = 9;
            label2.Text = "Position :";
            // 
            // last
            // 
            last.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            last.BackColor = Color.White;
            last.BorderStyle = BorderStyle.None;
            last.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            last.ForeColor = Color.DimGray;
            last.Location = new Point(238, 192);
            last.MaximumSize = new Size(383, 28);
            last.MinimumSize = new Size(153, 28);
            last.Name = "last";
            last.Size = new Size(182, 20);
            last.TabIndex = 8;
            last.Text = " Last Name";
            // 
            // first
            // 
            first.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            first.BackColor = Color.White;
            first.BorderStyle = BorderStyle.None;
            first.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            first.ForeColor = Color.DimGray;
            first.Location = new Point(44, 192);
            first.MaximumSize = new Size(383, 28);
            first.MinimumSize = new Size(153, 28);
            first.Name = "first";
            first.Size = new Size(182, 20);
            first.TabIndex = 7;
            first.Text = " First Name";
            first.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(44, 104);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 6;
            label3.Text = "Title :";
            // 
            // Title
            // 
            Title.BackColor = Color.White;
            Title.ForeColor = Color.Black;
            Title.FormattingEnabled = true;
            Title.Items.AddRange(new object[] { "Select", "Mr", "Mrs", "Miss" });
            Title.Location = new Point(44, 135);
            Title.MaximumSize = new Size(359, 0);
            Title.MinimumSize = new Size(379, 0);
            Title.Name = "Title";
            Title.Size = new Size(379, 25);
            Title.TabIndex = 2;
            Title.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 128, 255);
            label1.Location = new Point(33, 41);
            label1.Name = "label1";
            label1.Size = new Size(327, 32);
            label1.TabIndex = 1;
            label1.Text = "Admin's General Information";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 128, 255);
            panel2.Controls.Add(Register);
            panel2.Controls.Add(confirm);
            panel2.Controls.Add(password);
            panel2.Controls.Add(email);
            panel2.Controls.Add(phone);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(608, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(498, 570);
            panel2.TabIndex = 1;
            // 
            // Register
            // 
            Register.AutoSize = true;
            Register.BackColor = Color.White;
            Register.FlatStyle = FlatStyle.Flat;
            Register.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            Register.ForeColor = Color.Black;
            Register.Location = new Point(44, 394);
            Register.Name = "Register";
            Register.Size = new Size(90, 36);
            Register.TabIndex = 12;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = false;
            Register.Click += Register_Click;
            // 
            // confirm
            // 
            confirm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            confirm.BackColor = Color.White;
            confirm.BorderStyle = BorderStyle.None;
            confirm.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirm.ForeColor = Color.DimGray;
            confirm.Location = new Point(44, 321);
            confirm.MaximumSize = new Size(383, 28);
            confirm.MinimumSize = new Size(153, 28);
            confirm.Name = "confirm";
            confirm.Size = new Size(383, 20);
            confirm.TabIndex = 11;
            confirm.Text = "Confirm Password";
            // 
            // password
            // 
            password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            password.BackColor = Color.White;
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password.ForeColor = Color.DimGray;
            password.Location = new Point(44, 250);
            password.MaximumSize = new Size(383, 28);
            password.MinimumSize = new Size(153, 28);
            password.Name = "password";
            password.Size = new Size(383, 20);
            password.TabIndex = 10;
            password.Text = " Password";
            // 
            // email
            // 
            email.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            email.BackColor = Color.White;
            email.BorderStyle = BorderStyle.None;
            email.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email.ForeColor = Color.DimGray;
            email.Location = new Point(44, 177);
            email.MaximumSize = new Size(383, 28);
            email.MinimumSize = new Size(153, 28);
            email.Name = "email";
            email.Size = new Size(383, 20);
            email.TabIndex = 9;
            email.Text = " Your Email";
            // 
            // phone
            // 
            phone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            phone.BackColor = Color.White;
            phone.BorderStyle = BorderStyle.None;
            phone.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phone.ForeColor = Color.DimGray;
            phone.Location = new Point(44, 107);
            phone.MaximumSize = new Size(383, 28);
            phone.MinimumSize = new Size(153, 28);
            phone.Name = "phone";
            phone.Size = new Size(383, 20);
            phone.TabIndex = 8;
            phone.Text = " Phone Number";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(44, 41);
            label4.Name = "label4";
            label4.Size = new Size(180, 32);
            label4.TabIndex = 2;
            label4.Text = "Contact Details";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // admin_reg
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1185, 865);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "admin_reg";
            Text = "admin_reg";
            Load += admin_reg_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox Title;
        private Label label3;
        private TextBox first;
        private TextBox last;
        private TextBox name;
        private ComboBox position;
        private Label label2;
        private Panel panel2;
        private TextBox confirm;
        private TextBox password;
        private TextBox email;
        private TextBox phone;
        private Label label4;
        private Button Register;
    }
}