using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAO;
using DTO;

namespace BUS
{
    public class SupplierBUS
    {
        SupplierDAO sDAO = new SupplierDAO();

        public List<Supplier> LoadSupplier()
        {
            return sDAO.LoadSupplier();
        }

        public int Add(Supplier s)
        {
            return sDAO.Add(s);
        }

        public int Edit(Supplier s)
        {
            return sDAO.Edit(s);
        }

        public int Del(Supplier s)
        {
            return sDAO.Del(s);
        }

        public int Delete(string id)
        {
            return sDAO.Delete(id);
        }
    }
}
