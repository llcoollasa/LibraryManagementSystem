namespace LibraryManagementSystem.Forms
{
    partial class Report
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
            this.TotalBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBooks = new LibraryManagementSystem.Reports.DSBooks();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.totalBooksTableAdapter = new LibraryManagementSystem.Reports.DSBooksTableAdapters.TotalBooksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TotalBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // TotalBooksBindingSource
            // 
            this.TotalBooksBindingSource.DataSource = this.dsBooks;
            this.TotalBooksBindingSource.Position = 0;
            // 
            // dsBooks
            // 
            this.dsBooks.DataSetName = "DSBooks";
            this.dsBooks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "TotalBooksDS";
            reportDataSource1.Value = this.TotalBooksBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LibraryManagementSystem.Reports.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(836, 502);
            this.reportViewer1.TabIndex = 0; 
            // 
            // totalBooksTableAdapter
            // 
            this.totalBooksTableAdapter.ClearBeforeFill = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 502);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report";
            this.Text = "Total Number of Books";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TotalBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private LibraryManagementSystem.Reports.DSBooks dsBooks;
        private LibraryManagementSystem.Reports.DSBooksTableAdapters.TotalBooksTableAdapter totalBooksTableAdapter;
        private System.Windows.Forms.BindingSource TotalBooksBindingSource;  
    }
}