using System;
using System.Collections.Generic;
using System.Text;

namespace BankClass
{
    public class Worker : Person
    {
        public uint Id { get; set; }
        public double Salary { get; set; }
        public uint IdDepartment { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
