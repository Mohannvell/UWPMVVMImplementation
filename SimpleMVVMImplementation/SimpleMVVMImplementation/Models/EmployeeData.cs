using SimpleMVVMImplementation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVVMImplementation.Models {
    public class EmployeeData : BaseViewModel {
        private string _Name;
        public string Name {
            get {
                return _Name;
            }
            set {
                _Name = value;

            }
        }

        private string _Email;
        public string Email {
            get {
                return _Email;
            }
            set {
                _Email = value;
            }
        }

        private string _Department;
        public string Department {
            get {
                return _Department;
            }
            set {
                _Department = value;
            }
        }

    }
}
