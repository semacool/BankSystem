using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using BankClass;

namespace BankSystemDesktop.Model
{
    public class BankModel
    {

        //Костыль
        static bool OneTime = true;

        public BankModel()
        {
            if (OneTime)
            {
                AddDepartment("VipDepartment", "ClientVip");

                AddWorker("Кузнецов Андрей Иванович", 30000, 0, "work", "work");
                AddWorker("Исаев Семён Михайлович", 100_000, 0, "admin", "admin");

                AddClient("Корачагин Дмитрий Сергеевич", "+72913334442", 0, "ClientVip", "stud", "stud");
                AddClient("Козелов Глеб Александрович", "+223232323", 0, "ClientVip", "stud1", "stud1");

                AddRate("Deposit", "ClientVip", "TheVipDeposit", 7, TimeSpan.FromDays(30));
                AddRate("Credit", "ClientVip", "TheVipCredit", 10, TimeSpan.FromDays(30));

                AddAccount(0, DataBase.Rates[0], DateTime.Today, 40000);
                AddAccount(0, DataBase.Rates[1], DateTime.Today, 100000);
                AddAccount(1, DataBase.Rates[0], DateTime.Today, 20000);
                OneTime = false;
            }
        }
        
        //Коллекция рабочих
        #region Workers
        static uint WorkersId = 0;
        //Добавить работника
        public void AddWorker(string Name, double Salary, uint IdDepartment, string Login, string Password)
        {

            Worker worker = Factory.newWorker(WorkersId++, Name, Salary, IdDepartment, Login, Password);
            DataBase.Workers.Add(worker);
        }

        //Удалить работника
        public void RemoveWorker(uint Id)
        {
            Worker worker = DataBase.Workers.Find(w => w.Id == Id);
            DataBase.Workers.Remove(worker);
        }

        //Изменить работника
        public void ChangeWorker(uint Id, string Name, double Salary, uint IdDepartment)
        {
            Worker worker = DataBase.Workers.Find(w => w.Id == Id);

            worker.Name = Name;
            worker.Salary = Salary;
            worker.IdDepartment = IdDepartment;
        }
        #endregion

        //Коллекция транзакций
        #region Transfers
        static uint TransferId = 0;

        //Добавить транзакцию
        public void AddTransfer(uint IdAccount, double Money)
        {
            IAccount accountSource = DataBase.Accounts.Find(a => a.Id == IdAccount);

            Transfer transfer = Factory.newTransfer(TransferId++,Money,accountSource);
            DataBase.Transfers.Add(transfer);
        }

        //Удалить транзакцию
        public void RemoveTransfer(uint Id)
        {
            Transfer transfer = DataBase.Transfers.ToList().Find(a => a.Id == Id);
            DataBase.Transfers.Remove(transfer);
        }

        #endregion

        //Коллекция Клиентов
        #region Clients
        static uint ClientId = 0;
        //Добавить клиента
        public void AddClient(string Name, string Contacts, uint IdDepartment, string TypeClient, string Login, string Password)
        {

            CheckDepartment(TypeClient, IdDepartment);
            Client client = Factory.newClient(ClientId++, Name, Contacts, IdDepartment, TypeClient, Login, Password);
            DataBase.Clients.Add(client);
        }

        //Удалить клиента
        public void RemoveClient(uint Id)
        {
            Client client = DataBase.Clients.ToList().Find(c => c.Id == Id);
            DataBase.Clients.Remove(client);
        }

        //Изменить клиента
        public void ChangeClient(uint Id, string Name, string Contacts, uint IdDepartment)
        {
            Client client = DataBase.Clients.Find(c => c.Id == Id);

            CheckDepartment(client.GetType().Name, IdDepartment);

            client.Name = Name;
            client.Contacts = Contacts;
            client.IdDepartment = IdDepartment;
        }
        #endregion

        //Коллекция департаментов
        #region Departments
        static uint DepartmentId = 0;
        //Добавить отдел
        public void AddDepartment(string Name, string TypeClients)
        {
            IDepartment department = Factory.newDepartment(DepartmentId++, Name, TypeClients);
            DataBase.Departments.Add(department);
        }

        //Удалить отдел
        public void RemoveDepartment(uint Id)
        {
            IDepartment department = DataBase.Departments.ToList().Find(d => d.Id == Id);

            int count = DataBase.Workers.FindAll(e => e.IdDepartment == Id).Count;
                count += DataBase.Clients.FindAll(e => e.IdDepartment == Id).Count;

            if (count > 0) throw new Exception("Нельзя удалить департамент с клиентами или рабочими.");

            DataBase.Departments.Remove(department);
        }
        //Изменить отдел
        public void ChangeDepartment(uint Id, string Name)
        {
            IDepartment department = DataBase.Departments.ToList().Find(d => d.Id == Id);
            department.Name = Name;
        }
        #endregion

        //Коллекция тарифов
        #region Rate
        static uint RateId = 0;
        public void AddRate(string TypeRate, string TypeClient, string Name, double Percent, TimeSpan TimeForNext)
        {
            IRate rate = Factory.newRate(RateId++, TypeRate, TypeClient, Name, Percent, TimeForNext);
            DataBase.Rates.Add(rate);
        }
        public void ActiveRate(uint Id)
        {
            IRate rate = DataBase.Rates.ToList().Find(r => r.Id == Id);
            rate.Active = !rate.Active;
        }
        #endregion

        //Коллекция счетов
        #region Account
        static uint AccountId = 0;
        public void AddAccount(uint IdClient, IRate Rate, DateTime DateEnd, double Money)
        {
            CheckClient(Rate.TypeClient, IdClient);
            Account account = Factory.newAccount(AccountId++, IdClient, Rate, DateEnd, Money);
            account.ChangeMoney += NoteTrasfer;
            DataBase.Accounts.Add(account);
        }
        public void RemoveAccount(uint Id)
        {
            Account account = DataBase.Accounts.ToList().Find(a => a.Id == Id);
            DataBase.Accounts.Remove(account);
        }
        #endregion

        #region HelpsMethods
        private void CheckDepartment(string Type, uint IdDepartment)
        {
            IDepartment department = DataBase.Departments.Find(d => d.Id == IdDepartment);
            if (department == null) throw new Exception("Department not found");
            if (department.TypeClients != Type) throw new Exception("Department has a different type");
        }

        private void CheckClient(string Type, uint IdClient)
        {
            Client client = DataBase.Clients.Find(c => c.Id == IdClient);
            if (client == null) throw new Exception("Client not found");
            if (client.GetType().Name != Type) throw new Exception("Client has a different type");
        }

        #endregion

        #region UseDataBase 

        public ObservableCollection<Transfer> GetTransfers(uint IdAccount)
        {
            return new ObservableCollection<Transfer>(DataBase.Transfers.Where(e => e.Account.Id == IdAccount));
        }

        public ObservableCollection<Worker> GetWorkers(uint IdDepartment)
        {
            return new ObservableCollection<Worker>(DataBase.Workers.Where(e=> e.IdDepartment == IdDepartment));
        }

        public ObservableCollection<IDepartment> GetDepartments()
        {
            return new ObservableCollection<IDepartment>(DataBase.Departments);
        }

        public ObservableCollection<Account> GetAccounts(uint IdClient, string TypeRate)
        {
            return new ObservableCollection<Account>(DataBase.Accounts.Where(e => e.IdClient == IdClient && e.Rate.TypeRate == TypeRate));
        }
        public ObservableCollection<Account> GetAccounts(uint IdClient)
        {
            return new ObservableCollection<Account>(DataBase.Accounts.Where(e => e.IdClient == IdClient));
        }

        public ObservableCollection<IRate> GetRates(uint IdClient, string TypeRate)
        {
            Client Client = DataBase.Clients.ToList().Find(e => e.Id == IdClient);
            return new ObservableCollection<IRate>(DataBase.Rates.Where(e => e.TypeClient == Client.GetType().Name && e.TypeRate == TypeRate && e.Active == true));
        }
        public ObservableCollection<IRate> GetRates(uint IdDepartment)
        {
            IDepartment department = DataBase.Departments.Find(e => e.Id == IdDepartment);
            return new ObservableCollection<IRate>(DataBase.Rates.Where(e => e.TypeClient == department.TypeClients));
        }

        public ObservableCollection<Client> GetClients()
        {
            return new ObservableCollection<Client>(DataBase.Clients);
        }
        public ObservableCollection<Client> GetClients(uint IdDepartment)
        {
            return new ObservableCollection<Client>(DataBase.Clients.FindAll(e => e.IdDepartment == IdDepartment));
        }

        public IDepartment GetDepartment(uint Department)
        {
            IDepartment department = DataBase.Departments.Find(e => e.Id == Department);
            return department;
        }
        public bool Login(string Login, string Password, out Client Client)
        {
            Client = DataBase.Clients.ToList().Find(c => c.Login == Login && c.Password == Password);
            bool Access = Client != null;
            return Access;
        }
        public bool Login(string Login, string Password, out Worker Worker)
        {
            Worker = DataBase.Workers.ToList().Find(c => c.Login == Login && c.Password == Password);
            bool Access = Worker != null;
            return Access;
        }

        public void NoteTrasfer(IAccount account, double Money)
        {
            AddTransfer(account.Id, Money);
        }
        #endregion
    }
}
