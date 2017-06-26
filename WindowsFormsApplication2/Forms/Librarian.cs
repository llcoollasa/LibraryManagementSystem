﻿using System;
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
    public partial class Librarian : Form
    {
        private LibrarianClass librarian;
        
        public Librarian()
        {
            InitializeComponent();
            this.librarian = new LibrarianClass();
        }

        private void Librarian_Load(object sender, EventArgs e)
        {
            clear();
             
        }

        private void btnSaveLibrarian_Click(object sender, EventArgs e)
        {
            if (Helper.validate(this))
            {
                this.librarian.Name = txtName.Text;
                this.librarian.Password = txtPassword.Text;
                this.librarian.save();
                clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            this.librarian = null;
            this.librarian = new LibrarianClass();
            Helper.clearForm(this);
            fillDataGridView(this.librarian.getAll());
        }

        private void dgvLibrarian_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtPassword.Text = e.RowIndex.ToString();
        }

        private void dgvLibrarian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtLibrarianId.Text = dgvLibrarian.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvLibrarian.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPassword.Text = dgvLibrarian.Rows[e.RowIndex].Cells[2].Value.ToString();
            
        }

        private void btnUpdateLibrarian_Click(object sender, EventArgs e)
        {
            if (Helper.validate(this) && txtLibrarianId.Text != "")
            {
                this.librarian.LibrarianId = Convert.ToInt32(txtLibrarianId.Text);
                this.librarian.Name = txtName.Text;
                this.librarian.Password = txtPassword.Text;
                this.librarian.update();
                clear();
            }
        }

        private void btnDeleteLibrarian_Click(object sender, EventArgs e)
        {
            if (txtLibrarianId.Text != "")
            {
                this.librarian.LibrarianId = Convert.ToInt32(txtLibrarianId.Text);
                DialogResult DR = MessageBox.Show("Delete " + txtLibrarianId.Text + "? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == System.Windows.Forms.DialogResult.Yes)
                {
                    this.librarian.delete();
                    clear();
                }                
            }
            
        }

        private void btnSearchLibrarian_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> search = new Dictionary<string, string>();
            search["name"] = txtSearchLibrarianName.Text;
            fillDataGridView(this.librarian.search(search));
        }

        private void fillDataGridView(ArrayList collection)
        { 
            dgvLibrarian.Rows.Clear();
            foreach (LibrarianClass Librarian in collection)
            {
                dgvLibrarian.Rows.Add(Librarian.LibrarianId, Librarian.Name, Librarian.Password);
            }
        }
    }
}
