namespace Employee_Management_System.admin_dashboard_pages
{
    partial class EmployeeRegister
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
            groupBox1 = new GroupBox();
            titleComboBox = new ComboBox();
            label7 = new Label();
            cPaswordBox = new TextBox();
            label6 = new Label();
            passwordBox = new TextBox();
            label5 = new Label();
            emailBox = new TextBox();
            label4 = new Label();
            mobileBox = new TextBox();
            label3 = new Label();
            lnameBox = new TextBox();
            label2 = new Label();
            fnameBox = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            pcodeBox = new TextBox();
            label9 = new Label();
            cityBox = new TextBox();
            label10 = new Label();
            line2Box = new TextBox();
            label11 = new Label();
            line1Box = new TextBox();
            label12 = new Label();
            registerBtn = new Button();
            groupBox3 = new GroupBox();
            designationComboBox = new ComboBox();
            label13 = new Label();
            departmentComboBox = new ComboBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(titleComboBox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cPaswordBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(passwordBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(emailBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(mobileBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lnameBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(fnameBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(938, 358);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee Details";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // titleComboBox
            // 
            titleComboBox.FormattingEnabled = true;
            titleComboBox.Items.AddRange(new object[] { "Mr.", "Mrs.", "Ms." });
            titleComboBox.Location = new Point(132, 42);
            titleComboBox.Name = "titleComboBox";
            titleComboBox.Size = new Size(295, 25);
            titleComboBox.Sorted = true;
            titleComboBox.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 45);
            label7.Name = "label7";
            label7.Size = new Size(32, 17);
            label7.TabIndex = 12;
            label7.Text = "Title";
            // 
            // cPaswordBox
            // 
            cPaswordBox.Location = new Point(605, 291);
            cPaswordBox.Name = "cPaswordBox";
            cPaswordBox.Size = new Size(295, 25);
            cPaswordBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(483, 299);
            label6.Name = "label6";
            label6.Size = new Size(114, 17);
            label6.TabIndex = 10;
            label6.Text = "Confirm Password";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(132, 291);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(295, 25);
            passwordBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 299);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 8;
            label5.Text = "Password";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(132, 227);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(768, 25);
            emailBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 235);
            label4.Name = "label4";
            label4.Size = new Size(39, 17);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // mobileBox
            // 
            mobileBox.Location = new Point(132, 164);
            mobileBox.Name = "mobileBox";
            mobileBox.Size = new Size(295, 25);
            mobileBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 172);
            label3.Name = "label3";
            label3.Size = new Size(49, 17);
            label3.TabIndex = 4;
            label3.Text = "Mobile";
            // 
            // lnameBox
            // 
            lnameBox.Location = new Point(605, 101);
            lnameBox.Name = "lnameBox";
            lnameBox.Size = new Size(295, 25);
            lnameBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(483, 109);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // fnameBox
            // 
            fnameBox.Location = new Point(132, 101);
            fnameBox.Name = "fnameBox";
            fnameBox.Size = new Size(295, 25);
            fnameBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 109);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pcodeBox);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(cityBox);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(line2Box);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(line1Box);
            groupBox2.Controls.Add(label12);
            groupBox2.Enabled = false;
            groupBox2.Location = new Point(12, 474);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(938, 159);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Employee Address";
            // 
            // pcodeBox
            // 
            pcodeBox.Location = new Point(615, 98);
            pcodeBox.Name = "pcodeBox";
            pcodeBox.Size = new Size(295, 25);
            pcodeBox.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(493, 106);
            label9.Name = "label9";
            label9.Size = new Size(78, 17);
            label9.TabIndex = 6;
            label9.Text = "Postal Code";
            // 
            // cityBox
            // 
            cityBox.Location = new Point(142, 98);
            cityBox.Name = "cityBox";
            cityBox.Size = new Size(295, 25);
            cityBox.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 106);
            label10.Name = "label10";
            label10.Size = new Size(29, 17);
            label10.TabIndex = 4;
            label10.Text = "City";
            // 
            // line2Box
            // 
            line2Box.Location = new Point(615, 35);
            line2Box.Name = "line2Box";
            line2Box.Size = new Size(295, 25);
            line2Box.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(493, 43);
            label11.Name = "label11";
            label11.Size = new Size(42, 17);
            label11.TabIndex = 2;
            label11.Text = "Line 2";
            // 
            // line1Box
            // 
            line1Box.Location = new Point(142, 35);
            line1Box.Name = "line1Box";
            line1Box.Size = new Size(295, 25);
            line1Box.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(20, 43);
            label12.Name = "label12";
            label12.Size = new Size(42, 17);
            label12.TabIndex = 0;
            label12.Text = "Line 1";
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(417, 650);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(130, 47);
            registerBtn.TabIndex = 13;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(designationComboBox);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(departmentComboBox);
            groupBox3.Controls.Add(label8);
            groupBox3.Enabled = false;
            groupBox3.Location = new Point(12, 376);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(938, 92);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Employee Position";
            // 
            // designationComboBox
            // 
            designationComboBox.FormattingEnabled = true;
            designationComboBox.Items.AddRange(new object[] { "Coordinator", "Developer", "Director", "Manager" });
            designationComboBox.Location = new Point(605, 40);
            designationComboBox.Name = "designationComboBox";
            designationComboBox.Size = new Size(295, 25);
            designationComboBox.Sorted = true;
            designationComboBox.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(483, 43);
            label13.Name = "label13";
            label13.Size = new Size(77, 17);
            label13.TabIndex = 14;
            label13.Text = "Designation";
            // 
            // departmentComboBox
            // 
            departmentComboBox.FormattingEnabled = true;
            departmentComboBox.Items.AddRange(new object[] { "Mr.", "Mrs.", "Ms." });
            departmentComboBox.Location = new Point(132, 40);
            departmentComboBox.Name = "departmentComboBox";
            departmentComboBox.Size = new Size(295, 25);
            departmentComboBox.Sorted = true;
            departmentComboBox.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 43);
            label8.Name = "label8";
            label8.Size = new Size(77, 17);
            label8.TabIndex = 14;
            label8.Text = "Department";
            // 
            // EmployeeRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 709);
            Controls.Add(groupBox3);
            Controls.Add(registerBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmployeeRegister";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeRegister";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox lnameBox;
        private Label label2;
        private TextBox fnameBox;
        private Label label1;
        private TextBox passwordBox;
        private Label label5;
        private TextBox emailBox;
        private Label label4;
        private TextBox mobileBox;
        private Label label3;
        private TextBox cPaswordBox;
        private Label label6;
        private GroupBox groupBox2;
        private TextBox pcodeBox;
        private Label label9;
        private TextBox cityBox;
        private Label label10;
        private TextBox line2Box;
        private Label label11;
        private TextBox line1Box;
        private Label label12;
        private Button registerBtn;
        private ComboBox titleComboBox;
        private Label label7;
        private GroupBox groupBox3;
        private ComboBox designationComboBox;
        private Label label13;
        private ComboBox departmentComboBox;
        private Label label8;
    }
}