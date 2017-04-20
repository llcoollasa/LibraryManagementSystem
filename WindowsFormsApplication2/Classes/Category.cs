using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagementSystem
{
    public class CategoryClass
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
    }
}
