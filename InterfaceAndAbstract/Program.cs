using InterfaceAndAbstract.Abstract;
using InterfaceAndAbstract.Concrate;
using InterfaceAndAbstract.Entities;
using System;

namespace InterfaceAndAbstract
{
    class Program
    {       
        //SENARYO
        /*
         * Kahve dükkanları için müşteri yönetim sistemi yazmak istiyoruz
         * Starbucks ve Nero firması için çalışıyoruz
         * İki firmada müşterilerini veri tabanına kaydetmek istiyor
         * Starbucks müşterilerini kaydederken mernis doğrulaması istiyor
         * Nero ise böyle bir şey istemiyor
         * Starbucks müşteriler için her kahve alımında yıldız kazandırmak istiyor
         */

        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomer = new NeroCustomerManager();
            baseCustomer.Save(new Customer { DateOfBirth = new DateTime(1998, 5, 24), FirstName = "Serhat", LastName = "Potur", NationalityId = "12345678920" });
            Console.ReadLine();
        }
    }
}
