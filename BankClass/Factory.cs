using BankClass.AccountsClass;
using BankClass.AccountsClass.RateClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankClass
{
    public static class Factory
    {
        //Worker
        static public Worker newWorker(
          uint Id, string Name, double Salary, uint IdDepartment,string Login,string Password)
        {
            Worker worker = new Worker
            {
                Id = Id++,
                Name = Name,
                Salary = Salary,
                IdDepartment = IdDepartment,
                Login = Login,
                Password = Password
            };

            return worker;
        }


        //Transfer
        static public Transfer newTransfer(uint Id,double Money, IAccount account)
        {
            Transfer transfer = new Transfer(Id, account, Money);

            return transfer;
        }

        //Client
        static public Client newClient(
          uint Id, string Name, string Contacts, uint IdDepartment, string TypeClient,string Login, string Password)
        {
            Client client;
            switch (TypeClient)
            {
                case "ClientVip":
                    client = new ClientVip
                    {
                        Id = Id,
                        Name = Name,
                        Contacts = Contacts,
                        IdDepartment = IdDepartment,
                        Login = Login,
                        Password = Password
                    };
                    break;

                case "ClientCom":
                    client = new ClientCom
                    {
                        Id = Id,
                        Name = Name,
                        Contacts = Contacts,
                        IdDepartment = IdDepartment,
                        Login = Login,
                        Password = Password
                    };
                    break;

                case "ClientLeg":
                    client = new ClientLeg
                    {
                        Id = Id,
                        Name = Name,
                        Contacts = Contacts,
                        IdDepartment = IdDepartment,
                        Login = Login,
                        Password = Password
                    };
                    break;
                default:
                    client = new ClientNull
                    {
                        Id = Id,
                        Name = "NullClient",
                        Contacts = "NullClient",
                    };
                    break;

            }

            return client;
        }

        //Department
        static public IDepartment newDepartment(
            uint Id,string Name, string TypeClients)
        {
            IDepartment department;
            switch (TypeClients)
            {
                case "ClientVip":
                    department = new Department<ClientVip>
                    {
                        Id = Id,
                        Name = Name,
                    };
                    break;

                case "ClientCom":
                    department = new Department<ClientCom>
                    {
                        Id = Id,
                        Name = Name,
                    };
                    break;

                case "ClientLeg":
                    department = new Department<ClientLeg>
                    {
                        Id = Id,
                        Name = Name,
                    };
                    break;
                default:
                    department = new Department<ClientNull>
                    {
                        Id = Id,
                        Name = "NULL DEPARTMENT",
                    };
                    break;

            }
                    
            return department;
        }

        //Rate
        static public IRate newRate(
            uint Id,string TypeRate, string TypeClient, string Name, double Percent, TimeSpan TimeForNext)
        {
            IRate rate = new RateNull() { Id = Id, Name = "ERROR", Percent = 0 };

            switch (TypeRate) 
            {
                case "Credit":
                    switch (TypeClient) 
                    {
                        case "ClientVip":
                            rate = new Rate<ClientVip, Credit>()
                            {
                                Id = Id,
                                Name = Name,
                                Percent = Percent,
                                TimeForNext = TimeForNext,
                                Active = true
                            };
                            break;
                        case "ClientCom":
                            rate = new Rate<ClientCom, Credit>()
                            {
                                Id = Id,
                                Name = Name,
                                Percent = Percent,
                                TimeForNext = TimeForNext,
                                Active = true

                            };
                            break;
                        case "ClientLeg":
                            rate = new Rate<ClientLeg, Credit>()
                            {
                                Id = Id,
                                Name = Name,
                                Percent = Percent,
                                TimeForNext = TimeForNext,
                                Active = true

                            };
                            break;
                    }
                    break;

                case "Deposit":
                    switch (TypeClient)
                    {
                        case "ClientVip":
                            rate = new Rate<ClientVip, Deposit>()
                            {
                                Id = Id,
                                Name = Name,
                                Percent = Percent,
                                TimeForNext = TimeForNext,
                                Active = true

                            };
                            break;
                        case "ClientCom":
                            rate = new Rate<ClientCom, Deposit>()
                            {
                                Id = Id,
                                Name = Name,
                                Percent = Percent,
                                TimeForNext = TimeForNext,
                                Active = true

                            };
                            break;
                        case "ClientLeg":
                            rate = new Rate<ClientLeg, Deposit>()
                            {
                                Id = Id,
                                Name = Name,
                                Percent = Percent,
                                TimeForNext = TimeForNext,
                                Active = true
                            };
                            break;
                    }
                    break;
            }

            return rate;
        }

        //Account
        static public Account newAccount(
            uint Id, uint IdClient,IRate Rate,DateTime DateEnd, double Money)
        {
            Account account = null;

            switch(Rate.TypeRate) 
            {
                case "Credit":
                    account = new Credit()
                    {
                        Id = Id,
                        Rate = Rate,
                        DateCreated = DateTime.Now,
                        NextUpdate = DateTime.Now + Rate.TimeForNext,
                        DateEnd = DateEnd,
                        IdClient = IdClient,
                        Money = Money,
                        Dept = Money
                    };
                    break;
                case "Deposit":
                    account = new Deposit()
                    {
                        Id = Id,
                        Rate = Rate,
                        DateCreated = DateTime.Now,
                        NextUpdate = DateTime.Now + Rate.TimeForNext,
                        DateEnd = DateEnd,
                        IdClient = IdClient,
                        Money = Money,
                    };
                    break;
            }

            return account;
        }     
    }
}
