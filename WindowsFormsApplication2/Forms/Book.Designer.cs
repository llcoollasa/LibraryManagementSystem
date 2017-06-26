namespace LibraryManagementSystem.Forms
{
    partial class Book
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtPurchaseBillNumber = new System.Windows.Forms.TextBox();
            this.dtpPublicationDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            this.btnSaveBook = new System.Windows.Forms.Button();
            this.btnClearBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publication_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_bill_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.available = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearchBook = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnSortByCategory = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Publication Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Publisher";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Purchase Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Purchase Bill No";
            // 
            // txtBookId
            // 
            this.txtBookId.Enabled = false;
            this.txtBookId.Location = new System.Drawing.Point(134, 32);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.ReadOnly = true;
            this.txtBookId.Size = new System.Drawing.Size(116, 23);
            this.txtBookId.TabIndex = 9;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(134, 103);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(319, 23);
            this.txtAuthor.TabIndex = 10;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(134, 143);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(116, 23);
            this.txtCost.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(134, 183);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(355, 23);
            this.txtName.TabIndex = 12;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(134, 264);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(355, 23);
            this.txtPublisher.TabIndex = 13;
            // 
            // txtPurchaseBillNumber
            // 
            this.txtPurchaseBillNumber.Location = new System.Drawing.Point(132, 345);
            this.txtPurchaseBillNumber.Name = "txtPurchaseBillNumber";
            this.txtPurchaseBillNumber.Size = new System.Drawing.Size(293, 23);
            this.txtPurchaseBillNumber.TabIndex = 14;
            // 
            // dtpPublicationDate
            // 
            this.dtpPublicationDate.CustomFormat = "yyyy/mm/dd";
            this.dtpPublicationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPublicationDate.Location = new System.Drawing.Point(134, 220);
            this.dtpPublicationDate.Name = "dtpPublicationDate";
            this.dtpPublicationDate.Size = new System.Drawing.Size(157, 23);
            this.dtpPublicationDate.TabIndex = 15;
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.CustomFormat = "yyyy";
            this.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPurchaseDate.Location = new System.Drawing.Point(135, 301);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(157, 23);
            this.dtpPurchaseDate.TabIndex = 16;
            // 
            // chkAvailable
            // 
            this.chkAvailable.AutoSize = true;
            this.chkAvailable.Location = new System.Drawing.Point(132, 388);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(74, 19);
            this.chkAvailable.TabIndex = 17;
            this.chkAvailable.Text = "Available";
            this.chkAvailable.UseVisualStyleBackColor = true;
            // 
            // btnSaveBook
            // 
            this.btnSaveBook.Location = new System.Drawing.Point(29, 422);
            this.btnSaveBook.Name = "btnSaveBook";
            this.btnSaveBook.Size = new System.Drawing.Size(87, 27);
            this.btnSaveBook.TabIndex = 18;
            this.btnSaveBook.Text = "Save";
            this.btnSaveBook.UseVisualStyleBackColor = true;
            this.btnSaveBook.Click += new System.EventHandler(this.btnSaveBook_Click);
            // 
            // btnClearBook
            // 
            this.btnClearBook.Location = new System.Drawing.Point(218, 422);
            this.btnClearBook.Name = "btnClearBook";
            this.btnClearBook.Size = new System.Drawing.Size(87, 27);
            this.btnClearBook.TabIndex = 19;
            this.btnClearBook.Text = "Clear";
            this.btnClearBook.UseVisualStyleBackColor = true;
            this.btnClearBook.Click += new System.EventHandler(this.btnClearBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(124, 422);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(87, 27);
            this.btnUpdateBook.TabIndex = 20;
            this.btnUpdateBook.Text = "Update";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteBook.Location = new System.Drawing.Point(313, 422);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(87, 27);
            this.btnDeleteBook.TabIndex = 21;
            this.btnDeleteBook.Text = "Delete";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_id,
            this.category,
            this.author,
            this.name,
            this.cost,
            this.publication_date,
            this.publisher,
            this.purchase_date,
            this.purchase_bill_no,
            this.available,
            this.cat_id});
            this.dgvBook.Location = new System.Drawing.Point(525, 103);
            this.dgvBook.MultiSelect = false;
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowHeadersVisible = false;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(877, 321);
            this.dgvBook.TabIndex = 22;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
            // 
            // book_id
            // 
            this.book_id.HeaderText = "Id";
            this.book_id.Name = "book_id";
            this.book_id.ReadOnly = true;
            this.book_id.Width = 25;
            // 
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 75;
            // 
            // author
            // 
            this.author.HeaderText = "Author";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // cost
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.cost.DefaultCellStyle = dataGridViewCellStyle4;
            this.cost.HeaderText = "Cost";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.Width = 50;
            // 
            // publication_date
            // 
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = "yyyy/mm/dd";
            this.publication_date.DefaultCellStyle = dataGridViewCellStyle5;
            this.publication_date.HeaderText = "Publication";
            this.publication_date.Name = "publication_date";
            this.publication_date.ReadOnly = true;
            // 
            // publisher
            // 
            this.publisher.HeaderText = "Publisher";
            this.publisher.Name = "publisher";
            this.publisher.ReadOnly = true;
            // 
            // purchase_date
            // 
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = "yyyy/mm/dd";
            this.purchase_date.DefaultCellStyle = dataGridViewCellStyle6;
            this.purchase_date.HeaderText = "Purchased";
            this.purchase_date.Name = "purchase_date";
            this.purchase_date.ReadOnly = true;
            // 
            // purchase_bill_no
            // 
            this.purchase_bill_no.HeaderText = "Bill No";
            this.purchase_bill_no.Name = "purchase_bill_no";
            this.purchase_bill_no.ReadOnly = true;
            // 
            // available
            // 
            this.available.HeaderText = "Available";
            this.available.Name = "available";
            this.available.ReadOnly = true;
            this.available.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.available.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.available.Width = 60;
            // 
            // cat_id
            // 
            this.cat_id.HeaderText = "Category";
            this.cat_id.Name = "cat_id";
            this.cat_id.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(503, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 442);
            this.label3.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchBook);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtSearchBook);
            this.groupBox1.Location = new System.Drawing.Point(523, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 69);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search ";
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(374, 23);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(87, 27);
            this.btnSearchBook.TabIndex = 2;
            this.btnSearchBook.Text = "Search";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Book Name";
            // 
            // txtSearchBook
            // 
            this.txtSearchBook.Location = new System.Drawing.Point(110, 25);
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.Size = new System.Drawing.Size(256, 23);
            this.txtSearchBook.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(134, 68);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(238, 23);
            this.cmbCategory.TabIndex = 26;
            // 
            // btnSortByCategory
            // 
            this.btnSortByCategory.Location = new System.Drawing.Point(1049, 39);
            this.btnSortByCategory.Name = "btnSortByCategory";
            this.btnSortByCategory.Size = new System.Drawing.Size(141, 23);
            this.btnSortByCategory.TabIndex = 27;
            this.btnSortByCategory.Text = "Sort by Category";
            this.btnSortByCategory.UseVisualStyleBackColor = true;
            this.btnSortByCategory.Click += new System.EventHandler(this.btnSortByCategory_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1220, 39);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(141, 23);
            this.btnExport.TabIndex = 28;
            this.btnExport.Text = "Export Books";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 471);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSortByCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.btnClearBook);
            this.Controls.Add(this.btnSaveBook);
            this.Controls.Add(this.chkAvailable);
            this.Controls.Add(this.dtpPurchaseDate);
            this.Controls.Add(this.dtpPublicationDate);
            this.Controls.Add(this.txtPurchaseBillNumber);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book";
            this.Load += new System.EventHandler(this.Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtPurchaseBillNumber;
        private System.Windows.Forms.DateTimePicker dtpPublicationDate;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.CheckBox chkAvailable;
        private System.Windows.Forms.Button btnSaveBook;
        private System.Windows.Forms.Button btnClearBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearchBook;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnSortByCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn publication_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_bill_no;
        private System.Windows.Forms.DataGridViewCheckBoxColumn available;
        private System.Windows.Forms.DataGridViewTextBoxColumn cat_id;
        private System.Windows.Forms.Button btnExport;
    }
}