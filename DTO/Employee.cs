using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Employee(string id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }
    }
}
