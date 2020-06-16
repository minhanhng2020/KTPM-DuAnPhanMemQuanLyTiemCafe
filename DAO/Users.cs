using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DAO
{
    public class Users:DataProvider
    {
        public bool Login(string username, string password)
        {
            Connect(); string sql = "SELECT COUNT (Username) FROM Users WHERE Username = '" + username + "' AND Password = '" + password + "' ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;

            int NumberOfRows = (int)cmd.ExecuteScalar();

            Disconnect();
            if (NumberOfRows > 0)
                return true;
            else
                return false;
        }
    }
}
