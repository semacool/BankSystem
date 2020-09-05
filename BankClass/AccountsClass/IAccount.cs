using System;
using System.Collections.Generic;
using System.Text;

namespace BankClass
{
    public interface IAccount
    {
        uint Id { get; set; }
        double Money { get; set; }
        IRate Rate { get; set; }
        void ToTransfer(double Money, IAccount account);
        void Update();
    }
}
