using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class CheckLogin:DataProvider
    {
        public bool cLgn(string username, string password)
        {
            Connect();

            string sql = "SELECT COUNT(Username) FROM Users WHERE Username = '" + username + "' AND Password = '" + password + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            int sodong = (int)cmd.ExecuteScalar();

            Disconnect();
            if (sodong > 0)
                return true;
            else
                return false;
        }
    }
}
