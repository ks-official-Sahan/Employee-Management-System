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
            label1 = new Label();
            fnameBox = new TextBox();
            lnameBox = new TextBox();
            label2 = new Label();
            mobileBox = new TextBox();
            label3 = new Label();
            emailBox = new TextBox();
            label4 = new Label();
            passwordBox = new TextBox();
            label5 = new Label();
            cpaswordBox = new TextBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            pcodeBox = new TextBox();
            label9 = new Label();
            cityBox = new TextBox();
            label10 = new Label();
            line2Box = new TextBox();
            label11 = new Label();
            line1Box = new TextBox();
            label12 = new Label();
            addCountryBox = new TextBox();
            label7 = new Label();
            addCountryBtn = new Button();
            countrySelect = new ComboBox();
            registerBtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cpaswordBox);
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
            groupBox1.Size = new Size(938, 290);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee Details";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 43);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // fnameBox
            // 
            fnameBox.Location = new Point(142, 35);
            fnameBox.Name = "fnameBox";
            fnameBox.Size = new Size(295, 25);
            fnameBox.TabIndex = 1;
            // 
            // lnameBox
            // 
            lnameBox.Location = new Point(615, 35);
            lnameBox.Name = "lnameBox";
            lnameBox.Size = new Size(295, 25);
            lnameBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(493, 43);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // mobileBox
            // 
            mobileBox.Location = new Point(142, 98);
            mobileBox.Name = "mobileBox";
            mobileBox.Size = new Size(295, 25);
            mobileBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 106);
            label3.Name = "label3";
            label3.Size = new Size(49, 17);
            label3.TabIndex = 4;
            label3.Text = "Mobile";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(142, 161);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(768, 25);
            emailBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 169);
            label4.Name = "label4";
            label4.Size = new Size(39, 17);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(142, 225);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(295, 25);
            passwordBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 233);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 8;
            label5.Text = "Password";
            // 
            // cpaswordBox
            // 
            cpaswordBox.Location = new Point(615, 225);
            cpaswordBox.Name = "cpaswordBox";
            cpaswordBox.Size = new Size(295, 25);
            cpaswordBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(493, 233);
            label6.Name = "label6";
            label6.Size = new Size(114, 17);
            label6.TabIndex = 10;
            label6.Text = "Confirm Password";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(countrySelect);
            groupBox2.Controls.Add(addCountryBtn);
            groupBox2.Controls.Add(addCountryBox);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(pcodeBox);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(cityBox);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(line2Box);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(line1Box);
            groupBox2.Controls.Add(label12);
            groupBox2.Enabled = false;
            groupBox2.Location = new Point(12, 324);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(938, 290);
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
            // addCountryBox
            // 
            addCountryBox.Location = new Point(142, 215);
            addCountryBox.Name = "addCountryBox";
            addCountryBox.Size = new Size(197, 25);
            addCountryBox.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 166);
            label7.Name = "label7";
            label7.Size = new Size(53, 17);
            label7.TabIndex = 8;
            label7.Text = "Country";
            // 
            // addCountryBtn
            // 
            addCountryBtn.Location = new Point(354, 215);
            addCountryBtn.Name = "addCountryBtn";
            addCountryBtn.Size = new Size(83, 25);
            addCountryBtn.TabIndex = 10;
            addCountryBtn.Text = "Add Country";
            addCountryBtn.UseVisualStyleBackColor = true;
            // 
            // countrySelect
            // 
            countrySelect.FormattingEnabled = true;
            countrySelect.Location = new Point(142, 163);
            countrySelect.Name = "countrySelect";
            countrySelect.Size = new Size(295, 25);
            countrySelect.TabIndex = 11;
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(417, 632);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(130, 47);
            registerBtn.TabIndex = 13;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = true;
            // 
            // EmployeeRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 709);
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
        private TextBox cpaswordBox;
        private Label label6;
        private GroupBox groupBox2;
        private TextBox addCountryBox;
        private Label label7;
        private TextBox pcodeBox;
        private Label label9;
        private TextBox cityBox;
        private Label label10;
        private TextBox line2Box;
        private Label label11;
        private TextBox line1Box;
        private Label label12;
        private ComboBox countrySelect;
        private Button addCountryBtn;
        private Button registerBtn;
    }
}