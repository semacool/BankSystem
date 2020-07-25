using System;
using System.Collections.Generic;
using System.Text;

namespace BankClass
{
    public abstract class Client: Person
    {
        public uint Id { get; set; }
        public uint IdDepartment { get; set; }
        public string Contacts { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
