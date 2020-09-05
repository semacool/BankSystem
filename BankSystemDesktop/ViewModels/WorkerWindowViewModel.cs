using BankClass;
using BankSystemDesktop.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Automation;

namespace BankSystemDesktop.ViewModels
{
    class WorkerWindowViewModel : ViewModel
    {
        BankModel Bank;

        public Worker Worker { get; set; }
        public IDepartment Department { get; set; }

        ObservableCollection<Client> clients;
        public ObservableCollection<Client> Clients
        {
            get => clients;
            set 
            {
                clients = value;
                OnPropertyChanged("Clients");
            }
        }
        public Client selectClient;
        public Client SelectClient
        {
            get => selectClient;
            set
            {
                selectClient = value;
                OnPropertyChanged("selectClient");
            }
        }


        ObservableCollection<IRate> rates;
        public ObservableCollection<IRate> Rates
        {
            get => rates;
            set
            {
                rates = value;
                OnPropertyChanged("Rates");
            }
        }
        public IRate selectRate;
        public IRate SelectRate 
        {
            get => selectRate;
            set 
            {
                selectRate = value;
                OnPropertyChanged("SelectRate");
            }
        }



        public WorkerWindowViewModel(Worker Worker)
        {
            Bank = new BankModel();
            this.Worker = Worker;
            Department = Bank.GetDepartment(Worker.IdDepartment);
            Rates = Bank.GetRates(Worker.IdDepartment);
            Clients = Bank.GetClients(Worker.IdDepartment);
        }

        public void ActiveRate() 
        {
            Bank.ActiveRate(SelectRate.Id);
        }

        public void UpdateSource()
        {
            Rates = Bank.GetRates(Worker.IdDepartment);
            Clients = Bank.GetClients(Worker.IdDepartment);
        }
    }
}
