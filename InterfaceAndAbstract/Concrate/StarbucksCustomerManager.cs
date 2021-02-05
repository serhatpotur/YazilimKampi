using InterfaceAndAbstract.Abstract;
using InterfaceAndAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstract.Concrate
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckServices customerCheckServices;

        public StarbucksCustomerManager(ICustomerCheckServices checkServices)
        {
            customerCheckServices = checkServices;
        }

        public override void Save(Customer customer)
        {
            if (customerCheckServices.CheckOfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");

            }
        }

       
    }
}
