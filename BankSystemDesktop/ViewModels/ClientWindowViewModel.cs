using BankClass;
using BankSystemDesktop.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Input;

namespace BankSystemDesktop.ViewModels
{
    public class ClientWindowViewModel : INotifyPropertyChanged
    {
        BankModel Bank;
        public ObservableCollection<Client> ClientsFriends { get; set; }
        public Client SelectFriend { get; set; }

        public string Name { get; set; }
        public string Contacts { get; set; }
        public Client Client { get; set; }

        public ObservableCollection<Account> credits;
        public ObservableCollection<Account> Credits 
        {
            get => credits;
            set 
            {
                credits = value;
                OnPropertyChanged("Credits");
            }
        }

        public ObservableCollection<Account> deposits;
        public ObservableCollection<Account> Deposits
        {
            get => deposits;
            set 
            {
                deposits = value;
                OnPropertyChanged("Deposits");
            }
        }

        public ClientWindowViewModel(Client Client)
        {
            Bank = new BankModel(); 
            this.Client = Client;
            Name = Client.Name;
            Contacts = Client.Contacts;

            UpdateSource();
            ClientsFriends = Bank.GetClients();
        }

        public void UpdateSource() 
        {
            Credits = new ObservableCollection<Account>(Bank.GetAccounts(Client.Id, "Credit"));
            Deposits = new ObservableCollection<Account>(Bank.GetAccounts(Client.Id, "Deposit"));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property) 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs( property));
        }


    }
}
