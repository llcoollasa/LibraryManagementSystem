using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Classes
{
    class DB
    {
        public SqlConnection cnn;

        public DB()
        {
             
        }

        public string connect()
        {
            return "Connection";
        }
    }
}
