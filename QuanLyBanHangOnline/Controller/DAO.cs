using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyBanHangOnline.Controller
{
    class DAO 
    {
        private static String connectionString = @"Server=LAPTOP-HENIB6EN\SQLEXPRESS;Database=BanHang18;User=hhsh;Password=123";

        public SqlConnection getConnection()
        {
            return new SqlConnection(connectionString);
        }
        public SqlDataAdapter getDataAdapter(String queryString)
        {
            return new SqlDataAdapter(queryString, getConnection());
        }


        public DataTable getDataSource(SqlDataAdapter sda )
        {
            DataTable dataSource = new DataTable();
            sda.Fill(dataSource);
            return dataSource;
        }


        public bool executeCommands(SqlConnection con, String queryString)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand(queryString);
                return command.ExecuteNonQuery() > 0 ;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        



    }
}
