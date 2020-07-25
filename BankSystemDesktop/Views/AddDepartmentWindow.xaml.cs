using BankSystemDesktop.Model;
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
    /// Логика взаимодействия для AddDepartmentWindow.xaml
    /// </summary>
    public partial class AddDepartmentWindow : Window
    {
        BankModel Bank;
        public AddDepartmentWindow()
        {
            Bank = new BankModel();
            InitializeComponent();
        }

        private void AddDepartment_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTB.Text;
            string type = (TypeCB.SelectedItem as ComboBoxItem).Tag.ToString();


            try 
            {
                CheckValues(name,type);
                Bank.AddDepartment(name, type);
                this.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CheckValues(string Name,string Type) 
        {
            if (string.IsNullOrEmpty(Name)) throw new Exception("Введите название");
            if (string.IsNullOrEmpty(Type)) throw new Exception("Выберите тип");

        }
    }
}
