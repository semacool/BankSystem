using System;

namespace BankClass
{
    public interface IRate
    {
        uint Id { get; set; }

        string TypeClient { get; }
        string TypeRate { get; }

        string Name { get; set; }
        double Percent { get; set; }
        TimeSpan TimeForNext { get; set; }
        bool Active { get; set; }
    }
}
