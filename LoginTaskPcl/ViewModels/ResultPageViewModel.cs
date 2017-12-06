using LoginTaskPcl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginTaskPcl.ViewModels
{
    public class ResultPageViewModel : ViewModel
    {

        public void Init(PrxCustomer prxCustomer)
        {
            if (this.Customer == null)
            {
                this.Customer = new Customer();
            }
            this.Email = prxCustomer.Email;
            this.aID = prxCustomer.aID;
            this.CountryID = prxCustomer.CountryID;
            this.FirstName = prxCustomer.FirstName;
            this.LastName = prxCustomer.LastName;
            this.Mobile = prxCustomer.Mobile;
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
