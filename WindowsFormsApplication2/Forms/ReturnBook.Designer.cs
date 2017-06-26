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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(224, 144);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 27);
            this.btnClose.TabIndex = 76;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Location = new System.Drawing.Point(116, 144);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(102, 27);
            this.btnReturnBook.TabIndex = 75;
            this.btnReturnBook.Text = "Return BookClass";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(113, 19);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(0, 15);
            this.lblBookName.TabIndex = 77;
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(113, 54);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(0, 15);
            this.lblMember.TabIndex = 78;
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 203);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.txtFine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Book";
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblMember;
    }
}