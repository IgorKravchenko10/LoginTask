using LoginTaskPcl.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginTaskPcl.Adapters
{
    public static class WebService
    {
        public async static Task<PrxCustomer> RegisterCustomer(Customer customer)
        {
            PrxCustomer prxCustomer = await Task.Factory.StartNew(() =>
             {
                 string result = DependencyService.Get<IWebService>().RegisterCustomer(customer);
                 return JsonConvert.DeserializeObject<PrxCustomer>(result);
             });
            
            return prxCustomer;
        }

        public async static Task<PrxCustomer> Login(Customer customer)
        {
            PrxCustomer prxCustomer = await Task.Factory.StartNew(() =>
            {
                string result = DependencyService.Get<IWebService>().Login(customer);
                return JsonConvert.DeserializeObject<PrxCustomer>(result);
            });
            return prxCustomer;
        }

        public static string GetIpAddress()
        {
            return DependencyService.Get<IWebService>().GetIpAddress();
        }
    }
}
