using LoginTaskPcl.Adapters;
using LoginTaskPcl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginTaskPcl.ViewModels
{
    public class SignInPageViewModel : ViewModel
    {
        public string UserName
        {
            get
            {
                return this.Customer.Email;
            }
            set
            {
                if (this.Customer.Email != value)
                {
                    this.Customer.Email = value;
                    OnPropertyChanged("UserName");
                }
            }
        }

        public void Init()
        {
            this.IsBusy = true;
            if (this.Customer == null)
            {
                this.Customer = new Customer();
            }
            this.IsBusy = false;
        }

        public async Task<PrxCustomer> SignIn()
        {
            this.IsBusy = true;
            this.Customer.SignupIP = WebService.GetIpAddress();
            var prxCustomer = await WebService.Login(this.Customer);
            this.IsBusy = false;
            return prxCustomer;
        }
    }
}
