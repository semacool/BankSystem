using BankClass;
using BankSystemDesktop.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace BankSystemDesktop.ViewModels
{
    class AccountViewModel : ViewModel
    {
        BankModel Bank;
        public ObservableCollection<Transfer> History { get; set; }
        public Account Account { get; set; }
        public AccountViewModel(Account Account) 
        {
            Bank = new BankModel();
            this.Account = Account;
            History = Bank.GetTransfers(Account.Id);
        }
    }
}
