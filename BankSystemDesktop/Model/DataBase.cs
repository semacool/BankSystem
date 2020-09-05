using BankClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystemDesktop.Model
{
    public static class DataBase
    {
        
        public static List<Worker> Workers { get; set; }
        public static List<Transfer> Transfers { get; set; }

        public static List<Client> Clients { get; set; }
        public static List<Account> Accounts { get; set; }
        public static List<IRate> Rates { get; set; }
        public static List<IDepartment> Departments { get; set; }

        static DataBase() 
        {

            Transfers = new List<Transfer>();
            Workers = new List<Worker>();
            Clients = new List<Client>();
            Accounts = new List<Account>();
            Rates = new List<IRate>();
            Departments = new List<IDepartment>();
        }
    }
}
