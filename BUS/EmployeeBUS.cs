using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace BUS
{
    public class EmployeeBUS
    {
        EmployeeDAO eDAO = new EmployeeDAO();

        public List<Employee> LoadEmployee()
        {
            return eDAO.LoadEmployee();
        }

        public int Add(Employee e)
        {
            return eDAO.Add(e);
        }

        public int Edit(Employee s)
        {
            return eDAO.Edit(s);
        }

        public int Del(Employee s)
        {
            return eDAO.Del(s);
        }

        public int Delete(string id)
        {
            return eDAO.Delete(id);
        }
    }
}