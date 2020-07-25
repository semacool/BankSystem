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
    /// Логика взаимодействия для TransferWindow.xaml
    /// </summary>
    public partial class TransferWindow : Window
    {
        public TransferWindow(Client User,Client Friend)
        {
            DataContext = new TransferWindowViewModel(User, Friend);
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                (DataContext as TransferWindowViewModel).ToTransfer();
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
