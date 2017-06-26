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
    public partial class ReturnBook : Form
    {
        private BorrowingClass borrowing;

        public BorrowingClass Borrowing
        {
            get { return borrowing; }
            set { borrowing = value; }
        }
         

        public ReturnBook()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            this.lblBookName.Text = this.Borrowing.BookId.Name;
            this.lblMember.Text = this.Borrowing.MemberId.First + " " + this.Borrowing.MemberId.Last;
            this.txtFine.Text = this.Borrowing.Fine.ToString("0.00");
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            this.Borrowing.Fine = decimal.Parse(txtFine.Text);
            this.Borrowing.HasReturn = true;
            this.Borrowing.update();

            this.Borrowing.BookId.Available = true;

            if (this.Borrowing.update() > 0)
            {
                MessageBox.Show(this.lblBookName.Text + " Returned to the Library", "Return Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }
    }
}
