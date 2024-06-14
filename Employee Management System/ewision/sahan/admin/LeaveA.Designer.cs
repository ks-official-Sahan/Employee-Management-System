namespace Employee_Management_System.admin_dashboard_pages
{
    partial class LeaveA
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
            leaaveTable = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewButtonColumn();
            Column5 = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)leaaveTable).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(66, 178, 167);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(410, 649);
            button1.Name = "button1";
            button1.Size = new Size(150, 43);
            button1.TabIndex = 25;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(leaaveTable);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(947, 603);
            panel1.TabIndex = 26;
            // 
            // leaaveTable
            // 
            leaaveTable.AllowUserToAddRows = false;
            leaaveTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            leaaveTable.BackgroundColor = SystemColors.ButtonHighlight;
            leaaveTable.BorderStyle = BorderStyle.Fixed3D;
            leaaveTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            leaaveTable.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            leaaveTable.Cursor = Cursors.Hand;
            leaaveTable.GridColor = SystemColors.Window;
            leaaveTable.Location = new Point(16, 243);
            leaaveTable.Name = "leaaveTable";
            leaaveTable.Size = new Size(917, 343);
            leaaveTable.TabIndex = 1;
            leaaveTable.CellClick += leaaveTable_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Employee Name";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Mobile";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Leave Data";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Accept";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Decline";
            Column5.Name = "Column5";
            // 
            // LeaveA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(971, 725);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "LeaveA";
            Text = "Leave";
            Load += Leave_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)leaaveTable).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Panel panel1;
        private DataGridView leaaveTable;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewButtonColumn Column4;
        private DataGridViewButtonColumn Column5;
    }
}