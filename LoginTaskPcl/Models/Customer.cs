﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginTaskPcl.Models
{
    public class Customer
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Mobile { get; set; }

        public int CountryID { get; set; }

        public int aID { get; set; }

        public string SignupIP { get; set; }
        
    }
}
