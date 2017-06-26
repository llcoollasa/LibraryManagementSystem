using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryManagementSystem.Classes;
using System.Collections; 
using System.Data;

namespace LibraryManagementSystem
{
    public class CategoryClass : ICRUDOperations
    {
        private int cat_id;

        public int CategoryId
        {
            get { return cat_id; }
            set { cat_id = value; }
        }
        private string type_name;

        public string TypeName
        {
            get { return type_name; }
            set { type_name = value; }
        }

        public int save()
        {
            String sql = "INSERT INTO category(type_name) VALUES('" + this.type_name + "')";
            return Program.db.executeNonQuery(sql);
        }

        public int update()
        {
            //UPDATE INTO librarian() VALUES()
            String sql = "UPDATE category SET type_name = '" + this.type_name + "' WHERE cat_id = " + this.cat_id;
            return Program.db.executeNonQuery(sql);
        }

        public int delete()
        {
            String sql = "DELETE FROM category WHERE cat_id = " + this.cat_id;
            return Program.db.executeNonQuery(sql);
        }
        
        public bool get()
        {
            bool result = false;
            String sql = "SELECT type_name FROM category WHERE cat_id = " + this.cat_id; 
            DataTable dt = new DataTable();
            dt = Program.db.getResult(sql);

            if (dt.Rows.Count > 0)
            {
                this.type_name = dt.Rows[0].Field<String>("type_name");
                result = true;
            }
            return result;

        }

        public ArrayList getAll()
        {
            String sql = "SELECT * FROM category";
            return makeCollection(sql);
        }

        public ArrayList search(Dictionary<string, string> parameters)
        {
            String sql = "SELECT * FROM category WHERE ";
            sql = Program.db.prepareSearchSql(parameters, sql);
            return makeCollection(sql);
        }

        public ArrayList makeCollection(String sql)
        {
            ArrayList categoryCollection = new ArrayList();            
            DataTable dt = new DataTable();
            dt = Program.db.getResult(sql);
            
            //add category to list
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    CategoryClass category = new CategoryClass();
                    category.CategoryId = item.Field<Int32>("cat_id");
                    category.TypeName = item.Field<String>("type_name");
                    categoryCollection.Add(category);
                }
            }
            return categoryCollection;

        }
    }
}
