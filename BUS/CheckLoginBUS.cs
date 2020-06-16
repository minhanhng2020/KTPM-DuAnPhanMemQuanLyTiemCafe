using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;

namespace BUS
{
    public class CheckLoginBUS
    {
            CheckLogin c = new CheckLogin();
            public bool ChckLgn(string username, string password)
            {
                return c.cLgn(username, password);
            }
    }
}
