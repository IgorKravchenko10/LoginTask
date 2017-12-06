using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginTaskPcl.Models
{
    public class PrxCustomer : Customer
    {
        public int EntityId { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public int EmailConfirm { get; set; }
        public int MobileConfirm { get; set; }
        public int Status { get; set; }
        public string lid { get; set; }
        public string FTPHost { get; set; }
        public int FTPPort { get; set; }
        public int ResultCode { get; set; }
        public string ResultMessage { get; set; }
    }
}
