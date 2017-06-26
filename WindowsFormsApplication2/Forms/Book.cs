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
using System.Data;
using System.Collections;
using LibraryManagementSystem.Classes;

using System.Xml.Serialization;
using System.IO;

namespace LibraryManagementSystem.Forms
{
    public partial class Book : Form
    {
        private BookClass bookClass;
        public Book()
        {
            InitializeComponent();
            this.bookClass = new BookClass();
        }

        private void Book_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void fillDataGridView(ArrayList collection)
        {
            dgvBook.Rows.Clear();
            foreach (BookClass item in collection)
            {
                dgvBook.Rows.Add(item.BookId , item.Category.TypeName, item.Author, item.Name, item.Cost, item.PublicationDate, item.Publisher, item.PurchaseDate, item.PurchaseBillNo, item.Available, item.Category.CategoryId);
            }
        }

        private void clear()
        {
            this.bookClass = null;
            this.bookClass = new BookClass();
            Helper.clearForm(this);
            fillDataGridView(this.bookClass.getAll());
            cmbCategory.Items.Clear();
            CategoryClass cat = new CategoryClass();
            ArrayList categories = cat.getAll();
            foreach (CategoryClass item in categories)
            {
                cmbCategory.DisplayMember = "TypeName";
                cmbCategory.ValueMember = "CategoryId";
                cmbCategory.Items.Add(item);
            }
        }

        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            if (Helper.validate(this))
            {
                this.bookClass.Author = txtAuthor.Text;
                this.bookClass.Cost = Decimal.Parse(txtCost.Text);
                this.bookClass.Name = txtName.Text;
                this.bookClass.PublicationDate = dtpPublicationDate.Value;
                this.bookClass.Publisher = txtPublisher.Text;
                this.bookClass.PurchaseDate = dtpPurchaseDate.Value;
                this.bookClass.PurchaseBillNo = txtPurchaseBillNumber.Text;
                this.bookClass.Available = chkAvailable.Checked;

                CategoryClass cat = new CategoryClass();
                cat.CategoryId = cmbCategory.SelectedIndex;
                cat.get();
                this.bookClass.Category = cat;

                this.bookClass.save();
                clear();
            }
        }

        private void btnClearBook_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1  && dgvBook.Rows[e.RowIndex].Cells[0].Value != null)
            {
                txtBookId.Text = dgvBook.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtAuthor.Text = dgvBook.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtName.Text = dgvBook.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtCost.Text = dgvBook.Rows[e.RowIndex].Cells[4].Value.ToString();
                dtpPublicationDate.Value = DateTime.Parse(dgvBook.Rows[e.RowIndex].Cells[5].Value.ToString());
                txtPublisher.Text = dgvBook.Rows[e.RowIndex].Cells[6].Value.ToString();
                dtpPurchaseDate.Value = DateTime.Parse(dgvBook.Rows[e.RowIndex].Cells[7].Value.ToString());
                txtPurchaseBillNumber.Text = dgvBook.Rows[e.RowIndex].Cells[8].Value.ToString();
                chkAvailable.Checked = Boolean.Parse(dgvBook.Rows[e.RowIndex].Cells[9].Value.ToString());
                
                Int32 cat_id = Int32.Parse(dgvBook.Rows[e.RowIndex].Cells[10].Value.ToString());
                foreach (CategoryClass item in cmbCategory.Items)
                {
                    if(cat_id == item.CategoryId)
                    {
                        cmbCategory.SelectedItem  = item;
                    }
                } 
            }
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> search = new Dictionary<string, string>();
            search["name"] = txtSearchBook.Text.Replace("'", "''"); 
            fillDataGridView(this.bookClass.search(search));
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (Helper.validate(this) && txtBookId.Text != "")
            {
                this.bookClass.BookId = Convert.ToInt32(txtBookId.Text);
                this.bookClass.Author = txtAuthor.Text;
                this.bookClass.Cost = Decimal.Parse(txtCost.Text);
                this.bookClass.Name = txtName.Text;
                this.bookClass.PublicationDate = dtpPublicationDate.Value;
                this.bookClass.Publisher = txtPublisher.Text;
                this.bookClass.PurchaseDate = dtpPurchaseDate.Value;
                this.bookClass.PurchaseBillNo = txtPurchaseBillNumber.Text;
                this.bookClass.Available = chkAvailable.Checked;

                CategoryClass cat = new CategoryClass();
                cat = (CategoryClass) cmbCategory.SelectedItem;
                cat.get();
                this.bookClass.Category = cat; 

                this.bookClass.update();
                clear();
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (txtBookId.Text != "")
            {
                this.bookClass.BookId = Convert.ToInt32(txtBookId.Text);
                DialogResult DR = MessageBox.Show("Delete " + txtBookId.Text + "? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == System.Windows.Forms.DialogResult.Yes)
                {
                    this.bookClass.delete();
                    clear();
                }
            }
        }

        private void btnSortByCategory_Click(object sender, EventArgs e)
        { 
            BookCollectionClass booksCollection = new BookCollectionClass();
            booksCollection.addBooks();
            booksCollection.sortBook();

            ArrayList arrayBooks = new ArrayList();
            foreach (BookClass item in booksCollection.BooksCollection)
            {
                arrayBooks.Add(item);
            }

            fillDataGridView(arrayBooks);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML|*.xml";
            saveFileDialog.Title = "Save XML File";
            saveFileDialog.FileName = "Books.xml";
            saveFileDialog.ShowDialog();


            if (saveFileDialog.FileName != "")
            {
                BookCollectionClass booksCollection = new BookCollectionClass();
                booksCollection.addBooks();
                booksCollection.SerializeBooks(saveFileDialog.FileName);
            }  
        }
    }
}
