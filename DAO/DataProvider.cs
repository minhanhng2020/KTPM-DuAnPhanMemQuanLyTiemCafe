using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DataProvider
    {
        /*Thiết lập kết nối đến Cơ Sở Dữ Liệu nằm ở phần mềm SQL Server*/
        public SqlConnection cn;

        /*Đường dẫn đến Cơ Sở Dữ Liệu: Data Source=OULABW7T;Initial Catalog=CoffeeShop;Integrated Security=True*/
        public DataProvider()
        {
            //string cnStr = "Data Source=.;Initial Catalog=CoffeeShop;Integrated Security=True";
            //Data Source=(local);Initial Catalog=CoffeeShop;User ID=sa
            string cnStr = "Data Source=(local);Initial Catalog=CoffeeShop;User ID=sa";

            cn = new SqlConnection(cnStr);
        }

        public void Connect()
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Disconnect()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }

        public int MyExecuteNonQuery(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            int sodong = cmd.ExecuteNonQuery();
            return sodong;
        }

        public SqlDataReader MyExecuteReader(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public DataTable GetTable(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();

            int sodong = da.Fill(dt);
            if (sodong>0)
                return dt;
            else
                return null;
        }
    }
}
