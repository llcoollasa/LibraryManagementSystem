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
    public partial class Member : Form
    {
        private MemberClass memberClass;

        public Member()
        {
            InitializeComponent();
            memberClass = new MemberClass();
        }

        private void Member_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void fillDataGridView(ArrayList collection)
        {
            dgvMember.Rows.Clear();
            foreach (MemberClass item in collection)
            {
                dgvMember.Rows.Add(item.MemberId, item.First, item.Last, item.RegisteredDate, item.Active);
            }
        }

        private void clear()
        {
            this.memberClass = null;
            this.memberClass = new MemberClass();
            Helper.clearForm(this);
            fillDataGridView(this.memberClass.getAll());
        }

        private void btnSaveMember_Click(object sender, EventArgs e)
        {
            if (Helper.validate(this))
            {
                this.memberClass.First = txtFirst.Text;
                this.memberClass.Last = txtLast.Text;
                this.memberClass.RegisteredDate = dtpRegisteredDate.Value;
                this.memberClass.Active = chkAvailable.Checked;
                this.memberClass.save();
                clear();
            }
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            if (Helper.validate(this) && txtMemberId.Text != "")
            {
                this.memberClass.MemberId = Convert.ToInt32(txtMemberId.Text);
                this.memberClass.First = txtFirst.Text;
                this.memberClass.Last = txtLast.Text;
                this.memberClass.RegisteredDate = dtpRegisteredDate.Value;
                this.memberClass.Active = chkAvailable.Checked;
                this.memberClass.update();
                clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if (txtMemberId.Text != "")
            {
                this.memberClass.MemberId = Convert.ToInt32(txtMemberId.Text);
                DialogResult DR = MessageBox.Show("Delete " + txtMemberId.Text + "? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == System.Windows.Forms.DialogResult.Yes)
                {
                    this.memberClass.delete();
                    clear();
                }
            }
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> search = new Dictionary<string, string>();
            search["first"] = txtSearchMemberName.Text;
            fillDataGridView(this.memberClass.search(search));
        }

        private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dgvMember.Rows[e.RowIndex].Cells[0].Value != null)
            {
                txtMemberId.Text = dgvMember.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtFirst.Text = dgvMember.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLast.Text = dgvMember.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpRegisteredDate.Value = DateTime.Parse(dgvMember.Rows[e.RowIndex].Cells[3].Value.ToString());
                chkAvailable.Checked = Boolean.Parse(dgvMember.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
        }
    }
}
