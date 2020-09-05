using System;
using System.Collections.Generic;
using System.Text;

namespace BankClass
{
    public class Transfer
    {
        public uint Id { get; private set; }
        public IAccount Account { get; private set; }
        public double Money { get; private set; }
        public DateTime DateTransfer { get; private set; }

        public Transfer(uint Id, IAccount Account, double Money)
        {
            this.Id = Id;
            this.Account = Account;
            this.Money = Money;
            DateTransfer = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{DateTransfer} ({(Money > 0? $"+{Money}":Money.ToString())})";
        }

    }
}
