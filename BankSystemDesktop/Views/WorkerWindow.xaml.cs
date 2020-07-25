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
    /// Логика взаимодействия для WorkerWindow.xaml
    /// </summary>
    public partial class WorkerWindow : Window
    {
        IDepartment Department;
        public WorkerWindow(Worker Worker)
        {
            DataContext = new WorkerWindowViewModel(Worker);
            Department = (DataContext as WorkerWindowViewModel).Department;
            InitializeComponent();
        }

        private void SeeClient_Click(object sender, RoutedEventArgs e)
        {
            Client Client = (DataContext as WorkerWindowViewModel).SelectClient;
            new ClientPage(Client).ShowDialog();
        }

        private void AddClient_Click(object sender, RoutedEventArgs e)
        {
            new AddClientWindow(Department).ShowDialog();
            (DataContext as WorkerWindowViewModel).UpdateSource();
        }

        private void AddRate_Click(object sender, RoutedEventArgs e)
        {
            new AddRateWindow(Department).ShowDialog();
            (DataContext as WorkerWindowViewModel).UpdateSource();
        }

        private void ActiveRate_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as WorkerWindowViewModel).ActiveRate();
            (DataContext as WorkerWindowViewModel).UpdateSource();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            new AuthorizationWindow().Show();
        }
    }
}
