using LoginTaskPcl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginTaskPcl.Adapters
{
    public interface IWebService
    {
        string Login(Customer customer);

        string RegisterCustomer(Customer customer);

        string GetIpAddress();
    }
}
