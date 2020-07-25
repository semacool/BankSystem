using System;
using System.Collections.Generic;
using System.Text;

namespace BankClass.AccountsClass.RateClass
{
    public class RateNull : IRate
    {
        public uint Id { get; set; }
        public double Percent { get; set; }
        public string Name { get; set; }
        public TimeSpan TimeForNext { get; set; }
        public bool Active {
            get { return false; }
            set { } 
            }
        public string TypeClient => "ERROR";
        public string TypeRate => "ERROR";
    }
}
