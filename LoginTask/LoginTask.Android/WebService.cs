using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using LoginTask.Droid;
using LoginTaskPcl.Models;
using System.Net;

[assembly: Xamarin.Forms.Dependency(typeof(WebService))]
namespace LoginTask.Droid
{
    public class WebService : LoginTaskPcl.Adapters.IWebService
    {

        com.mekashron.isapi.IICUTechservice _webService;

        public void Init()
        {
            if (_webService == null)
            {
                _webService = new com.mekashron.isapi.IICUTechservice();
            }
        }

        public string Login(Customer customer)
        {
            Init();
            string result = string.Empty;
            result = _webService.Login(customer.Email, customer.Password, customer.SignupIP);
            return result;
        }

        public string RegisterCustomer(Customer customer)
        {
            Init();
            string result = string.Empty;
            result = _webService.RegisterNewCustomer(customer.Email, customer.Password, customer.FirstName, customer.LastName, customer.Mobile, customer.CountryID, customer.aID, customer.SignupIP);
            return result;
        }

        public string GetIpAddress()
        {
            IPAddress[] adresses = Dns.GetHostAddresses(Dns.GetHostName());

            if (adresses != null && adresses[0] != null)
            {
                return adresses[0].ToString();
            }
            else
            {
                return null;
            }
        }
    }
}