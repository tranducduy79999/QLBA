using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Data
    {
        public SqlConnection GetConnect()
        {
            string stringConn = @"Data Source=DESKTOP-TPGL0A7;Initial Catalog=QuanLyBenhVien;Integrated Security=True";
            SqlConnection conn = new SqlConnection(stringConn);
            return conn;
        }

        public DataTable GetTable(string sql)
        {
            SqlConnection conn = GetConnect();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        public void ExcuteNonQuerry(string sql)
        {
            SqlConnection conn = GetConnect();
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            //Tại sao phải dispose: "Not calling dispose on the command won't do anything too bad." 
            //True, but don't get used to it; it's only true for SqlCommand s. On the other hand, not disposing a SqlCeCommand, 
            //for example, will cause your mobile device to run out of memory quite fast. 
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
