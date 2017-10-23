﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int customerId)
        {
            this.CustomerID = customerId;
        }

        public static int instanceCount { get; set; }
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string EmailAddress { get; set; }

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

        public Customer Retrieve(int customerId)
        {
            return new Customer()
        }

        public bool Save()
        {
            return true;
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }




        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }


    }
}
