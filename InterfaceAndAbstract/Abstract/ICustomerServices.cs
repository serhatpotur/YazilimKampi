using InterfaceAndAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstract.Abstract
{
    public interface ICustomerServices
    {
        void Save(Customer customer);
    }
}
