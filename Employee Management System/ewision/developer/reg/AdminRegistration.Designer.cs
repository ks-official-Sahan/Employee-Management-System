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
            accessCodeBox = new TextBox();
            lnameBox = new TextBox();
            fnameBox = new TextBox();
            label3 = new Label();
            titleComboBox = new ComboBox();
            label1 = new Label();
            panel2 = new Panel();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            Register = new Button();
            cPasswordBox = new TextBox();
            passwordBox = new TextBox();
            emailBox = new TextBox();
            mobileBox = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 239, 220);
            panel1.Controls.Add(accessCodeBox);
            panel1.Controls.Add(lnameBox);
            panel1.Controls.Add(fnameBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(titleComboBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(128, 131);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 671);
            panel1.TabIndex = 0;
            // 
            // accessCodeBox
            // 
            accessCodeBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            accessCodeBox.BackColor = Color.White;
            accessCodeBox.BorderStyle = BorderStyle.None;
            accessCodeBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accessCodeBox.ForeColor = Color.DimGray;
            accessCodeBox.Location = new Point(50, 378);
            accessCodeBox.Margin = new Padding(3, 4, 3, 4);
            accessCodeBox.MaximumSize = new Size(438, 28);
            accessCodeBox.MinimumSize = new Size(175, 28);
            accessCodeBox.Name = "accessCodeBox";
            accessCodeBox.PasswordChar = '*';
            accessCodeBox.PlaceholderText = "Access Code";
            accessCodeBox.Size = new Size(433, 28);
            accessCodeBox.TabIndex = 9;
            // 
            // lnameBox
            // 
            lnameBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lnameBox.BackColor = Color.White;
            lnameBox.BorderStyle = BorderStyle.None;
            lnameBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnameBox.ForeColor = Color.DimGray;
            lnameBox.Location = new Point(50, 307);
            lnameBox.Margin = new Padding(3, 4, 3, 4);
            lnameBox.MaximumSize = new Size(438, 28);
            lnameBox.MinimumSize = new Size(175, 28);
            lnameBox.Name = "lnameBox";
            lnameBox.PlaceholderText = " Last Name";
            lnameBox.Size = new Size(433, 28);
            lnameBox.TabIndex = 8;
            // 
            // fnameBox
            // 
            fnameBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fnameBox.BackColor = Color.White;
            fnameBox.BorderStyle = BorderStyle.None;
            fnameBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fnameBox.ForeColor = Color.DimGray;
            fnameBox.Location = new Point(50, 235);
            fnameBox.Margin = new Padding(3, 4, 3, 4);
            fnameBox.MaximumSize = new Size(438, 28);
            fnameBox.MinimumSize = new Size(175, 28);
            fnameBox.Name = "fnameBox";
            fnameBox.PlaceholderText = "First Name";
            fnameBox.Size = new Size(433, 28);
            fnameBox.TabIndex = 7;
            fnameBox.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(50, 122);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 6;
            label3.Text = "Title :";
            // 
            // titleComboBox
            // 
            titleComboBox.BackColor = Color.White;
            titleComboBox.ForeColor = Color.Black;
            titleComboBox.FormattingEnabled = true;
            titleComboBox.Items.AddRange(new object[] { "Select", "Mr", "Mrs", "Miss" });
            titleComboBox.Location = new Point(50, 159);
            titleComboBox.Margin = new Padding(3, 4, 3, 4);
            titleComboBox.MaximumSize = new Size(410, 0);
            titleComboBox.MinimumSize = new Size(433, 0);
            titleComboBox.Name = "titleComboBox";
            titleComboBox.Size = new Size(433, 28);
            titleComboBox.TabIndex = 2;
            titleComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 128, 255);
            label1.Location = new Point(38, 48);
            label1.Name = "label1";
            label1.Size = new Size(369, 37);
            label1.TabIndex = 1;
            label1.Text = "Admin's General Information";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 128, 255);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(Register);
            panel2.Controls.Add(cPasswordBox);
            panel2.Controls.Add(passwordBox);
            panel2.Controls.Add(emailBox);
            panel2.Controls.Add(mobileBox);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(695, 131);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(569, 671);
            panel2.TabIndex = 1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(229, 542);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(46, 20);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 542);
            label2.Name = "label2";
            label2.Size = new Size(173, 20);
            label2.TabIndex = 13;
            label2.Text = "Already has an account? ";
            // 
            // Register
            // 
            Register.AutoSize = true;
            Register.BackColor = Color.White;
            Register.FlatStyle = FlatStyle.Flat;
            Register.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            Register.ForeColor = Color.Black;
            Register.Location = new Point(50, 464);
            Register.Margin = new Padding(3, 4, 3, 4);
            Register.Name = "Register";
            Register.Size = new Size(103, 42);
            Register.TabIndex = 12;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = false;
            Register.Click += Register_Click;
            // 
            // cPasswordBox
            // 
            cPasswordBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cPasswordBox.BackColor = Color.White;
            cPasswordBox.BorderStyle = BorderStyle.None;
            cPasswordBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cPasswordBox.ForeColor = Color.DimGray;
            cPasswordBox.Location = new Point(50, 378);
            cPasswordBox.Margin = new Padding(3, 4, 3, 4);
            cPasswordBox.MaximumSize = new Size(438, 28);
            cPasswordBox.MinimumSize = new Size(175, 28);
            cPasswordBox.Name = "cPasswordBox";
            cPasswordBox.PasswordChar = '*';
            cPasswordBox.PlaceholderText = "Confirm Password";
            cPasswordBox.Size = new Size(438, 28);
            cPasswordBox.TabIndex = 11;
            // 
            // passwordBox
            // 
            passwordBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordBox.BackColor = Color.White;
            passwordBox.BorderStyle = BorderStyle.None;
            passwordBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordBox.ForeColor = Color.DimGray;
            passwordBox.Location = new Point(50, 294);
            passwordBox.Margin = new Padding(3, 4, 3, 4);
            passwordBox.MaximumSize = new Size(438, 28);
            passwordBox.MinimumSize = new Size(175, 28);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.PlaceholderText = " Password";
            passwordBox.Size = new Size(438, 28);
            passwordBox.TabIndex = 10;
            // 
            // emailBox
            // 
            emailBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            emailBox.BackColor = Color.White;
            emailBox.BorderStyle = BorderStyle.None;
            emailBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailBox.ForeColor = Color.DimGray;
            emailBox.Location = new Point(50, 208);
            emailBox.Margin = new Padding(3, 4, 3, 4);
            emailBox.MaximumSize = new Size(438, 28);
            emailBox.MinimumSize = new Size(175, 28);
            emailBox.Name = "emailBox";
            emailBox.PlaceholderText = " Your Email";
            emailBox.Size = new Size(438, 28);
            emailBox.TabIndex = 9;
            // 
            // mobileBox
            // 
            mobileBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mobileBox.BackColor = Color.White;
            mobileBox.BorderStyle = BorderStyle.None;
            mobileBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mobileBox.ForeColor = Color.DimGray;
            mobileBox.Location = new Point(50, 126);
            mobileBox.Margin = new Padding(3, 4, 3, 4);
            mobileBox.MaximumSize = new Size(438, 28);
            mobileBox.MinimumSize = new Size(175, 28);
            mobileBox.Name = "mobileBox";
            mobileBox.PlaceholderText = " Phone Number";
            mobileBox.Size = new Size(438, 28);
            mobileBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(50, 48);
            label4.Name = "label4";
            label4.Size = new Size(203, 37);
            label4.TabIndex = 2;
            label4.Text = "Contact Details";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // admin_reg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1354, 1018);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "admin_reg";
            StartPosition = FormStartPosition.CenterScreen;
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
        private ComboBox titleComboBox;
        private Label label3;
        private TextBox fnameBox;
        private TextBox lnameBox;
        private Panel panel2;
        private TextBox cPasswordBox;
        private TextBox passwordBox;
        private TextBox emailBox;
        private TextBox mobileBox;
        private Label label4;
        private Button Register;
        private TextBox accessCodeBox;
        private LinkLabel linkLabel1;
        private Label label2;
    }
}