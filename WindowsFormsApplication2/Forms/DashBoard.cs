using System;
using System.Collections;
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
    public partial class DashBoard : Form
    {
        private LibrarianClass currentLibrarian = null;

        public LibrarianClass CurrentLibrarian
        {
            get { return currentLibrarian; }
            set { currentLibrarian = value; }
        }

        private frmCategory category = null;

        public frmCategory Category
        {
            get { return category; }
            set { category = value; }
        }
        private Book book = null;

        public Book Book
        {
            get { return book; }
            set { book = value; }
        }
        private Member member = null;

        public Member Member
        {
            get { return member; }
            set { member = value; }
        }
        private Borrowings borrowings = null;

        public Borrowings Borrowings
        {
            get { return borrowings; }
            set { borrowings = value; }
        }

        private Librarian librarian;

        public Librarian Librarian
        {
            get { return librarian; }
            set { librarian = value; }
        }

        public DashBoard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

            BorrowingClass borrowingClass = new BorrowingClass();
            fillDataGridView(borrowingClass.getAll());

            //Check for valid Librarian login

            if (this.CurrentLibrarian == null)
            {
                try
                {
                    Login Login = new Login();
                    Login.ShowDialog();
                    this.CurrentLibrarian = Login.Librarian;
                    Login.Close();
                    this.Text += " - Welcome " + this.CurrentLibrarian.Name;
                    this.lblGreetings.Text = "Hi " + this.CurrentLibrarian.Name + ". " + this.lblGreetings.Text;
                    this.Focus();
                }
                catch (Exception ex)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            this.Category = new frmCategory();
            this.Category.ShowDialog();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            this.Book = new Book();
            this.Book.ShowDialog();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            this.Member = new Member();
            this.Member.ShowDialog();
        }

        private void btnBorrowings_Click(object sender, EventArgs e)
        {
            this.Borrowings = new Borrowings();
            this.Borrowings.ShowDialog();
        }

        private void btnLibrarian_Click(object sender, EventArgs e)
        {
            this.Librarian = new Librarian();
            this.Librarian.ShowDialog();
        }

        private void fillDataGridView(ArrayList collection)
        {
            dgvBorrowings.Rows.Clear();
            foreach (BorrowingClass item in collection)
            {
                dgvBorrowings.Rows.Add(item.MemberId.First +" "+ item.MemberId.Last, item.BookId.Name,  item.Fine, item.HasReturn);

            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.ShowDialog();
        } 
    }
}
