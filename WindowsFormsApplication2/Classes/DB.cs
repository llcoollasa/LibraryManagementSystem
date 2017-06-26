using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using LibraryManagementSystem.Classes;
using System.Windows.Forms;
using System.Collections;
using System.Data;

namespace LibraryManagementSystem.Classes
{
    class DB
    {
        private SqlConnection sqlConnection = null;
        private SqlCommand sqlCommand = null;

        /// <summary>
        /// Open DB Connection
        /// </summary>
        public DB()
        {
            String conStr = ConfigurationManager.ConnectionStrings["LibraryManagementConnection"].ConnectionString;

            try
            {
                if (this.sqlConnection == null)
                {
                    this.sqlConnection = new SqlConnection(conStr);
                    this.sqlConnection.Open();
                }
                else
                {
                    if (this.sqlConnection.State == System.Data.ConnectionState.Closed)
                    {
                        this.sqlConnection.Open();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Get Select SQL result set
        /// </summary>
        /// <param name="sql">SELECT SQL Statement</param>
        /// <returns>Result as DataTable</returns>
        public DataTable getResult(String sql)
        {
            DataTable dt = new DataTable();
            if (this.sqlConnection.State != System.Data.ConnectionState.Closed)
            {                
                SqlDataAdapter da = new SqlDataAdapter(sql, this.sqlConnection);
                da.Fill(dt);                
            }
            else
            {
                MessageBox.Show("Connection Lost", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
            return dt;
        }

        /// <summary>
        /// Execute non query statements
        /// </summary>
        /// <param name="sql">INSERT/DELETE/UPDATE SQL Statement</param>
        /// <returns>Result as DataTable</returns>
        public int executeNonQuery(String sql)
        {
            int result = 0;

            if (this.sqlConnection.State != System.Data.ConnectionState.Closed)
            {
                this.sqlCommand = new SqlCommand(sql, this.sqlConnection);
                result = this.sqlCommand.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Connection Lost", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        /// <summary>
        /// Close DB Connection
        /// </summary>
        public void closeConnection()
        {
            if (this.sqlConnection.State != System.Data.ConnectionState.Closed)
            {
                this.sqlConnection.Close();
            }            
        }
        /// <summary>
        /// Prepare Search SQL Statement
        /// </summary>
        /// <returns></returns>
        public string prepareSearchSql(Dictionary<string, string> parameters, string sql)
        {
            int paramCount = 0;
            foreach (var item in parameters)
            {
                String param = item.Key + " LIKE '" + item.Value + "%'";
                if (paramCount > 0)
                {
                    sql += " AND " + param;
                }
                else
                {
                    sql += param;
                }

                paramCount++;
            }
            return sql;
        }
    }
}
