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
using System.Configuration;

namespace LibraryManagementSystem.Forms
{
    public partial class NewBorrowing : Form
    {
        private BorrowingClass borrowingClass;
        public NewBorrowing()
        {
            InitializeComponent();
            this.borrowingClass = new BorrowingClass();
        }

        private void NewBorrowing_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            Helper.clearForm(this);

            this.borrowingClass = null;
            this.borrowingClass = new BorrowingClass();
            
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

            //set returning days
            double days = Double.Parse(ConfigurationManager.AppSettings["ReturningInDays"].ToString());
            dtpReturningDate.Value = DateTime.Today.AddDays(days);

            //set borrowed date to today
            this.borrowingClass.BorrowedDate = DateTime.Today;

            dgvCurrentBooks.Rows.Clear();

            lblAvailable.Text = "";
            chkShowReturn.Checked = false;
            txtFine.Text = "0";
        }

        private void btnSaveNewBorrowing_Click(object sender, EventArgs e)
        {
            if (Helper.validate(this))
            {
                this.borrowingClass = new BorrowingClass();

                BookClass book = (BookClass) cmbBookName.SelectedItem;
                book.get();
                this.borrowingClass.BookId = book;

                MemberClass member = (MemberClass)cmbMemberName.SelectedItem;
                member.get();
                this.borrowingClass.MemberId = member;

                this.borrowingClass.ReturningDate = dtpReturningDate.Value;
                this.borrowingClass.BorrowedDate = DateTime.Today;
                this.borrowingClass.HasReturn = false;
                this.borrowingClass.Fine = 0;

                if (this.borrowingClass.save() == 0)
                {
                    MessageBox.Show(this.borrowingClass.ValidationMessages, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    clear();
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();

        }

        private void cmbBookName_SelectedIndexChanged(object sender, EventArgs e)
        {
            BookClass bookClass = (BookClass)cmbBookName.SelectedItem;
            bookClass.get();
            if (!bookClass.Available)
            {
                lblAvailable.Text = "Book is not Available";
            }
            else
            {
                lblAvailable.Text = "";
            }
        }

        private void cmbMemberName_SelectedIndexChanged(object sender, EventArgs e)
        {
            MemberClass memberClass = (MemberClass)cmbMemberName.SelectedItem;
            Int32 member_id = memberClass.MemberId;
            fillDataGridView(this.borrowingClass.getCurrentBorrowingsByMember(member_id, chkShowReturn.Checked));
        }  

        private void fillDataGridView(ArrayList collection)
        {
            dgvCurrentBooks.Rows.Clear();           
            foreach (BorrowingClass item in collection)
            {
                dgvCurrentBooks.Rows.Add(item.Id, item.BookId.BookId, item.MemberId.MemberId, item.BookId.Name, item.ReturningDate, item.BorrowedDate, item.Fine, item.HasReturn);
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (Helper.validate(this) && txtBorrowingId.Text != "")
            {
                this.borrowingClass.Id = Convert.ToInt32(txtBorrowingId.Text);
                this.borrowingClass.ReturningDate = dtpReturningDate.Value; 
                this.borrowingClass.BorrowedDate = dtpBorrowedDate.Value; 
                this.borrowingClass.HasReturn = chkAvailable.Checked;
                this.borrowingClass.Fine = decimal.Parse(txtFine.Text);
                
                BookClass book = new BookClass();
                book = (BookClass) cmbBookName.SelectedItem;
                book.get();
                this.borrowingClass.BookId = book;

                MemberClass member = new MemberClass();
                member = (MemberClass)cmbMemberName.SelectedItem;
                member.get();
                this.borrowingClass.MemberId = member;

                if (this.borrowingClass.update() == 0)
                {
                    MessageBox.Show(this.borrowingClass.ValidationMessages, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    clear();
                }
                
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (txtBorrowingId.Text != "")
            {
                this.borrowingClass.Id = Convert.ToInt32(txtBorrowingId.Text);
                DialogResult DR = MessageBox.Show("Delete " + txtBorrowingId.Text + "? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == System.Windows.Forms.DialogResult.Yes)
                {
                    this.borrowingClass.delete();
                    clear();
                }
            }
        }

        private void dgvCurrentBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dgvCurrentBooks.Rows[e.RowIndex].Cells[0].Value != null)
            {
                txtBorrowingId.Text = dgvCurrentBooks.Rows[e.RowIndex].Cells[0].Value.ToString();
                dtpReturningDate.Value = DateTime.Parse(dgvCurrentBooks.Rows[e.RowIndex].Cells[4].Value.ToString());
                dtpBorrowedDate.Value = DateTime.Parse(dgvCurrentBooks.Rows[e.RowIndex].Cells[5].Value.ToString());
                txtFine.Text = dgvCurrentBooks.Rows[e.RowIndex].Cells[6].Value.ToString();
                chkAvailable.Checked = bool.Parse(dgvCurrentBooks.Rows[e.RowIndex].Cells[7].Value.ToString());

                Int32 book_id = Int32.Parse(dgvCurrentBooks.Rows[e.RowIndex].Cells[1].Value.ToString());
                foreach (BookClass item in cmbBookName.Items)
                {
                    if (book_id == item.BookId)
                    {
                        cmbBookName.SelectedItem = item;
                    }
                }

                Int32 member_id = Int32.Parse(dgvCurrentBooks.Rows[e.RowIndex].Cells[2].Value.ToString());
                foreach (MemberClass item in cmbMemberName.Items)
                {
                    if (member_id == item.MemberId)
                    {
                        cmbMemberName.SelectedItem = item;
                    }
                }
            }
        }

        private void chkShowReturn_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbMemberName.SelectedItem != null)
            {
                MemberClass memberClass = (MemberClass)cmbMemberName.SelectedItem;
                Int32 member_id = memberClass.MemberId;
                fillDataGridView(this.borrowingClass.getCurrentBorrowingsByMember(member_id, chkShowReturn.Checked));
            }
            
        }

    }
}
