namespace Employee_Management_System.admin_dashboard_pages
{
    partial class InsuaranceA
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
            claimsTable = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewButtonColumn();
            Column5 = new DataGridViewButtonColumn();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)claimsTable).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(66, 178, 167);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(422, 761);
            button1.Name = "button1";
            button1.Size = new Size(124, 49);
            button1.TabIndex = 26;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(claimsTable);
            panel1.Location = new Point(25, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 657);
            panel1.TabIndex = 27;
            // 
            // claimsTable
            // 
            claimsTable.AllowUserToAddRows = false;
            claimsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            claimsTable.BackgroundColor = SystemColors.ButtonHighlight;
            claimsTable.BorderStyle = BorderStyle.Fixed3D;
            claimsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            claimsTable.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column6, Column7, Column4, Column5 });
            claimsTable.Cursor = Cursors.Hand;
            claimsTable.GridColor = SystemColors.Window;
            claimsTable.Location = new Point(3, 3);
            claimsTable.Name = "claimsTable";
            claimsTable.RowHeadersWidth = 45;
            claimsTable.Size = new Size(914, 653);
            claimsTable.TabIndex = 28;
            claimsTable.CellClick += claimsTable_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Date";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Description";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column6
            // 
            Column6.HeaderText = "Employer";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Status";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // Column4
            // 
            Column4.HeaderText = "Accept";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Decline";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 18.3396225F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(175, 67);
            label1.TabIndex = 29;
            label1.Text = "Claims";
            // 
            // InsuaranceA
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(970, 822);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "InsuaranceA";
            Text = "Insuarance";
            Load += Insuarance_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)claimsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Panel panel1;
        private DataGridView claimsTable;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewButtonColumn Column4;
        private DataGridViewButtonColumn Column5;
        private Label label1;
    }
}