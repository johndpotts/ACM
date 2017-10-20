﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Email { get; set; }

        public int CustomerID { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    { fullName += ", "; }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
    }
}
