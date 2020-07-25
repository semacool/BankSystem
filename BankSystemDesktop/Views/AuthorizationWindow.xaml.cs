using BankClass;
using BankSystemDesktop.Model;
using BankSystemDesktop.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BankSystemDesktop
{
    public partial class AuthorizationWindow : Window
    {
        string login;
        string password;
        BankModel Bank;

        public AuthorizationWindow()
        {
            Bank = new BankModel();   
            InitializeComponent();
        }

        private void Autho_Click(object sender, RoutedEventArgs e)
        {
            login = Login_Box.Text;
            password = Passw_Box.Password;


            if(Bank.Login(login, password, out Client client))
                OpenClientContent(client);
            else if(Bank.Login(login,password,out Worker worker))
                OpenWorkerContent(worker);
            else
                MessageBox.Show("Ошибка при входе");
        }

        private void OpenClientContent(Client client)
        {
            new ClientWindow(client).Show();
            this.Close();
        }

        private void OpenWorkerContent(Worker worker)
        {
            if(worker.Login == "admin") 
            {
                new AdminWindow().Show();
            }
            else 
            {
                new WorkerWindow(worker).Show();
            }
            this.Close();
        }
    }
}
