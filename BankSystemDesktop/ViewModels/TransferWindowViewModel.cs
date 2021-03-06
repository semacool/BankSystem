﻿using BankClass;
using BankSystemDesktop.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace BankSystemDesktop.ViewModels
{
    class TransferWindowViewModel : ViewModel
    {
        BankModel Bank;
        public ObservableCollection<Account> Accounts { get; set; }
        public ObservableCollection<Account> FriendAccounts { get; set; }

        Account selectedAccoutUser;
        public Account SelectedAccoutUser 
        {
            get => selectedAccoutUser;
            set
            {
                selectedAccoutUser = value;
                EnableBut = (SelectedAccoutFriend != null) && (SelectedAccoutUser != null);
            }
        }

        Account selectedAccoutFriend;
        public Account SelectedAccoutFriend 
        {
            get => selectedAccoutFriend;
            set 
            {
                selectedAccoutFriend = value;
                EnableBut = (SelectedAccoutFriend != null) && (SelectedAccoutUser != null);
            }
        }

        public double Money { get; set; }

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


        public TransferWindowViewModel(Client User, Client Friend)
        {
            Bank = new BankModel();
            Accounts = Bank.GetAccounts(User.Id);
            FriendAccounts = Bank.GetAccounts(Friend.Id);

        }

        public void ToTransfer()
        {
            selectedAccoutUser.ToTransfer(Money, selectedAccoutFriend);
        }
    }
}
