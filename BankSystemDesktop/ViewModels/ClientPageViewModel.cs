using BankClass;
using BankSystemDesktop.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace BankSystemDesktop.ViewModels
{
    class ClientPageViewModel : ViewModel
    {
        BankModel Bank;
        public ObservableCollection<Client> ClientsFriends { get; set; }
        public Client SelectFriend { get; set; }

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

        public ClientPageViewModel(Client Client)
        {
            Bank = new BankModel();
            this.Client = Client;
            Credits = new ObservableCollection<Account>(Bank.GetAccounts(Client.Id, "Credit"));
            Deposits = new ObservableCollection<Account>(Bank.GetAccounts(Client.Id, "Deposit"));
            ClientsFriends = Bank.GetClients();
        }

    }

}
