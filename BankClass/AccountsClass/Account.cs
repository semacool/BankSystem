using System;
using System.Collections.Generic;
using System.Text;

namespace BankClass
{
    public abstract class Account : IAccount
    {
        public event Action<IAccount, double> ChangeMoney;
        public uint Id { get; set; }
        public IRate Rate { get; set; }
        double money;
        public double Money 
        {
            get => money;
            set
            {
                if (value < 0) throw new Exception("Недостаточно средств");
                if (money > value) ChangeMoney?.Invoke(this, value - money);
                else ChangeMoney?.Invoke(this, value - money);
                money = value;
            }
        }
        public uint IdClient { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime NextUpdate { get; set; }
        public DateTime DateEnd { get; set; }

        public void ToTransfer(double Money, IAccount account)
        {
            
            if (Money <= 0) throw new Exception("Проверьте правильность сумыы");
            this.Money -= Money;
            account.Money += Money;
        }

        public virtual void Update() { }
    }
}
