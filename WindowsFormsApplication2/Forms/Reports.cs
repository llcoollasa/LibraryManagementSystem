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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        { 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report rpt = new Report();
            rpt.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportIssuedBooks rpt = new ReportIssuedBooks();
            rpt.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
