using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

using LibraryManagementSystem.Classes;

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
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MessageBox.Show("sds");
            LibrarianClass cs = new LibrarianClass();
            cs.LibrarianId = 10;

            try
            {
                SQLiteConnection con = new SQLiteConnection("Data Source=C:/Users/lasa/Downloads/sqlitestudio-3.1.1/SQLiteStudio/ssss;Version=3;");
                con.Open();
                SQLiteCommand sql_cmd = new SQLiteCommand(con);
                sql_cmd.CommandText = "SELECT * FROM librarian";
                sql_cmd.ExecuteNonQuery();

                SQLiteDataAdapter ad = new SQLiteDataAdapter("SELECT * FROM libraria", con);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                DataTable dt = new DataTable();
                dt = ds.Tables[0];

                MessageBox.Show(ds.Tables[0].TableName);
                con.Close(); 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
             

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            CategoryClass C1 = new CategoryClass();
            C1.CategoryId = 1;
            C1.TypeName = "Category 1";

            CategoryClass C2 = new CategoryClass();
            C2.CategoryId = 2;
            C2.TypeName = "Category 2";

            CategoryClass C3 = new CategoryClass();
            C3.CategoryId = 3;
            C3.TypeName = "Category 3";
            

            BookClass B1 = new BookClass();
            B1.Category = C3;
            B1.Name = "Book 1 Cat 3";

            BookClass B2 = new BookClass();
            B2.Category = C1;
            B2.Name = "Book 2 Cat 1";

            BookClass B3 = new BookClass();
            B3.Category = C2;
            B3.Name = "Book 3 Cat 2";


            BookCollectionClass BooksCollection = new BookCollectionClass();


            BooksCollection.addBook(B1);
            BooksCollection.addBook(B3);
            BooksCollection.addBook(B2);


            BooksCollection.sortBook();



            listBox1.Items.Clear();

            foreach (BookClass Book in BooksCollection.BooksCollection)
            {
                listBox1.Items.Add(Book.Name);
            }
            //for (int iterator = 0; iterator < Books.Count ; iterator++)
            //{
            //    for (int index = 0; index < Books.Count - 1; index++)
            //    {

            //        if (Books[index].Category.CategoryId > Books[index+1].Category.CategoryId)
            //        {
            //            BookClass tmp = null;
            //            tmp = Books[index];
            //            Books[index] = Books[index+1];
            //            Books[index+1] = tmp;
            //        }
            //    }
            //}

            

            listBox1.Items.Add("-------------------");
            foreach (BookClass Book in BooksCollection.BooksCollection)
            {
                listBox1.Items.Add(Book.Name);
            }
             

            //this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=C:\\Users\\lasa\\Downloads\\sqlitestudio-3.1.1\\SQLiteStudio\\ssss.db;Version=3;");
            MessageBox.Show("sds");
            LibrarianClass cs = new LibrarianClass();
            cs.LibrarianId = 10;

            //try
            //{
            //    SQLiteConnection con = new SQLiteConnection("Data Source=C:/Users/lasa/Downloads/sqlitestudio-3.1.1/SQLiteStudio/ssss;Version=3;");
            //    con.Open();
            //    SQLiteCommand sql_cmd = new SQLiteCommand(con);
            //    sql_cmd.CommandText = "SELECT * FROM librarian";
            //    sql_cmd.ExecuteNonQuery();

            //    SQLiteDataAdapter ad = new SQLiteDataAdapter("SELECT * FROM libraria", con);
            //    DataSet ds = new DataSet();
            //    ad.Fill(ds);
            //    DataTable dt = new DataTable();
            //    dt = ds.Tables[0];

            //    MessageBox.Show(ds.Tables[0].TableName);
            //    con.Close();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
