using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Forms;

namespace LibraryManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static LibraryManagementSystem.Classes.DB db;
        [STAThread]
        static void Main()
        {
            db = new Classes.DB();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DashBoard());   
        }
    }
}
