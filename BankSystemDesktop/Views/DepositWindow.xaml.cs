using BankClass;
using BankSystemDesktop.ViewModels;
using System;
using System.Collections.Generic;
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
    /// <summary>
    /// Логика взаимодействия для DepositWindow.xaml
    /// </summary>
    public partial class DepositWindow : Window
    {
        public DepositWindow(Client Client)
        {
            DataContext = new DepositWindowViewModel(Client);
            InitializeComponent();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as DepositWindowViewModel).CreateDeposit();
            Close();
        }
    }
}
