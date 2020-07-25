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
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            DataContext = new AdminWindowViewModel();
            InitializeComponent();
        }

        private void AddDepartment_Click(object sender, RoutedEventArgs e)
        {
            new AddDepartmentWindow().ShowDialog();
            (DataContext as AdminWindowViewModel).UpdateSource();

        }

        private void RemoveDepartment_Click(object sender, RoutedEventArgs e)
        {
            try 
            {               
                (DataContext as AdminWindowViewModel).RemoveDepartment();
                (DataContext as AdminWindowViewModel).UpdateSource();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddWorker_Click(object sender, RoutedEventArgs e)
        {
            uint IdDepartment = (DataContext as AdminWindowViewModel).SelectDepartment.Id;
            new AddWorkerWindow(IdDepartment).ShowDialog();
            (DataContext as AdminWindowViewModel).UpdateSource();

        }

        private void RemoveWorker_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as AdminWindowViewModel).RemoveWorker();
            (DataContext as AdminWindowViewModel).UpdateSource();
        }

        private void SeeClient_Click(object sender, RoutedEventArgs e)
        {
            Client Client = (DataContext as AdminWindowViewModel).SelectClient;
            new ClientPage(Client).ShowDialog();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            new AuthorizationWindow().Show();
            
        }
    }
}
