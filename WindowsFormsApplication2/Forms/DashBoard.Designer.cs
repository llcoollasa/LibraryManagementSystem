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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnBorrowings = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearchIssuedBook = new System.Windows.Forms.Button();
            this.txtIssuedBooksBookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIssuedBookMemberName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.chkBookStatusAvailable = new System.Windows.Forms.CheckBox();
            this.btnSearchBookStatus = new System.Windows.Forms.Button();
            this.txtBookStatusBookName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(653, 14);
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
            this.btnCategory.Location = new System.Drawing.Point(14, 14);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(153, 63);
            this.btnCategory.TabIndex = 2;
            this.btnCategory.Text = "category";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(174, 14);
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
            this.btnMember.Location = new System.Drawing.Point(334, 14);
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
            this.btnBorrowings.Location = new System.Drawing.Point(493, 14);
            this.btnBorrowings.Name = "btnBorrowings";
            this.btnBorrowings.Size = new System.Drawing.Size(153, 63);
            this.btnBorrowings.TabIndex = 5;
            this.btnBorrowings.Text = "Borrowings";
            this.btnBorrowings.UseVisualStyleBackColor = false;
            this.btnBorrowings.Click += new System.EventHandler(this.btnBorrowings_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnSearchIssuedBook);
            this.groupBox1.Controls.Add(this.txtIssuedBooksBookName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIssuedBookMemberName);
            this.groupBox1.Location = new System.Drawing.Point(14, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 383);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Issued Books";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(366, 275);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnSearchIssuedBook
            // 
            this.btnSearchIssuedBook.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSearchIssuedBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchIssuedBook.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchIssuedBook.Location = new System.Drawing.Point(308, 27);
            this.btnSearchIssuedBook.Name = "btnSearchIssuedBook";
            this.btnSearchIssuedBook.Size = new System.Drawing.Size(67, 57);
            this.btnSearchIssuedBook.TabIndex = 4;
            this.btnSearchIssuedBook.Text = "Search";
            this.btnSearchIssuedBook.UseVisualStyleBackColor = false;
            // 
            // txtIssuedBooksBookName
            // 
            this.txtIssuedBooksBookName.Location = new System.Drawing.Point(64, 61);
            this.txtIssuedBooksBookName.Name = "txtIssuedBooksBookName";
            this.txtIssuedBooksBookName.Size = new System.Drawing.Size(238, 23);
            this.txtIssuedBooksBookName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Member";
            // 
            // txtIssuedBookMemberName
            // 
            this.txtIssuedBookMemberName.Location = new System.Drawing.Point(64, 27);
            this.txtIssuedBookMemberName.Name = "txtIssuedBookMemberName";
            this.txtIssuedBookMemberName.Size = new System.Drawing.Size(238, 23);
            this.txtIssuedBookMemberName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.chkBookStatusAvailable);
            this.groupBox2.Controls.Add(this.btnSearchBookStatus);
            this.groupBox2.Controls.Add(this.txtBookStatusBookName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(410, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 383);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book Status";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(9, 102);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(375, 275);
            this.dataGridView2.TabIndex = 6;
            // 
            // chkBookStatusAvailable
            // 
            this.chkBookStatusAvailable.AutoSize = true;
            this.chkBookStatusAvailable.Location = new System.Drawing.Point(63, 56);
            this.chkBookStatusAvailable.Name = "chkBookStatusAvailable";
            this.chkBookStatusAvailable.Size = new System.Drawing.Size(74, 19);
            this.chkBookStatusAvailable.TabIndex = 10;
            this.chkBookStatusAvailable.Text = "Available";
            this.chkBookStatusAvailable.UseVisualStyleBackColor = true;
            // 
            // btnSearchBookStatus
            // 
            this.btnSearchBookStatus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSearchBookStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBookStatus.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBookStatus.Location = new System.Drawing.Point(317, 22);
            this.btnSearchBookStatus.Name = "btnSearchBookStatus";
            this.btnSearchBookStatus.Size = new System.Drawing.Size(67, 57);
            this.btnSearchBookStatus.TabIndex = 9;
            this.btnSearchBookStatus.Text = "Search";
            this.btnSearchBookStatus.UseVisualStyleBackColor = false;
            // 
            // txtBookStatusBookName
            // 
            this.txtBookStatusBookName.Location = new System.Drawing.Point(63, 27);
            this.txtBookStatusBookName.Name = "txtBookStatusBookName";
            this.txtBookStatusBookName.Size = new System.Drawing.Size(238, 23);
            this.txtBookStatusBookName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Book";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 505);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnBorrowings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIssuedBooksBookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIssuedBookMemberName;
        private System.Windows.Forms.Button btnSearchIssuedBook;
        private System.Windows.Forms.CheckBox chkBookStatusAvailable;
        private System.Windows.Forms.Button btnSearchBookStatus;
        private System.Windows.Forms.TextBox txtBookStatusBookName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}