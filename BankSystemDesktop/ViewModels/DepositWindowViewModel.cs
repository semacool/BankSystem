using BankClass;
using BankSystemDesktop.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace BankSystemDesktop.ViewModels
{
    class DepositWindowViewModel : INotifyPropertyChanged
    {
        BankModel Bank;

        public double money;
        public double Money
        {
            get { return Math.Round(money); }
            set
            {
                money = value;
                OnPropertyChanged("Money");
                EnableBut = (SelectRate != null) && (Money >= 300_000) && (Year >= 1);
            }
        }

        public byte year;
        public byte Year
        {
            get { return year; }
            set
            {
                year = value;
                OnPropertyChanged("Year");
                EnableBut = (SelectRate != null) && (Money >= 300_000) && (Year >= 1);

            }
        }

        public Client Client { get; set; }
        public ObservableCollection<IRate> Rates { get; set; }

        public IRate selectRate;
        public IRate SelectRate 
        {
            get => selectRate;
            set 
            {
                selectRate = value;
                OnPropertyChanged("SelectRate");
                EnableBut = (SelectRate != null) && (Money >= 300_000) && (Year >= 1);
            }
        }

        public bool enableBut;
        public bool EnableBut
        {
            get => enableBut;
            set
            {
                enableBut = value;
                OnPropertyChanged("EnableBut");
            }
        }

        public DepositWindowViewModel(Client Client)
        {
            Bank = new BankModel();
            this.Client = Client;
            Rates = Bank.GetRates(Client.Id, "Deposit");
        }

        public void CreateDeposit()
        {
            DateTime DateEnd = DateTime.Now + TimeSpan.FromDays(Year * 365);
            Bank.AddAccount(Client.Id, SelectRate, DateEnd, Money);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
