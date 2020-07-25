using System;
using System.Collections.Generic;
using System.Text;

namespace BankClass
{
    public abstract class Account : IAccount
    {
        public uint Id { get; set; }
        public IRate Rate { get; set; }
        public double Money { get; set; }
        public uint IdClient { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime NextUpdate { get; set; }
        public DateTime DateEnd { get; set; }

        public virtual void Update() { }
    }
}
