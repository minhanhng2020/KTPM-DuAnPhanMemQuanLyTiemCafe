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
            string cnStr = "Data Source=OULABW7T;Initial Catalog=CoffeeShop;Integrated Security=True";
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
    }
}
