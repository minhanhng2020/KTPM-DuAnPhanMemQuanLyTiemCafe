using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAO
{
    public class TableDAO:DataProvider
    {
        public DataTable Get()
        {
            string sql = "SELECT * FROM Tables";
            return GetTable(sql);
        }
    }
}
