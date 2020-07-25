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
    /// Логика взаимодействия для AddRate.xaml
    /// </summary>
    public partial class AddRateWindow : Window
    {
        public AddRateWindow(IDepartment department)
        {
            DataContext = new AddRateWindowViewModel(department);
            InitializeComponent();
        }

        private void AddRate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                (DataContext as AddRateWindowViewModel).AddRate();
                this.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
