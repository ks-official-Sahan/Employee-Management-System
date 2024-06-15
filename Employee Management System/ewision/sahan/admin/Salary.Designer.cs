namespace Employee_Management_System.admin_dashboard_pages
{
    partial class Salary
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
            button1 = new Button();
            panel1 = new Panel();
            employeeTable = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewButtonColumn();
            label1 = new Label();
            searchBox = new TextBox();
            employerNameBox = new Label();
            employerIdBox = new Label();
            employerPositionBox = new Label();
            panel2 = new Panel();
            salaryTable = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            bpdBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            countBox = new TextBox();
            label4 = new Label();
            bonusBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            salaryLabel = new Label();
            dateLabel = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeTable).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)salaryTable).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(66, 178, 167);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(857, 17);
            button1.Name = "button1";
            button1.Size = new Size(102, 37);
            button1.TabIndex = 25;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(employeeTable);
            panel1.Location = new Point(12, 155);
            panel1.Name = "panel1";
            panel1.Size = new Size(932, 228);
            panel1.TabIndex = 26;
            // 
            // employeeTable
            // 
            employeeTable.AllowUserToAddRows = false;
            employeeTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            employeeTable.BackgroundColor = SystemColors.ButtonHighlight;
            employeeTable.BorderStyle = BorderStyle.Fixed3D;
            employeeTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeTable.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column6, Column8, Column7, Column4 });
            employeeTable.Cursor = Cursors.Hand;
            employeeTable.GridColor = SystemColors.Window;
            employeeTable.Location = new Point(0, 0);
            employeeTable.Name = "employeeTable";
            employeeTable.RowHeadersWidth = 45;
            employeeTable.Size = new Size(932, 226);
            employeeTable.TabIndex = 1;
            employeeTable.CellClick += leaaveTable_CellClick;
            // 
            // Column1
            // 
            Column1.FillWeight = 40F;
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Email";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.FillWeight = 50F;
            Column3.HeaderText = "Mobile";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column6
            // 
            Column6.HeaderText = "Employer Name";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column8
            // 
            Column8.HeaderText = "Position";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            // 
            // Column7
            // 
            Column7.FillWeight = 45F;
            Column7.HeaderText = "Status";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // Column4
            // 
            Column4.FillWeight = 45F;
            Column4.HeaderText = "Select";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 18.3396225F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 17);
            label1.Name = "label1";
            label1.Size = new Size(401, 67);
            label1.TabIndex = 27;
            label1.Text = "Employers Salary";
            // 
            // searchBox
            // 
            searchBox.Location = new Point(16, 107);
            searchBox.Multiline = true;
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(326, 25);
            searchBox.TabIndex = 28;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // employerNameBox
            // 
            employerNameBox.AutoSize = true;
            employerNameBox.Location = new Point(19, 419);
            employerNameBox.Name = "employerNameBox";
            employerNameBox.Size = new Size(102, 17);
            employerNameBox.TabIndex = 29;
            employerNameBox.Text = "Employer Name";
            // 
            // employerIdBox
            // 
            employerIdBox.AutoSize = true;
            employerIdBox.Location = new Point(306, 419);
            employerIdBox.Name = "employerIdBox";
            employerIdBox.Size = new Size(79, 17);
            employerIdBox.TabIndex = 30;
            employerIdBox.Text = "Employer ID";
            // 
            // employerPositionBox
            // 
            employerPositionBox.AutoSize = true;
            employerPositionBox.Location = new Point(547, 419);
            employerPositionBox.Name = "employerPositionBox";
            employerPositionBox.Size = new Size(113, 17);
            employerPositionBox.TabIndex = 31;
            employerPositionBox.Text = "Employer Position";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(salaryTable);
            panel2.Location = new Point(12, 454);
            panel2.Name = "panel2";
            panel2.Size = new Size(932, 179);
            panel2.TabIndex = 27;
            // 
            // salaryTable
            // 
            salaryTable.AllowUserToAddRows = false;
            salaryTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            salaryTable.BackgroundColor = SystemColors.ButtonHighlight;
            salaryTable.BorderStyle = BorderStyle.Fixed3D;
            salaryTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            salaryTable.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn6, dataGridViewButtonColumn1, Column5, dataGridViewTextBoxColumn5, Column9 });
            salaryTable.Cursor = Cursors.Hand;
            salaryTable.GridColor = SystemColors.Window;
            salaryTable.Location = new Point(0, 0);
            salaryTable.Name = "salaryTable";
            salaryTable.RowHeadersWidth = 45;
            salaryTable.Size = new Size(932, 177);
            salaryTable.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.FillWeight = 40F;
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Employer Email";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Employer Name";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.FillWeight = 60F;
            dataGridViewTextBoxColumn6.HeaderText = "Basic";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.FillWeight = 50F;
            dataGridViewButtonColumn1.HeaderText = "Working Day Count";
            dataGridViewButtonColumn1.MinimumWidth = 6;
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewButtonColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            Column5.FillWeight = 60F;
            Column5.HeaderText = "Bonus";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.FillWeight = 60F;
            dataGridViewTextBoxColumn5.HeaderText = "Salary Date";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Column9
            // 
            Column9.FillWeight = 65F;
            Column9.HeaderText = "Salary";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            // 
            // bpdBox
            // 
            bpdBox.Location = new Point(19, 678);
            bpdBox.Name = "bpdBox";
            bpdBox.RightToLeft = RightToLeft.Yes;
            bpdBox.Size = new Size(121, 25);
            bpdBox.TabIndex = 32;
            bpdBox.TextChanged += bpdBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 658);
            label2.Name = "label2";
            label2.Size = new Size(121, 17);
            label2.TabIndex = 33;
            label2.Text = "Basic Per Day (BPD)";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 658);
            label3.Name = "label3";
            label3.Size = new Size(117, 17);
            label3.TabIndex = 35;
            label3.Text = "Worked Day Count";
            // 
            // countBox
            // 
            countBox.Location = new Point(225, 678);
            countBox.Name = "countBox";
            countBox.RightToLeft = RightToLeft.Yes;
            countBox.Size = new Size(117, 25);
            countBox.TabIndex = 34;
            countBox.TextChanged += countBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(426, 658);
            label4.Name = "label4";
            label4.Size = new Size(43, 17);
            label4.TabIndex = 37;
            label4.Text = "Bonus";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bonusBox
            // 
            bonusBox.Location = new Point(426, 678);
            bonusBox.Name = "bonusBox";
            bonusBox.RightToLeft = RightToLeft.Yes;
            bonusBox.Size = new Size(117, 25);
            bonusBox.TabIndex = 36;
            bonusBox.Text = "0";
            bonusBox.TextChanged += bonusBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(711, 658);
            label5.Name = "label5";
            label5.Size = new Size(74, 17);
            label5.TabIndex = 38;
            label5.Text = "Salary Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(711, 681);
            label6.Name = "label6";
            label6.Size = new Size(35, 17);
            label6.TabIndex = 39;
            label6.Text = "Date";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new Point(857, 681);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.RightToLeft = RightToLeft.Yes;
            salaryLabel.Size = new Size(71, 17);
            salaryLabel.TabIndex = 41;
            salaryLabel.Text = "000000000";
            salaryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(857, 658);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(43, 17);
            dateLabel.TabIndex = 40;
            dateLabel.Text = "Salary";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(66, 178, 167);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(382, 743);
            button2.Name = "button2";
            button2.Size = new Size(198, 37);
            button2.TabIndex = 42;
            button2.Text = "Generate Salary";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(971, 822);
            Controls.Add(button2);
            Controls.Add(salaryLabel);
            Controls.Add(dateLabel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(bonusBox);
            Controls.Add(label3);
            Controls.Add(countBox);
            Controls.Add(label2);
            Controls.Add(bpdBox);
            Controls.Add(panel2);
            Controls.Add(employerPositionBox);
            Controls.Add(employerIdBox);
            Controls.Add(employerNameBox);
            Controls.Add(searchBox);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "Salary";
            Text = "Basic Per Day (BPD)";
            Load += Leave_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)employeeTable).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)salaryTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Panel panel1;
        private DataGridView employeeTable;
        private Label label1;
        private TextBox searchBox;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewButtonColumn Column4;
        private Label employerNameBox;
        private Label employerIdBox;
        private Label employerPositionBox;
        private Panel panel2;
        private DataGridView salaryTable;
        private TextBox bpdBox;
        private Label label2;
        private Label label3;
        private TextBox countBox;
        private Label label4;
        private TextBox bonusBox;
        private Label label5;
        private Label label6;
        private Label salaryLabel;
        private Label dateLabel;
        private Button button2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewButtonColumn1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Column9;
    }
}