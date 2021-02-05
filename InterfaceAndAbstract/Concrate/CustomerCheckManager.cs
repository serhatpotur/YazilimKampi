using InterfaceAndAbstract.Abstract;
using InterfaceAndAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstract.Concrate
{
    public class CustomerCheckManager : ICustomerCheckServices
    {
        public bool CheckOfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
