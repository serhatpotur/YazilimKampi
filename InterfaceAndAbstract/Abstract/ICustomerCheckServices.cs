using InterfaceAndAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstract.Abstract
{
   public interface ICustomerCheckServices
    {
        bool CheckOfRealPerson(Customer customer);
    }
}
