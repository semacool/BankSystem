using BankClass;
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
    /// Логика взаимодействия для AddClientWindow.xaml
    /// </summary>
    public partial class AddClientWindow : Window
    {
        BankModel Bank;
        IDepartment Department;
        public AddClientWindow(IDepartment department)
        {
            Bank = new BankModel();
            Department = department;
            InitializeComponent();
        }

        private void AddClient_Click(object sender, RoutedEventArgs e)
        {
            string Name = NameTb.Text;
            string Contacts = ContactsTb.Text;
            string Login = LoginTb.Text;
            string Password = PasswordTb.Text;

            try
            {
                CheckClient(Name, Contacts, Login, Password);
                Bank.AddClient(Name, Contacts, Department.Id, Department.TypeClients, Login, Password);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CheckClient(string Name, string Contacts, string Login, string Password)
        {
            if (string.IsNullOrEmpty(Name)) throw new Exception("Введите имя");
            if (string.IsNullOrEmpty(Contacts)) throw new Exception("Введите контактные данные");
            if (string.IsNullOrEmpty(Login)) throw new Exception("Введите логин");
            if (string.IsNullOrEmpty(Password)) throw new Exception("Введите пароль");
        }
    }
}
