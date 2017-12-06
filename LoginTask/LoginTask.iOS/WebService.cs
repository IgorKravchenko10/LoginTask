using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using LoginTaskPcl.Adapters;
using LoginTaskPcl.Models;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace LoginTask.iOS
{
    public class WebService : IWebService
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
            String ipAddress = string.Empty;

            foreach (var networkInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || networkInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    foreach (var addressInfo in networkInterface.GetIPProperties().UnicastAddresses)
                    {
                        if (addressInfo.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            ipAddress = addressInfo.Address.ToString();
                        }
                    }
                }
            }
            return ipAddress;
        }
    }
}