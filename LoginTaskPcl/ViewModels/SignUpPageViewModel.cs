using LoginTaskPcl.Adapters;
using LoginTaskPcl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginTaskPcl.ViewModels
{
    public class SignUpPageViewModel : ViewModel
    {

        public void Init()
        {
            this.IsBusy = true;
            if (this.Customer == null)
            {
                this.Customer = new Customer();
            }
            this.IsBusy = false;
        }

        public async Task<PrxCustomer> SignUp()
        {
            this.IsBusy = true;
            this.Customer.SignupIP = WebService.GetIpAddress();
            PrxCustomer prxCustomer = await WebService.RegisterCustomer(this.Customer);
            this.IsBusy = false;
            return prxCustomer;
        }

        public void Reset()
        {
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
            this.Mobile = string.Empty;
            this.Email = string.Empty;
            this.Password = string.Empty;
            this.aID = 0;
            this.CountryID = 0;
        }

        public string Email
        {
            get
            {
                return this.Customer?.Email;
            }
            set
            {
                if (this.Customer.Email != value)
                {
                    this.Customer.Email = value;
                    OnPropertyChanged("Email");
                }
                
            }
        }

        public string FirstName
        {
            get
            {
                return this.Customer?.FirstName;
            }
            set
            {
                if (this.Customer.FirstName != value)
                {
                    this.Customer.FirstName = value;
                    OnPropertyChanged("FirstName");
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.Customer?.LastName;
            }
            set
            {
                if (this.Customer.LastName != value)
                {
                    this.Customer.LastName = value;
                    OnPropertyChanged("LastName");
                }
            }
        }

        public string Mobile
        {
            get
            {
                return this.Customer?.Mobile;
            }
            set
            {
                if (this.Customer.Mobile != value)
                {
                    this.Customer.Mobile = value;
                    OnPropertyChanged("Mobile");
                }
            }
        }

        public int CountryID
        {
            get
            {
                return this.Customer.CountryID;
            }
            set
            {
                if (this.Customer.CountryID != value)
                {
                    this.Customer.CountryID = value;
                    OnPropertyChanged("CountryID");
                }
            }
        }

        public int aID
        {
            get
            {
                return this.Customer.aID;
            }
            set
            {
                if (this.Customer.aID != value)
                {
                    this.Customer.aID = value;
                    OnPropertyChanged("aID");
                }
            }
        }
    }
}
