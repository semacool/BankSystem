using BankClass;
using BankSystemDesktop.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace BankSystemDesktop.ViewModels
{

    
    class AdminWindowViewModel : ViewModel
    {
        BankModel Bank;

        ObservableCollection<IDepartment> departments;
        public ObservableCollection<IDepartment> Departments
        {
            get => departments;
            set
            {
                departments = value;
                OnPropertyChanged("Departments");
            }
        }

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

        ObservableCollection<Worker> workers;
        public ObservableCollection<Worker> Workers
        {
            get => workers;
            set
            {
                workers = value;
                OnPropertyChanged("Workers");   
            }
        }


        IDepartment selectDepartment;
        public IDepartment SelectDepartment 
        {
            get => selectDepartment;
            set 
            {
                selectDepartment = value;

                if(selectDepartment != null) 
                {
                    Clients = Bank.GetClients(selectDepartment.Id);
                    Workers = Bank.GetWorkers(selectDepartment.Id);
                }

                OnPropertyChanged("SelectDepartment");
            }
        }

        Client selectClient;
        public Client SelectClient
        {
            get => selectClient;
            set
            {
                selectClient = value;
                OnPropertyChanged("SelectClient");
            }
        }

        Worker selectWorker;
        public Worker SelectWorker
        {
            get => selectWorker;
            set
            {
                selectWorker = value;
                OnPropertyChanged("SelectWorker");
            }
        }

        public AdminWindowViewModel() 
        {
            Bank = new BankModel();
            Departments = Bank.GetDepartments();
        }

        public void RemoveWorker() 
        {
            Bank.RemoveWorker(SelectWorker.Id);
        }

        public void RemoveDepartment()
        {
            Bank.RemoveDepartment(SelectDepartment.Id);
        }

        public void UpdateSource() 
        {
            Departments = Bank.GetDepartments();
            if(SelectDepartment != null) 
            {
                Workers = Bank.GetWorkers(SelectDepartment.Id);
                Clients = Bank.GetClients(SelectDepartment.Id);
            }
        }
    }
}
