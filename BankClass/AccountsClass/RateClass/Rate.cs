using System;
using System.Collections.Generic;
using System.Text;

namespace BankClass.AccountsClass.RateClass
{
    public class Rate<T,A> : IRate
        where T : Client
        where A : Account
    {
        public uint Id { get; set; }
        public double Percent { get; set; }
        public string Name { get; set; }
        public TimeSpan TimeForNext { get; set; }
        public bool Active { get; set; }

        public string TypeClient => typeof(T).Name;
        public string TypeRate => typeof(A).Name;

        public override string ToString()
        {
            return $"{Name} - {Percent}%";
        }
    }
}
