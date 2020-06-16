using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;

namespace BUS
{
    public class UsersBUS
    {
        Users u = new Users();
        public bool Login(string username, string password)
        {
        return u.Login(username, password);
        }        
    }
}
