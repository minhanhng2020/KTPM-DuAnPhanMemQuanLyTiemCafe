using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class EmployeeDAO:DataProvider
    {
        public List<Employee> LoadEmployee()
        {
            Connect();
            List<Employee> l = new List<Employee>();
            string sql = "SELECT * FROM Employees";

            SqlDataReader dr = MyExecuteReader(sql);
            string id, name, address;

            while (dr.Read())
            {
                id = dr[0].ToString();
                name = dr[1].ToString();
                address = dr[2].ToString();

                if (id != null || id != "" || name != null || name != "")
                {
                    Employee e = new Employee(id, name, address);
                    l.Add(e);
                }
            }
            dr.Close();

            Disconnect();

            return l;
        }

        public int Add(Employee s)
        {
            string sql = "INSERT INTO Employees VALUES(N'" + s.Id + "', N'" + s.Name + "', N'" + s.Address + "')";

            Connect();

            int result = MyExecuteNonQuery(sql);
            Disconnect();
            if (result > 0)
                return result;
            else
                return -1;
        }

        public int Edit(Employee s)
        {
            string sql = "UPDATE Employees SET Employees.Name = N'" + s.Name + "', Employees.Address = N'" + s.Address + "' WHERE Employees.Id = N'" + s.Id + "'";

            Connect();

            int rsl = MyExecuteNonQuery(sql);
            Disconnect();
            if (rsl > 0)
                return rsl;
            else
                return -1;
        }

        public int Del(Employee s)
        {
            string sql = "DELETE FROM Employees WHERE Employees.Id = N'" + s.Id + "'";

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
            string sql = "DELETE FROM Employees WHERE Employees.Id = N'" + id + "'";

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
