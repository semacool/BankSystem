using System;
using System.Collections.Generic;
using System.Text;

namespace BankClass
{
    public interface IDepartment
    {
        uint Id { get; set; }
        string Name {get; set; }
        string TypeClients { get;}
    }
}
