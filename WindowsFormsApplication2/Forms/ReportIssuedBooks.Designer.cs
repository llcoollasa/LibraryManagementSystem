namespace LibraryManagementSystem.Forms
{
    partial class ReportIssuedBooks
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dSIssuedBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSIssuedBooks = new LibraryManagementSystem.Reports.DSIssuedBooks();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.issuedBookTableAdapter = new LibraryManagementSystem.Reports.DSIssuedBooksTableAdapters.IssuedBookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSIssuedBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSIssuedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dSIssuedBooksBindingSource
            // 
            this.dSIssuedBooksBindingSource.DataSource = this.dSIssuedBooks;
            this.dSIssuedBooksBindingSource.Position = 0;
            // 
            // dSIssuedBooks
            // 
            this.dSIssuedBooks.DataSetName = "DSIssuedBooks";
            this.dSIssuedBooks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "IssuedBooks";
            reportDataSource1.Value = this.dSIssuedBooksBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LibraryManagementSystem.Reports.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1114, 566);
            this.reportViewer1.TabIndex = 0;
            // 
            // issuedBookTableAdapter
            // 
            this.issuedBookTableAdapter.ClearBeforeFill = true;
            // 
            // ReportIssuedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 566);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportIssuedBooks";
            this.Text = "ReportIssuedBooks";
            this.Load += new System.EventHandler(this.ReportIssuedBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSIssuedBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSIssuedBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private LibraryManagementSystem.Reports.DSIssuedBooks dSIssuedBooks;
        private LibraryManagementSystem.Reports.DSIssuedBooksTableAdapters.IssuedBookTableAdapter issuedBookTableAdapter;
        private System.Windows.Forms.BindingSource dSIssuedBooksBindingSource;        
        
    }
}