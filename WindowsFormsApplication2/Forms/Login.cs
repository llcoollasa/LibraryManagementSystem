using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using LibraryManagementSystem.Classes;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
namespace LibraryManagementSystem
{    
    
    public partial class Login : Form
    {

        private LibrarianClass librarian = null;

        public LibrarianClass Librarian
        {
            get { return librarian; }
            set { librarian = value; }
        }
         

        public Login()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;       
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //load librarian class
            this.Librarian = new LibrarianClass();

            //search username and password
            this.Librarian.Name = this.txtLibrarianName.Text;
            this.Librarian.Password = this.txtPassword.Text;

            //if exists allow system else leave system
            if (this.Librarian.login())
            {
                this.lblInvalidCredintials.Visible = false;
                this.Hide();
            }
            else
            {
                this.lblInvalidCredintials.Visible = true;
            }
        } 

        
        
    }
}
