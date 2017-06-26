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
    public partial class frmCategory : Form
    {
        private CategoryClass category;
        
        public frmCategory()
        {
            InitializeComponent();
            this.category = new CategoryClass();
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            if (Helper.validate(this))
            {
                this.category.TypeName = txtName.Text;
                this.category.save();
                clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            this.category = null;
            this.category = new CategoryClass();
            Helper.clearForm(this);
            fillDataGridView(this.category.getAll());
        }

        private void Category_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void fillDataGridView(ArrayList collection)
        {
            dgvCategory.Rows.Clear();
            foreach (CategoryClass item in collection)
            {
                dgvCategory.Rows.Add(item.CategoryId, item.TypeName);
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (Helper.validate(this) && txtCatId.Text != "")
            {
                this.category.CategoryId = Convert.ToInt32(txtCatId.Text);
                this.category.TypeName = txtName.Text;
                this.category.update();
                clear();
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (txtCatId.Text != "")
            {
                this.category.CategoryId = Convert.ToInt32(txtCatId.Text);
                DialogResult DR = MessageBox.Show("Delete " + txtCatId.Text + "? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == System.Windows.Forms.DialogResult.Yes)
                {
                    this.category.delete();
                    clear();
                }
            }
        }

        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> search = new Dictionary<string, string>();
            search["type_name"] = txtSearchCategory.Text;
            fillDataGridView(this.category.search(search));
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCatId.Text = dgvCategory.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString(); 
        }
    }
}
