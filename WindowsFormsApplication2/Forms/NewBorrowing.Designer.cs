namespace LibraryManagementSystem.Forms
{
    partial class NewBorrowing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBookName = new System.Windows.Forms.ComboBox();
            this.cmbMemberName = new System.Windows.Forms.ComboBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCurrentBooks = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpReturningDate = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveNewBorrowing = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBorrowingId = new System.Windows.Forms.TextBox();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.dtpBorrowedDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            this.chkShowReturn = new System.Windows.Forms.CheckBox();
            this.borrowing_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returning_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowed_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.has_return = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Member";
            // 
            // cmbBookName
            // 
            this.cmbBookName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBookName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBookName.FormattingEnabled = true;
            this.cmbBookName.Location = new System.Drawing.Point(116, 95);
            this.cmbBookName.Name = "cmbBookName";
            this.cmbBookName.Size = new System.Drawing.Size(269, 23);
            this.cmbBookName.TabIndex = 2;
            this.cmbBookName.SelectedIndexChanged += new System.EventHandler(this.cmbBookName_SelectedIndexChanged);
            // 
            // cmbMemberName
            // 
            this.cmbMemberName.FormattingEnabled = true;
            this.cmbMemberName.Location = new System.Drawing.Point(116, 60);
            this.cmbMemberName.Name = "cmbMemberName";
            this.cmbMemberName.Size = new System.Drawing.Size(269, 23);
            this.cmbMemberName.TabIndex = 3;
            this.cmbMemberName.SelectedIndexChanged += new System.EventHandler(this.cmbMemberName_SelectedIndexChanged);
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.ForeColor = System.Drawing.Color.Red;
            this.lblAvailable.Location = new System.Drawing.Point(480, 98);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(0, 15);
            this.lblAvailable.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkShowReturn);
            this.groupBox1.Controls.Add(this.dgvCurrentBooks);
            this.groupBox1.Location = new System.Drawing.Point(12, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(959, 272);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Current Books";
            // 
            // dgvCurrentBooks
            // 
            this.dgvCurrentBooks.AllowUserToAddRows = false;
            this.dgvCurrentBooks.AllowUserToDeleteRows = false;
            this.dgvCurrentBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrowing_id,
            this.book_id,
            this.member_id,
            this.book_name,
            this.returning_date,
            this.borrowed_date,
            this.fine,
            this.has_return});
            this.dgvCurrentBooks.Location = new System.Drawing.Point(10, 54);
            this.dgvCurrentBooks.Name = "dgvCurrentBooks";
            this.dgvCurrentBooks.ReadOnly = true;
            this.dgvCurrentBooks.RowHeadersVisible = false;
            this.dgvCurrentBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurrentBooks.Size = new System.Drawing.Size(938, 204);
            this.dgvCurrentBooks.TabIndex = 0;
            this.dgvCurrentBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurrentBooks_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Returning Date";
            // 
            // dtpReturningDate
            // 
            this.dtpReturningDate.CustomFormat = "yyyy/mm/dd";
            this.dtpReturningDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturningDate.Location = new System.Drawing.Point(116, 131);
            this.dtpReturningDate.Name = "dtpReturningDate";
            this.dtpReturningDate.Size = new System.Drawing.Size(110, 23);
            this.dtpReturningDate.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(302, 258);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 27);
            this.btnClear.TabIndex = 74;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveNewBorrowing
            // 
            this.btnSaveNewBorrowing.Location = new System.Drawing.Point(116, 258);
            this.btnSaveNewBorrowing.Name = "btnSaveNewBorrowing";
            this.btnSaveNewBorrowing.Size = new System.Drawing.Size(87, 27);
            this.btnSaveNewBorrowing.TabIndex = 73;
            this.btnSaveNewBorrowing.Text = "Save";
            this.btnSaveNewBorrowing.UseVisualStyleBackColor = true;
            this.btnSaveNewBorrowing.Click += new System.EventHandler(this.btnSaveNewBorrowing_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 75;
            this.label4.Text = "Borrowing Id";
            // 
            // txtBorrowingId
            // 
            this.txtBorrowingId.Location = new System.Drawing.Point(116, 25);
            this.txtBorrowingId.Name = "txtBorrowingId";
            this.txtBorrowingId.ReadOnly = true;
            this.txtBorrowingId.Size = new System.Drawing.Size(100, 23);
            this.txtBorrowingId.TabIndex = 76;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteBook.Location = new System.Drawing.Point(395, 258);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(87, 27);
            this.btnDeleteBook.TabIndex = 78;
            this.btnDeleteBook.Text = "Delete";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(209, 258);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(87, 27);
            this.btnUpdateBook.TabIndex = 77;
            this.btnUpdateBook.Text = "Update";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 75;
            this.label5.Text = "Fine";
            // 
            // txtFine
            // 
            this.txtFine.ForeColor = System.Drawing.Color.Red;
            this.txtFine.Location = new System.Drawing.Point(116, 212);
            this.txtFine.Name = "txtFine";
            this.txtFine.Size = new System.Drawing.Size(100, 23);
            this.txtFine.TabIndex = 76;
            // 
            // dtpBorrowedDate
            // 
            this.dtpBorrowedDate.CustomFormat = "yyyy/mm/dd";
            this.dtpBorrowedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBorrowedDate.Location = new System.Drawing.Point(116, 171);
            this.dtpBorrowedDate.Name = "dtpBorrowedDate";
            this.dtpBorrowedDate.Size = new System.Drawing.Size(110, 23);
            this.dtpBorrowedDate.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 79;
            this.label6.Text = "Borrowed Date";
            // 
            // chkAvailable
            // 
            this.chkAvailable.AutoSize = true;
            this.chkAvailable.Location = new System.Drawing.Point(400, 97);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(74, 19);
            this.chkAvailable.TabIndex = 81;
            this.chkAvailable.Text = "Available";
            this.chkAvailable.UseVisualStyleBackColor = true;
            // 
            // chkShowReturn
            // 
            this.chkShowReturn.AutoSize = true;
            this.chkShowReturn.Location = new System.Drawing.Point(15, 26);
            this.chkShowReturn.Name = "chkShowReturn";
            this.chkShowReturn.Size = new System.Drawing.Size(157, 19);
            this.chkShowReturn.TabIndex = 83;
            this.chkShowReturn.Text = "Include Returned Books ";
            this.chkShowReturn.UseVisualStyleBackColor = true;
            this.chkShowReturn.CheckedChanged += new System.EventHandler(this.chkShowReturn_CheckedChanged);
            // 
            // borrowing_id
            // 
            this.borrowing_id.HeaderText = "id";
            this.borrowing_id.Name = "borrowing_id";
            this.borrowing_id.ReadOnly = true;
            // 
            // book_id
            // 
            this.book_id.HeaderText = "Book Id";
            this.book_id.Name = "book_id";
            this.book_id.ReadOnly = true;
            this.book_id.Visible = false;
            // 
            // member_id
            // 
            this.member_id.HeaderText = "MemberId";
            this.member_id.Name = "member_id";
            this.member_id.ReadOnly = true;
            this.member_id.Visible = false;
            // 
            // book_name
            // 
            this.book_name.HeaderText = "Book";
            this.book_name.Name = "book_name";
            this.book_name.ReadOnly = true;
            this.book_name.Width = 250;
            // 
            // returning_date
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = "yyyy/mm/dd";
            this.returning_date.DefaultCellStyle = dataGridViewCellStyle1;
            this.returning_date.HeaderText = "Return Date";
            this.returning_date.Name = "returning_date";
            this.returning_date.ReadOnly = true;
            this.returning_date.Width = 110;
            // 
            // borrowed_date
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = "yyyy/mm/dd";
            this.borrowed_date.DefaultCellStyle = dataGridViewCellStyle2;
            this.borrowed_date.HeaderText = "Borrowed Date";
            this.borrowed_date.Name = "borrowed_date";
            this.borrowed_date.ReadOnly = true;
            this.borrowed_date.Width = 120;
            // 
            // fine
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.fine.DefaultCellStyle = dataGridViewCellStyle3;
            this.fine.HeaderText = "Fine";
            this.fine.Name = "fine";
            this.fine.ReadOnly = true;
            this.fine.Width = 80;
            // 
            // has_return
            // 
            this.has_return.HeaderText = "Returned";
            this.has_return.Name = "has_return";
            this.has_return.ReadOnly = true;
            // 
            // NewBorrowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 590);
            this.Controls.Add(this.chkAvailable);
            this.Controls.Add(this.dtpBorrowedDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.txtFine);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBorrowingId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSaveNewBorrowing);
            this.Controls.Add(this.dtpReturningDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.cmbMemberName);
            this.Controls.Add(this.cmbBookName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewBorrowing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrowing";
            this.Load += new System.EventHandler(this.NewBorrowing_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBookName;
        private System.Windows.Forms.ComboBox cmbMemberName;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCurrentBooks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpReturningDate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveNewBorrowing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBorrowingId;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.DateTimePicker dtpBorrowedDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkAvailable;
        private System.Windows.Forms.CheckBox chkShowReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowing_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn member_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn returning_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowed_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn fine;
        private System.Windows.Forms.DataGridViewCheckBoxColumn has_return;
    }
}