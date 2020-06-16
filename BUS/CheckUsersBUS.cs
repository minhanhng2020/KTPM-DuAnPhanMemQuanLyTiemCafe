using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;

namespace BUS
{
    public class CheckUsersBUS
    {
        public class chkusrs
        {
            CheckLogin c = new CheckLogin();
            public bool Login(string username, string password)
            {
                return c.ChckLgn(username, password);
            }
        }
    }
}
