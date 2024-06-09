namespace Employee_Management_System
{
    partial class user_login
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
            passwordBox = new TextBox();
            label2 = new Label();
            usernameBox = new TextBox();
            label3 = new Label();
            button2 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(34, 113, 221);
            panel1.Controls.Add(passwordBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(usernameBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(321, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(554, 481);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // passwordBox
            // 
            passwordBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordBox.Location = new Point(85, 277);
            passwordBox.MaximumSize = new Size(38300, 28);
            passwordBox.MaxLength = 30;
            passwordBox.MinimumSize = new Size(383, 28);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(383, 28);
            passwordBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(76, 237);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 7;
            label2.Text = "Password :";
            // 
            // usernameBox
            // 
            usernameBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usernameBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameBox.Location = new Point(85, 177);
            usernameBox.MaximumSize = new Size(38300, 28);
            usernameBox.MaxLength = 120;
            usernameBox.MinimumSize = new Size(383, 28);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(383, 28);
            usernameBox.TabIndex = 6;
            usernameBox.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(76, 134);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 5;
            label3.Text = "Username :";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.AutoSize = true;
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(85, 350);
            button2.Name = "button2";
            button2.Size = new Size(90, 36);
            button2.TabIndex = 3;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(212, 56);
            label1.Name = "label1";
            label1.Size = new Size(136, 32);
            label1.TabIndex = 0;
            label1.Text = "User Login";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // user_login
            // 
            AutoScaleDimensions = new SizeF(106F, 106F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1121, 787);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "user_login";
            Opacity = 0.98D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "user_login";
            WindowState = FormWindowState.Maximized;
            Load += user_login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Label label1;
        private Label label3;
        private TextBox usernameBox;
        private TextBox passwordBox;
        private Label label2;
    }
}