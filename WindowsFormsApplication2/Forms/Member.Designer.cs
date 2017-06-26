namespace LibraryManagementSystem.Forms
{
    partial class Member
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
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.txtSearchMemberName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveMember = new System.Windows.Forms.Button();
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            this.dtpRegisteredDate = new System.Windows.Forms.DateTimePicker();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.member_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registered_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Location = new System.Drawing.Point(366, 22);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(87, 27);
            this.btnSearchMember.TabIndex = 2;
            this.btnSearchMember.Text = "Search";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // txtSearchMemberName
            // 
            this.txtSearchMemberName.Location = new System.Drawing.Point(103, 24);
            this.txtSearchMemberName.Name = "txtSearchMemberName";
            this.txtSearchMemberName.Size = new System.Drawing.Size(256, 23);
            this.txtSearchMemberName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchMember);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtSearchMemberName);
            this.groupBox1.Location = new System.Drawing.Point(491, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 69);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Member Name";
            // 
            // dgvMember
            // 
            this.dgvMember.AllowUserToAddRows = false;
            this.dgvMember.AllowUserToDeleteRows = false;
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.member_id,
            this.first,
            this.last,
            this.registered_date,
            this.available});
            this.dgvMember.Location = new System.Drawing.Point(491, 90);
            this.dgvMember.MultiSelect = false;
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.ReadOnly = true;
            this.dgvMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMember.Size = new System.Drawing.Size(729, 321);
            this.dgvMember.TabIndex = 46;
            this.dgvMember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMember_CellClick);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteMember.Location = new System.Drawing.Point(336, 340);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(87, 27);
            this.btnDeleteMember.TabIndex = 45;
            this.btnDeleteMember.Text = "Delete";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.Location = new System.Drawing.Point(147, 340);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(87, 27);
            this.btnUpdateMember.TabIndex = 44;
            this.btnUpdateMember.Text = "Update";
            this.btnUpdateMember.UseVisualStyleBackColor = true;
            this.btnUpdateMember.Click += new System.EventHandler(this.btnUpdateMember_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(241, 340);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 27);
            this.btnClear.TabIndex = 43;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveMember
            // 
            this.btnSaveMember.Location = new System.Drawing.Point(52, 340);
            this.btnSaveMember.Name = "btnSaveMember";
            this.btnSaveMember.Size = new System.Drawing.Size(87, 27);
            this.btnSaveMember.TabIndex = 42;
            this.btnSaveMember.Text = "Save";
            this.btnSaveMember.UseVisualStyleBackColor = true;
            this.btnSaveMember.Click += new System.EventHandler(this.btnSaveMember_Click);
            // 
            // chkAvailable
            // 
            this.chkAvailable.AutoSize = true;
            this.chkAvailable.Location = new System.Drawing.Point(132, 204);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(74, 19);
            this.chkAvailable.TabIndex = 41;
            this.chkAvailable.Text = "Available";
            this.chkAvailable.UseVisualStyleBackColor = true;
            // 
            // dtpRegisteredDate
            // 
            this.dtpRegisteredDate.CustomFormat = "yyyy/mm/dd";
            this.dtpRegisteredDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRegisteredDate.Location = new System.Drawing.Point(132, 160);
            this.dtpRegisteredDate.Name = "dtpRegisteredDate";
            this.dtpRegisteredDate.Size = new System.Drawing.Size(157, 23);
            this.dtpRegisteredDate.TabIndex = 39;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(132, 118);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(319, 23);
            this.txtLast.TabIndex = 35;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(132, 78);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(319, 23);
            this.txtFirst.TabIndex = 34;
            // 
            // txtMemberId
            // 
            this.txtMemberId.Enabled = false;
            this.txtMemberId.Location = new System.Drawing.Point(132, 38);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.ReadOnly = true;
            this.txtMemberId.Size = new System.Drawing.Size(116, 23);
            this.txtMemberId.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Registered  Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Last";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "First";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Member Id";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(469, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1, 397);
            this.label3.TabIndex = 47;
            // 
            // member_id
            // 
            this.member_id.HeaderText = "Id";
            this.member_id.Name = "member_id";
            this.member_id.ReadOnly = true;
            // 
            // first
            // 
            this.first.HeaderText = "First";
            this.first.Name = "first";
            this.first.ReadOnly = true;
            // 
            // last
            // 
            this.last.HeaderText = "Last";
            this.last.Name = "last";
            this.last.ReadOnly = true;
            // 
            // registered_date
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = "yyyy/dd/mm";
            this.registered_date.DefaultCellStyle = dataGridViewCellStyle1;
            this.registered_date.HeaderText = "Registered Date";
            this.registered_date.Name = "registered_date";
            this.registered_date.ReadOnly = true;
            // 
            // available
            // 
            this.available.HeaderText = "Available";
            this.available.Name = "available";
            this.available.ReadOnly = true;
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 430);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMember);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.btnUpdateMember);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSaveMember);
            this.Controls.Add(this.chkAvailable);
            this.Controls.Add(this.dtpRegisteredDate);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member";
            this.Load += new System.EventHandler(this.Member_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.TextBox txtSearchMemberName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnUpdateMember;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveMember;
        private System.Windows.Forms.CheckBox chkAvailable;
        private System.Windows.Forms.DateTimePicker dtpRegisteredDate;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn member_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn first;
        private System.Windows.Forms.DataGridViewTextBoxColumn last;
        private System.Windows.Forms.DataGridViewTextBoxColumn registered_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn available;
    }
}