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
    /// Логика взаимодействия для CreditWindow.xaml
    /// </summary>
    public partial class CreditWindow : Window
    {
        public CreditWindow(Client Client)
        {
            DataContext = new CreditWindowViewModel(Client);
            InitializeComponent();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as CreditWindowViewModel).CreateCredit();
            Close();
        }
    }
}
