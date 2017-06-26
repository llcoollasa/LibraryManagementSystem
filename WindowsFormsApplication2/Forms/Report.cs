using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            DataTable dt = Program.db.getResult("SELECT " +
            "B.book_id, " +
            "C.type_name, " +
            "B.Name, " +
            "B.author, " +
            "B.publisher, " +
            "B.publication_date, " +
            "B.available,  " +
            "B.cost, " +
            "B.purchase_date, " +
            "B.purchase_bill_no " +
            "FROM book B " +
            "LEFT JOIN category c " +
            "ON B.cat_id = C.cat_id " +
            "WHERE B.available = 0");

            ReportDataSource rds = new ReportDataSource("TotalBooksDS", dt);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
         
    }
}
