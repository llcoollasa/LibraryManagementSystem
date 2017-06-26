namespace LibraryManagementSystem.Forms
{
    partial class frmCategory
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
            this.btnSearchCategory = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearchCategory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCatId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchCategory);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtSearchCategory);
            this.groupBox1.Location = new System.Drawing.Point(482, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 69);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search ";
            // 
            // btnSearchCategory
            // 
            this.btnSearchCategory.Location = new System.Drawing.Point(366, 22);
            this.btnSearchCategory.Name = "btnSearchCategory";
            this.btnSearchCategory.Size = new System.Drawing.Size(87, 27);
            this.btnSearchCategory.TabIndex = 2;
            this.btnSearchCategory.Text = "Search";
            this.btnSearchCategory.UseVisualStyleBackColor = true;
            this.btnSearchCategory.Click += new System.EventHandler(this.btnSearchCategory_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Category Name";
            // 
            // txtSearchCategory
            // 
            this.txtSearchCategory.Location = new System.Drawing.Point(103, 24);
            this.txtSearchCategory.Name = "txtSearchCategory";
            this.txtSearchCategory.Size = new System.Drawing.Size(256, 23);
            this.txtSearchCategory.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(460, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1, 397);
            this.label3.TabIndex = 76;
            // 
            // dgvCategory
            // 
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cat_id,
            this.type_name});
            this.dgvCategory.Location = new System.Drawing.Point(482, 85);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategory.Size = new System.Drawing.Size(464, 321);
            this.dgvCategory.TabIndex = 75;
            this.dgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellClick);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteCategory.Location = new System.Drawing.Point(328, 149);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(87, 27);
            this.btnDeleteCategory.TabIndex = 74;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Location = new System.Drawing.Point(139, 149);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(87, 27);
            this.btnUpdateCategory.TabIndex = 73;
            this.btnUpdateCategory.Text = "Update";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(233, 149);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 27);
            this.btnClear.TabIndex = 72;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.Location = new System.Drawing.Point(44, 149);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(87, 27);
            this.btnSaveCategory.TabIndex = 71;
            this.btnSaveCategory.Text = "Save";
            this.btnSaveCategory.UseVisualStyleBackColor = true;
            this.btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(319, 23);
            this.txtName.TabIndex = 69;
            // 
            // txtCatId
            // 
            this.txtCatId.Enabled = false;
            this.txtCatId.Location = new System.Drawing.Point(122, 33);
            this.txtCatId.Name = "txtCatId";
            this.txtCatId.ReadOnly = true;
            this.txtCatId.Size = new System.Drawing.Size(116, 23);
            this.txtCatId.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 66;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 65;
            this.label1.Text = "Category Id";
            // 
            // cat_id
            // 
            this.cat_id.HeaderText = "Category Id";
            this.cat_id.Name = "cat_id";
            // 
            // type_name
            // 
            this.type_name.HeaderText = "Type Name";
            this.type_name.Name = "type_name";
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 421);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCategory);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnUpdateCategory);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSaveCategory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCatId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchCategory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearchCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveCategory;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCatId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cat_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_name;
    }
}