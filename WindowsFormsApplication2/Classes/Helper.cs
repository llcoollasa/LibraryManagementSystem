using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text; 

namespace LibraryManagementSystem.Classes
{
    static class  Helper
    {
        public static void clearForm(Form frm)
        {
            foreach (Control control in frm.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.Items.Clear();
                    comboBox.Text = "";
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }

                if (control is DateTimePicker)
                {
                    DateTimePicker dateTime = (DateTimePicker) control;
                    dateTime.Value = DateTime.Today;
                }

                if (control is DataGridView)
                {
                    DataGridView dataGridView = (DataGridView)control;
                    dataGridView.Rows.Clear();
                }
            }
        }

        public static bool validate(Form frm)
        {
            bool valid = true; 

            foreach (Control control in frm.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    
                    if (textBox.ReadOnly == true)
                    {
                        continue;
                    }
                    else
                    {
                        if ( textBox.Text == "")
                        {
                            valid = false; 
                        }
                    }
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count == 0)
                    { 
                        valid = false;
                    }
                }
            }

            if (valid == false)
            {
                MessageBox.Show("Please fill the form with valid data", "Infalid Data Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return valid;
        }
    }
}
