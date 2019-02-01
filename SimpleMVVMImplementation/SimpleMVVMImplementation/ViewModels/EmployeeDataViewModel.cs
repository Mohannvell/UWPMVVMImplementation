using GalaSoft.MvvmLight.Command;
using SimpleMVVMImplementation.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SimpleMVVMImplementation.ViewModels {
    public class EmployeeDataViewModel:BaseViewModel {
        private string _Name;
        private string _Department;
        private string _Email;

        public string Name {
            get {
                return _Name;
            }
            set {
                _Name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public string Department {
            get {
                return _Department;
            }
            set {
                _Department = value;
                NotifyPropertyChanged("Department");
            }
        }

        public string Email {
            get {
                return _Email;
            }
            set {
                _Email = value;
                NotifyPropertyChanged("Email");
            }
        }

        //List to display the added items
        private ObservableCollection<EmployeeData> _EmployeeList;
        public ObservableCollection<EmployeeData> EmployeeList {
            get
                {
                return _EmployeeList;
            }
            set {
                _EmployeeList = value;
            }
        }

        public EmployeeDataViewModel() {
            _EmployeeList = new ObservableCollection<EmployeeData>();
            _EmployeeList.Add(new EmployeeData() { Name = "Mohan", Department = "IT", Email = "mohan@gmail.com" });
            _EmployeeList.Add(new EmployeeData() { Name = "Vel", Department = "Testing", Email = "vel@gmail.com" });

            //Adds a new item to the collection
            AddToMaster = new RelayCommand(() => {
                string _Name = this.Name;
                string _Department = this.Department;
                string _Email = this.Email;

                _EmployeeList.Add(new EmployeeData {
                    Name = _Name,
                    Department = _Department,
                    Email = _Email
                });
                this.Name = "";
                this.Department = "";
                this.Email = "";
            });

            //Removes selected item from collection
            DeleteFromMaster = new RelayCommand(() => {
                _EmployeeList.Remove(ItemToDelete);
            });
        }

        public EmployeeData ItemToDelete { get; set; } //property to hold selected item

        public ICommand AddToMaster { get; set; } //Command to add a new item
        public ICommand DeleteFromMaster { get; set; } //Command to delete an item
    }
}
