namespace LibraryManagementSystem.Forms
{
    partial class ReturnBook
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
            this.lblMemberId = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.cmbMemberName = new System.Windows.Forms.ComboBox();
            this.cmbBookName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.ForeColor = System.Drawing.Color.Red;
            this.lblMemberId.Location = new System.Drawing.Point(402, 54);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(13, 15);
            this.lblMemberId.TabIndex = 11;
            this.lblMemberId.Text = "c";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.ForeColor = System.Drawing.Color.Red;
            this.lblAvailable.Location = new System.Drawing.Point(402, 19);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(13, 15);
            this.lblAvailable.TabIndex = 10;
            this.lblAvailable.Text = "c";
            // 
            // cmbMemberName
            // 
            this.cmbMemberName.FormattingEnabled = true;
            this.cmbMemberName.Location = new System.Drawing.Point(116, 51);
            this.cmbMemberName.Name = "cmbMemberName";
            this.cmbMemberName.Size = new System.Drawing.Size(269, 23);
            this.cmbMemberName.TabIndex = 9;
            // 
            // cmbBookName
            // 
            this.cmbBookName.FormattingEnabled = true;
            this.cmbBookName.Location = new System.Drawing.Point(116, 16);
            this.cmbBookName.Name = "cmbBookName";
            this.cmbBookName.Size = new System.Drawing.Size(269, 23);
            this.cmbBookName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Member";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total Fine";
            // 
            // txtFine
            // 
            this.txtFine.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFine.ForeColor = System.Drawing.Color.Red;
            this.txtFine.Location = new System.Drawing.Point(116, 91);
            this.txtFine.Name = "txtFine";
            this.txtFine.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFine.Size = new System.Drawing.Size(120, 27);
            this.txtFine.TabIndex = 13;
            this.txtFine.Text = "0.00";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(224, 144);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 27);
            this.btnClear.TabIndex = 76;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Location = new System.Drawing.Point(116, 144);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(102, 27);
            this.btnReturnBook.TabIndex = 75;
            this.btnReturnBook.Text = "Return BookClass";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 203);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.txtFine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMemberId);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.cmbMemberName);
            this.Controls.Add(this.cmbBookName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.ComboBox cmbMemberName;
        private System.Windows.Forms.ComboBox cmbBookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReturnBook;
    }
}