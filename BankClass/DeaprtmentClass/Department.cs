using BankClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankClass
{
    public class Department<T> : IDepartment
        where T:Client  
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string TypeClients => typeof(T).Name;
    }
}
