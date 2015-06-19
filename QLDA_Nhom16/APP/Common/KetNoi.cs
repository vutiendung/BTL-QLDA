using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using Excel;

namespace WindowsFormsApplication2
{
    class KetNoi
    {
        SqlConnection conn;
        public KetNoi()
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=TIENDUNG\SQLEXPRESS;Initial Catalog=QUANLYBANTHUOC;Integrated Security=True";
            conn.Open();
        }
        public DataTable TaoBang(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
        public DataTable XemDL(string sql)
        {
            SqlDataAdapter adap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public void ThucHien(string sql)
        {
            SqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        public DataTable ThucHiencommand(string storename)
        {
            SqlCommand cmd =new SqlCommand(storename, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
      
    }
}
