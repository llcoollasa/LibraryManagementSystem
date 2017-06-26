namespace LibraryManagementSystem.Forms
{
    partial class Librarian
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchLibrarian = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearchLibrarianName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLibrarian = new System.Windows.Forms.DataGridView();
            this.librarian_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteLibrarian = new System.Windows.Forms.Button();
            this.btnUpdateLibrarian = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveLibrarian = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLibrarianId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrarian)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchLibrarian);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtSearchLibrarianName);
            this.groupBox1.Location = new System.Drawing.Point(482, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 69);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search ";
            // 
            // btnSearchLibrarian
            // 
            this.btnSearchLibrarian.Location = new System.Drawing.Point(366, 22);
            this.btnSearchLibrarian.Name = "btnSearchLibrarian";
            this.btnSearchLibrarian.Size = new System.Drawing.Size(87, 27);
            this.btnSearchLibrarian.TabIndex = 2;
            this.btnSearchLibrarian.Text = "Search";
            this.btnSearchLibrarian.UseVisualStyleBackColor = true;
            this.btnSearchLibrarian.Click += new System.EventHandler(this.btnSearchLibrarian_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Librarian Name";
            // 
            // txtSearchLibrarianName
            // 
            this.txtSearchLibrarianName.Location = new System.Drawing.Point(103, 24);
            this.txtSearchLibrarianName.Name = "txtSearchLibrarianName";
            this.txtSearchLibrarianName.Size = new System.Drawing.Size(256, 23);
            this.txtSearchLibrarianName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(460, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1, 397);
            this.label3.TabIndex = 63;
            // 
            // dgvLibrarian
            // 
            this.dgvLibrarian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibrarian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.librarian_id,
            this.name,
            this.password});
            this.dgvLibrarian.Location = new System.Drawing.Point(482, 89);
            this.dgvLibrarian.Name = "dgvLibrarian";
            this.dgvLibrarian.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibrarian.Size = new System.Drawing.Size(464, 321);
            this.dgvLibrarian.TabIndex = 62;
            this.dgvLibrarian.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibrarian_CellClick);
            // 
            // librarian_id
            // 
            this.librarian_id.HeaderText = "Librarian Id";
            this.librarian_id.Name = "librarian_id";
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.Visible = false;
            // 
            // btnDeleteLibrarian
            // 
            this.btnDeleteLibrarian.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteLibrarian.Location = new System.Drawing.Point(327, 185);
            this.btnDeleteLibrarian.Name = "btnDeleteLibrarian";
            this.btnDeleteLibrarian.Size = new System.Drawing.Size(87, 27);
            this.btnDeleteLibrarian.TabIndex = 61;
            this.btnDeleteLibrarian.Text = "Delete";
            this.btnDeleteLibrarian.UseVisualStyleBackColor = true;
            this.btnDeleteLibrarian.Click += new System.EventHandler(this.btnDeleteLibrarian_Click);
            // 
            // btnUpdateLibrarian
            // 
            this.btnUpdateLibrarian.Location = new System.Drawing.Point(138, 185);
            this.btnUpdateLibrarian.Name = "btnUpdateLibrarian";
            this.btnUpdateLibrarian.Size = new System.Drawing.Size(87, 27);
            this.btnUpdateLibrarian.TabIndex = 60;
            this.btnUpdateLibrarian.Text = "Update";
            this.btnUpdateLibrarian.UseVisualStyleBackColor = true;
            this.btnUpdateLibrarian.Click += new System.EventHandler(this.btnUpdateLibrarian_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(232, 185);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 27);
            this.btnClear.TabIndex = 59;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveLibrarian
            // 
            this.btnSaveLibrarian.Location = new System.Drawing.Point(43, 185);
            this.btnSaveLibrarian.Name = "btnSaveLibrarian";
            this.btnSaveLibrarian.Size = new System.Drawing.Size(87, 27);
            this.btnSaveLibrarian.TabIndex = 58;
            this.btnSaveLibrarian.Text = "Save";
            this.btnSaveLibrarian.UseVisualStyleBackColor = true;
            this.btnSaveLibrarian.Click += new System.EventHandler(this.btnSaveLibrarian_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(122, 117);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(235, 22);
            this.txtPassword.TabIndex = 55;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(319, 23);
            this.txtName.TabIndex = 54;
            // 
            // txtLibrarianId
            // 
            this.txtLibrarianId.Enabled = false;
            this.txtLibrarianId.Location = new System.Drawing.Point(122, 37);
            this.txtLibrarianId.Name = "txtLibrarianId";
            this.txtLibrarianId.ReadOnly = true;
            this.txtLibrarianId.Size = new System.Drawing.Size(116, 23);
            this.txtLibrarianId.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 51;
            this.label4.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 50;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 49;
            this.label1.Text = "Librarian Id";
            // 
            // Librarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvLibrarian);
            this.Controls.Add(this.btnDeleteLibrarian);
            this.Controls.Add(this.btnUpdateLibrarian);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSaveLibrarian);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtLibrarianId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Librarian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Librarian";
            this.Load += new System.EventHandler(this.Librarian_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrarian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchLibrarian;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearchLibrarianName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvLibrarian;
        private System.Windows.Forms.Button btnDeleteLibrarian;
        private System.Windows.Forms.Button btnUpdateLibrarian;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveLibrarian;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLibrarianId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn librarian_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
    }
}