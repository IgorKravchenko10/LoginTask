using LoginTaskPcl.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginTaskPcl.ViewModels
{
    public abstract class ViewModel : INotifyPropertyChanged
    {
        private bool _isBusy;
        private string _status;

        public bool IsBusy
        {
            get
            {
                return _isBusy;
            }
            set
            {
                if (_isBusy != value)
                {
                    _isBusy = value;
                    OnPropertyChanged("IsBusy");
                }
            }
        }

        public string Title
        {
            get
            {
                return Properties.Resources.ApplicationTitle;
            }
        }

        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
                if (this._status != value)
                {
                    this._status = value;
                    OnPropertyChanged("Status");
                }

            }
        }

        public string Password
        {
            get
            {
                return this.Customer?.Password;
            }
            set
            {
                if (this.Customer.Password != value)
                {
                    this.Customer.Password = value;
                    OnPropertyChanged("Password");
                }
            }
        }

        public Customer Customer { get; set; }        

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
