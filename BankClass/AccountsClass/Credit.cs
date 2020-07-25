using System;
using System.Collections.Generic;
using System.Text;

namespace BankClass.AccountsClass
{
    public class Credit : Account
    {
        public double Dept { get; set; }
        public override void Update()
        {
            Dept += Dept * Rate.Percent;
        }
    }
}
