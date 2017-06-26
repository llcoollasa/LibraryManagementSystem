using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryManagementSystem.Classes;
using System.Collections;
using System.Data;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public class LibrarianClass : ICRUDOperations  
    {
        private int librarian_id;

        public int LibrarianId
        {
            get { return librarian_id; }
            set { librarian_id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password =  value;}
        }
        
        public bool login()
        {

            bool result = false;
            String sql = "SELECT * FROM librarian WHERE name = '" + this.name + "'";
            DataTable dt = new DataTable();
            dt = Program.db.getResult(sql);

            if (dt.Rows.Count > 0)
            {
                this.name = dt.Rows[0].Field<String>("name");

                if (this.password == dt.Rows[0].Field<String>("password"))
                {
                    this.password = dt.Rows[0].Field<String>("password");
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return result;           

        }

        public int save()
        {
            String sql = "INSERT INTO librarian(name,password) VALUES('"+ this.name +"', '"+ this.password+"')";
            return Program.db.executeNonQuery(sql);
        }

        public int update()
        {
            //UPDATE INTO librarian() VALUES()
            String sql = "UPDATE librarian SET name = '" + this.name + "', password='" + this.password + "' WHERE librarian_id = " + this.librarian_id;
            return Program.db.executeNonQuery(sql);
            
        }

        public int delete()
        {
            String sql = "DELETE FROM librarian WHERE librarian_id = " + this.librarian_id;
            return Program.db.executeNonQuery(sql);
        }

        public bool get()
        {
            bool result = false;
            String sql = "SELECT * FROM librarian WHERE librarian_id = " + this.librarian_id;
            DataTable dt = new DataTable();
            dt = Program.db.getResult(sql);

            if (dt.Rows.Count > 0)
            {
                this.name = dt.Rows[0].Field<String>("name");
                result = true;
            }
            return result;
        }

        public ArrayList getAll()
        {
            String sql = "SELECT * FROM librarian"; 
            return makeCollection(sql);
        } 
         

        public ArrayList search(Dictionary<string, string> parameters)
        {
            String sql = "SELECT * FROM librarian WHERE ";
            sql = Program.db.prepareSearchSql(parameters, sql);
            return makeCollection(sql);
        }

        public ArrayList makeCollection(String sql)
        { 
            ArrayList librarianCollection = new ArrayList();

            //add librarian to list
            DataTable dt = new DataTable();
            dt = Program.db.getResult(sql);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    LibrarianClass librarian = new LibrarianClass();
                    librarian.librarian_id = item.Field<Int32>("librarian_id");
                    librarian.name = item.Field<String>("name");
                    librarian.password = item.Field<String>("password");
                    librarianCollection.Add(librarian);
                }
            }
            return librarianCollection;

        }
    }
}
