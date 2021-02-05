using InterfaceAndAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstract.Abstract
{
    public class BaseCustomerManager : ICustomerServices
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to Database"+" "+customer.FirstName);
        }
    }
}
