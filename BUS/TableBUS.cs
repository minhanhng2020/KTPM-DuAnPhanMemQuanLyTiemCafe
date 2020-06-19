using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;

namespace BUS
{
    public class TableBUS
    {
        TableDAO tableDAO = new TableDAO();
        public DataTable Get()
        {
            return tableDAO.Get();
        }
    }
}
