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
    public partial class DashBoard : Form
    {
        private LibrarianClass currentLibrarian = null;

        public LibrarianClass CurrentLibrarian
        {
            get { return currentLibrarian; }
            set { currentLibrarian = value; }
        }

        private Category category = null;

        public Category Category
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

            //Check for valid Librarian login

            if (this.CurrentLibrarian == null)
            {
                Login Login = new Login();
                Login.ShowDialog();
                this.CurrentLibrarian = Login.Librarian;
                Login.Close();
                this.Text += " - Welcome " + this.CurrentLibrarian.Name;
                this.Focus();
            }
            else
            {
                this.Close();
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            this.Category = new Category();
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
    }
}
