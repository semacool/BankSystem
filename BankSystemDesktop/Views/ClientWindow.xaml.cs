using BankClass;
using BankSystemDesktop.Model;
using BankSystemDesktop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BankSystemDesktop.Views
{
    public partial class ClientWindow : Window
    {
        public ClientWindow(Client Client)
        {
            DataContext = new ClientWindowViewModel(Client);
            InitializeComponent();
        }

        private void Transfer_Click(object sender, RoutedEventArgs e)
        {
            Client User = (DataContext as ClientWindowViewModel).Client;
            Client Friend = (DataContext as ClientWindowViewModel).SelectFriend;

            new TransferWindow(User, Friend).ShowDialog();

            RefreshList();
        }

        private void CreateCredit_Click(object sender, RoutedEventArgs e)
        {
            new CreditWindow((DataContext as ClientWindowViewModel).Client).ShowDialog();
            (DataContext as ClientWindowViewModel).UpdateSource();
            RefreshList();
        }

        private void CreateDeposit_Click(object sender, RoutedEventArgs e)
        {
            new DepositWindow((DataContext as ClientWindowViewModel).Client).ShowDialog();
            (DataContext as ClientWindowViewModel).UpdateSource();
            RefreshList();
        }

        private void RefreshList() 
        {
            CreditsList.Items.Refresh();
            DepositsList.Items.Refresh();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            new AuthorizationWindow().Show();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            new AccountWindow((DataContext as ClientWindowViewModel).SelectedAccount).Show();
        }
    }
}
