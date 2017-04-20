using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryManagementSystem.Classes;

namespace LibraryManagementSystem
{
    public class LibrarianClass : Database, ICRUDOperations  
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
            set { password = value; }
        }

        public LibrarianClass()
        {
            
        }

        public bool login()
        {
            if (this.Name == "lasa")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool logout()
        {
            throw new System.NotImplementedException();
        }

         
        public bool save()
        {
            //INSERT INTO librarian() VALUES()
            return false;
        }

        public bool update()
        {
            //UPDATE INTO librarian() VALUES()
            return false;
        }

        public bool delete()
        {
            //INSERT INTO librarian() VALUES()
            return false;
        }

        public bool get()
        {
            //INSERT INTO librarian() VALUES()
            return false;
        }

        public bool getAll()
        {
            //INSERT INTO librarian() VALUES()
            return false;
        }
    }
}
