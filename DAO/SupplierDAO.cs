using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class SupplierDAO:DataProvider
    {
        public List<Supplier> LoadSupplier()
        {
            Connect();
            List<Supplier> l = new List<Supplier>();
            string sql = "SELECT * FROM Supplier";

            SqlDataReader dr = MyExecuteReader(sql);
            string id, name, address;

            while (dr.Read())
            {
                id = dr[0].ToString();
                name = dr[1].ToString();
                address = dr[2].ToString();

                if (id != null || id != "" || name != null || name != "")
                {
                    Supplier sp = new Supplier(id, name, address);
                    l.Add(sp);
                }
            }
            dr.Close();

            Disconnect();

            return l;
        }

        public int Add(Supplier s)
        {
            string sql = "INSERT INTO Supplier VALUES(N'"+s.Id+"', N'"+ s.Name + "', N'" + s.Address + "')"; 

            Connect();

            int result = MyExecuteNonQuery(sql);
            Disconnect();
            if (result > 0)
                return result;
            else
                return -1;
        }

        public int Edit(Supplier s)
        {
            string sql = "UPDATE Supplier SET Supplier.Name = N'" + s.Name + "', Supplier.Address = N'" + s.Address + "' WHERE Supplier.Id = N'" + s.Id + "'";

            Connect();
            
            int rsl = MyExecuteNonQuery(sql);
            Disconnect();
            if (rsl > 0)
                return rsl;
            else
                return -1;
        }

        public int Del(Supplier s)
        {
            string sql = "DELETE FROM Supplier WHERE Supplier.Id = N'" + s.Id + "'";

            Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            int rsl = cmd.ExecuteNonQuery();
            Disconnect();
            if (rsl > 0)
                return rsl;
            else
                return -1;
        }

        public int Delete(string id)
        {
            string sql = "DELETE FROM Supplier WHERE Supplier.Id = N'" + id + "'";

            Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            int rsl = cmd.ExecuteNonQuery();
            Disconnect();
            if (rsl > 0)
                return rsl;
            else
                return -1;
        }
    }
}
