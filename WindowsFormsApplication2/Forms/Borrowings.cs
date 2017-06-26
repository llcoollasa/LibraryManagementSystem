using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Classes;
using System.Collections;

namespace LibraryManagementSystem.Forms
{
    public partial class Borrowings : Form
    {
        private BorrowingClass borrowingClass;

        public Borrowings()
        {
            InitializeComponent();
            this.borrowingClass = new BorrowingClass();
        }

        private void btnNewBorrowing_Click(object sender, EventArgs e)
        {
            NewBorrowing newBorrowing = new NewBorrowing();
            newBorrowing.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Borrowings_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            Helper.clearForm(this);

            //Fill books
            BookClass bookClass = new BookClass();
            ArrayList books = bookClass.getAll();
            foreach (BookClass item in books)
            {
                cmbBookName.DisplayMember = "Name";
                cmbBookName.ValueMember = "BookId";
                cmbBookName.Items.Add(item);
            }

            //Fill members
            MemberClass memberClass = new MemberClass();
            ArrayList members = memberClass.getAll();
            foreach (MemberClass item in members)
            {
                cmbMemberName.DisplayMember = "First";
                cmbMemberName.ValueMember = "MemberId";
                cmbMemberName.Items.Add(item);
            }
        } 
        private void fillDataGridView(ArrayList collection)
        {
            dgvBorrowings.Rows.Clear();
            foreach (BorrowingClass item in collection)
            {
                string buttonText = "Return Book";
                if (item.HasReturn)
                {
                    buttonText = "Returned";
                }

                dgvBorrowings.Rows.Add(item.Id, item.BookId.BookId, item.MemberId.MemberId, item.BookId.Name, item.ReturningDate, item.BorrowedDate, item.Fine, item.HasReturn, buttonText);

                if (item.HasReturn)
                {
                    dgvBorrowings.Rows[dgvBorrowings.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                
            }
        } 

        private void cmbMemberName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MemberClass memberClass = (MemberClass)cmbMemberName.SelectedItem;
            Int32 member_id = memberClass.MemberId;
            fillDataGridView(this.borrowingClass.getCurrentBorrowingsByMember(member_id, true));
        }

        private void cmbBookName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            BookClass bookClass = (BookClass)cmbBookName.SelectedItem;
            Int32 book_id = bookClass.BookId;
            fillDataGridView(this.borrowingClass.getCurrentBorrowingsByBook(book_id));
        }

        private void dgvBorrowings_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                Int32 borrowing_id = Int32.Parse(dgvBorrowings.Rows[e.RowIndex].Cells[0].Value.ToString());

                if (borrowing_id > 0)
                {
                    BorrowingClass borrowing = new BorrowingClass();
                    borrowing.Id = borrowing_id;
                    borrowing.get();

                    ReturnBook returnBook = new ReturnBook();
                    returnBook.Borrowing = borrowing;
                    returnBook.ShowDialog();

                    clear();
                }

            }
        }
    }
}
