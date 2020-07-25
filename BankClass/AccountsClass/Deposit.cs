using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace BankClass.AccountsClass
{
    public class Deposit : Account
    {
        public override void Update()
        {
            Money += Money * Rate.Percent;
        }
    }
}
