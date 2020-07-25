using System;
using System.Collections.Generic;
using System.Text;

namespace BankClass
{
    interface IAccount
    {
        uint Id { get; set; }
        double Money { get; set; }
        IRate Rate { get; set; }
        void Update();
    }
}
