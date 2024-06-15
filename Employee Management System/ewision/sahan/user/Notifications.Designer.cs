namespace Employee_Management_System.user_dashboard_pages
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
            dvg = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvg).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(dvg);
            panel1.Location = new Point(26, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 607);
            panel1.TabIndex = 0;
            // 
            // dvg
            // 
            dvg.AllowUserToAddRows = false;
            dvg.AllowUserToDeleteRows = false;
            dvg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvg.BackgroundColor = SystemColors.ControlLightLight;
            dvg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column4 });
            dvg.GridColor = SystemColors.Window;
            dvg.Location = new Point(0, 0);
            dvg.Name = "dvg";
            dvg.ReadOnly = true;
            dvg.RowHeadersWidth = 45;
            dvg.Size = new Size(920, 607);
            dvg.TabIndex = 28;
            dvg.CellContentClick += dvg_CellContentClick;
            // 
            // Column2
            // 
            Column2.FillWeight = 20F;
            Column2.HeaderText = "Subject";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Resizable = DataGridViewTriState.False;
            // 
            // Column3
            // 
            Column3.FillWeight = 111.1399F;
            Column3.HeaderText = "Content";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.False;
            // 
            // Column4
            // 
            Column4.FillWeight = 30F;
            Column4.HeaderText = "Time";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Resizable = DataGridViewTriState.False;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(66, 178, 167);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(419, 738);
            button1.Name = "button1";
            button1.Size = new Size(124, 49);
            button1.TabIndex = 27;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 18.3396225F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 28);
            label1.Name = "label1";
            label1.Size = new Size(294, 67);
            label1.TabIndex = 28;
            label1.Text = "Notifications";
            // 
            // Notifications
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(971, 822);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Notifications";
            Text = "Notifications";
            Load += Notifications_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private DataGridView dvg;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label1;
    }
}