using BankClass;
using BankSystemDesktop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BankSystemDesktop.ViewModels
{
    class AddRateWindowViewModel : INotifyPropertyChanged
    {
        BankModel Bank;
        public byte month;
        public byte Month 
        {
            get => month;
            set 
            {
                month = value;
                OnPropertyChanged("Month");
            }
        }
        public string[] TypeRates => new string[2] { "Deposit", "Credit" };

        public string SelectRate { get; set; }
        public string Name { get; set; }
        public double Percent { get; set; }
        IDepartment Department;

        public AddRateWindowViewModel(IDepartment department) 
        {
            Department = department;
            Bank = new BankModel();
        }

        public void AddRate() 
        {
            TimeSpan time = TimeSpan.FromDays(Month * 30);
            CheckRate();
            Bank.AddRate(SelectRate, Department.TypeClients, Name, Percent, time);
        }

        private void CheckRate() 
        {
            if (SelectRate == null) throw new Exception("Выберите тип тарифа");
            if (Name == null) throw new Exception("Введите имя тарифа");
            if (Percent == 0) throw new Exception("Проверьте введёный процент");
            if (Month == 0) throw new Exception("Проверьте выбранный период");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property) 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
