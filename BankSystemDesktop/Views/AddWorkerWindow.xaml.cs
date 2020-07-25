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
    /// Логика взаимодействия для AddWorkerWindow.xaml
    /// </summary>
    public partial class AddWorkerWindow : Window
    {
        BankModel Bank;
        uint IdDepartment;
        public AddWorkerWindow(uint IdDepartment)
        {
            Bank = new BankModel();
            this.IdDepartment = IdDepartment;

            InitializeComponent();
        }

        private void SaveBut_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTB.Text;
            string salary = SalaryTB.Text;
            string login = LoginTB.Text;
            string password = PasswordTB.Text;

            try 
            {
                CheckValues(name,salary,login,password);
                Bank.AddWorker(name, double.Parse(salary), IdDepartment, login, password);
                this.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void CheckValues(string Name, string Salary, string Login, string Password) 
        {
            if (string.IsNullOrEmpty(Name)) throw new Exception("Введите имя");
            if (!double.TryParse(Salary,out double s)) throw new Exception("Проверьте заплату");
            if (string.IsNullOrEmpty(Login)) throw new Exception("Введите логин");
            if (string.IsNullOrEmpty(Password)) throw new Exception("Введите пароль");
        }
    }
}
