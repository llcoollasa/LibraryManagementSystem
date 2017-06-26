namespace LibraryManagementSystem.Forms
{
    partial class Borrowings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNewBorrowing = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBorrowings = new System.Windows.Forms.DataGridView();
            this.borrowing_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returning_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowed_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.has_return = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_return = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmbBookName = new System.Windows.Forms.ComboBox();
            this.cmbMemberName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowings)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewBorrowing
            // 
            this.btnNewBorrowing.Location = new System.Drawing.Point(596, 513);
            this.btnNewBorrowing.Name = "btnNewBorrowing";
            this.btnNewBorrowing.Size = new System.Drawing.Size(179, 37);
            this.btnNewBorrowing.TabIndex = 59;
            this.btnNewBorrowing.Text = "Borrowing";
            this.btnNewBorrowing.UseVisualStyleBackColor = true;
            this.btnNewBorrowing.Click += new System.EventHandler(this.btnNewBorrowing_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(781, 513);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(179, 37);
            this.btnCancel.TabIndex = 60;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 23);
            this.label3.TabIndex = 66;
            this.label3.Text = "OR";
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
            this.borrowing_id,
            this.book_id,
            this.member_id,
            this.book_name,
            this.returning_date,
            this.borrowed_date,
            this.fine,
            this.has_return,
            this.btn_return});
            this.dgvBorrowings.Location = new System.Drawing.Point(22, 74);
            this.dgvBorrowings.Name = "dgvBorrowings";
            this.dgvBorrowings.ReadOnly = true;
            this.dgvBorrowings.RowHeadersVisible = false;
            this.dgvBorrowings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowings.Size = new System.Drawing.Size(938, 410);
            this.dgvBorrowings.TabIndex = 65;
            this.dgvBorrowings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrowings_CellContentClick_1);
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
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = "yyyy/mm/dd";
            this.returning_date.DefaultCellStyle = dataGridViewCellStyle2;
            this.returning_date.HeaderText = "Return Date";
            this.returning_date.Name = "returning_date";
            this.returning_date.ReadOnly = true;
            this.returning_date.Width = 110;
            // 
            // borrowed_date
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = "yyyy/mm/dd";
            this.borrowed_date.DefaultCellStyle = dataGridViewCellStyle3;
            this.borrowed_date.HeaderText = "Borrowed Date";
            this.borrowed_date.Name = "borrowed_date";
            this.borrowed_date.ReadOnly = true;
            this.borrowed_date.Width = 120;
            // 
            // fine
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.fine.DefaultCellStyle = dataGridViewCellStyle4;
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
            // btn_return
            // 
            this.btn_return.HeaderText = "Return Book";
            this.btn_return.Name = "btn_return";
            this.btn_return.ReadOnly = true;
            // 
            // cmbBookName
            // 
            this.cmbBookName.FormattingEnabled = true;
            this.cmbBookName.Location = new System.Drawing.Point(466, 25);
            this.cmbBookName.Name = "cmbBookName";
            this.cmbBookName.Size = new System.Drawing.Size(262, 23);
            this.cmbBookName.TabIndex = 63;
            this.cmbBookName.SelectedIndexChanged += new System.EventHandler(this.cmbBookName_SelectedIndexChanged_1);
            // 
            // cmbMemberName
            // 
            this.cmbMemberName.FormattingEnabled = true;
            this.cmbMemberName.Location = new System.Drawing.Point(77, 25);
            this.cmbMemberName.Name = "cmbMemberName";
            this.cmbMemberName.Size = new System.Drawing.Size(262, 23);
            this.cmbMemberName.TabIndex = 64;
            this.cmbMemberName.SelectedIndexChanged += new System.EventHandler(this.cmbMemberName_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 62;
            this.label2.Text = "Book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 61;
            this.label1.Text = "Member";
            // 
            // Borrowings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 571);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvBorrowings);
            this.Controls.Add(this.cmbBookName);
            this.Controls.Add(this.cmbMemberName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewBorrowing);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Borrowings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrowings";
            this.Load += new System.EventHandler(this.Borrowings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewBorrowing;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBorrowings;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowing_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn member_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn returning_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowed_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn fine;
        private System.Windows.Forms.DataGridViewCheckBoxColumn has_return;
        private System.Windows.Forms.DataGridViewButtonColumn btn_return;
        private System.Windows.Forms.ComboBox cmbBookName;
        private System.Windows.Forms.ComboBox cmbMemberName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}