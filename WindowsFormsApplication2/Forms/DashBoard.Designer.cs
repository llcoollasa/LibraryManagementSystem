namespace LibraryManagementSystem.Forms
{
    partial class DashBoard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnBorrowings = new System.Windows.Forms.Button();
            this.btnLibrarian = new System.Windows.Forms.Button();
            this.dgvBorrowings = new System.Windows.Forms.DataGridView();
            this.memberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.has_return = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnReports = new System.Windows.Forms.Button();
            this.lblGreetings = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowings)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 426);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 63);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.Location = new System.Drawing.Point(12, 150);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(153, 63);
            this.btnCategory.TabIndex = 2;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(12, 219);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(153, 63);
            this.btnBook.TabIndex = 3;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMember.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMember.Location = new System.Drawing.Point(12, 81);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(153, 63);
            this.btnMember.TabIndex = 4;
            this.btnMember.Text = "Member";
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnBorrowings
            // 
            this.btnBorrowings.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBorrowings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowings.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowings.Location = new System.Drawing.Point(12, 288);
            this.btnBorrowings.Name = "btnBorrowings";
            this.btnBorrowings.Size = new System.Drawing.Size(153, 63);
            this.btnBorrowings.TabIndex = 5;
            this.btnBorrowings.Text = "Borrowings";
            this.btnBorrowings.UseVisualStyleBackColor = false;
            this.btnBorrowings.Click += new System.EventHandler(this.btnBorrowings_Click);
            // 
            // btnLibrarian
            // 
            this.btnLibrarian.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLibrarian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibrarian.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrarian.Location = new System.Drawing.Point(12, 12);
            this.btnLibrarian.Name = "btnLibrarian";
            this.btnLibrarian.Size = new System.Drawing.Size(153, 63);
            this.btnLibrarian.TabIndex = 8;
            this.btnLibrarian.Text = "Librarian";
            this.btnLibrarian.UseVisualStyleBackColor = false;
            this.btnLibrarian.Click += new System.EventHandler(this.btnLibrarian_Click);
            // 
            // dgvBorrowings
            // 
            this.dgvBorrowings.AllowUserToAddRows = false;
            this.dgvBorrowings.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorrowings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBorrowings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberName,
            this.book_name,
            this.fine,
            this.has_return});
            this.dgvBorrowings.Location = new System.Drawing.Point(182, 12);
            this.dgvBorrowings.Name = "dgvBorrowings";
            this.dgvBorrowings.ReadOnly = true;
            this.dgvBorrowings.RowHeadersVisible = false;
            this.dgvBorrowings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowings.Size = new System.Drawing.Size(954, 408);
            this.dgvBorrowings.TabIndex = 66;
            // 
            // memberName
            // 
            this.memberName.HeaderText = "Member";
            this.memberName.Name = "memberName";
            this.memberName.ReadOnly = true;
            this.memberName.Width = 300;
            // 
            // book_name
            // 
            this.book_name.HeaderText = "Book";
            this.book_name.Name = "book_name";
            this.book_name.ReadOnly = true;
            this.book_name.Width = 480;
            // 
            // fine
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.fine.DefaultCellStyle = dataGridViewCellStyle2;
            this.fine.HeaderText = "Fine";
            this.fine.Name = "fine";
            this.fine.ReadOnly = true;
            this.fine.Width = 70;
            // 
            // has_return
            // 
            this.has_return.HeaderText = "Returned";
            this.has_return.Name = "has_return";
            this.has_return.ReadOnly = true;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(12, 357);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(153, 63);
            this.btnReports.TabIndex = 67;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreetings.Location = new System.Drawing.Point(182, 451);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGreetings.Size = new System.Drawing.Size(391, 26);
            this.lblGreetings.TabIndex = 68;
            this.lblGreetings.Text = "Welcome to AL Library Management System";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 505);
            this.Controls.Add(this.lblGreetings);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.dgvBorrowings);
            this.Controls.Add(this.btnLibrarian);
            this.Controls.Add(this.btnBorrowings);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnBorrowings;
        private System.Windows.Forms.Button btnLibrarian;
        private System.Windows.Forms.DataGridView dgvBorrowings;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn fine;
        private System.Windows.Forms.DataGridViewCheckBoxColumn has_return;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Label lblGreetings;
    }
}