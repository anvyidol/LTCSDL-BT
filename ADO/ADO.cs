using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    class ADO
    {
        public static SqlConnection conn = null;
        public static string cnstr = "";

        public static void ConnectWindowMode(string server, string database) {
            try
            {
                cnstr = $"Server = {server}; Database = {database}; Integrated Security = true;";
                conn = new SqlConnection(cnstr);
                conn.Open();
            }
            catch (Exception) 
            {
                throw new Exception("Dữ liệu sai!");
            }
        }

        public static void ConnectSQLMode(string server, string database, string username, string password)
        {

            try
            {
                cnstr = $"Server = {server}; Database = {database}; User id = {username}; password = {password}";
                conn = new SqlConnection(cnstr);
                conn.Open();
            }
            catch (Exception)
            {
                throw new Exception("Dữ liệu sai!");
            }
            
        }

        public static void Disconnect()
        {
            try
            {
                if (conn != null) {
                    cnstr = "";
                    conn.Close();
                    conn = null;
                }
            }
            catch (Exception)
            {
                throw new Exception("Lỗi disconnect!");
            }
        }
    }
}
