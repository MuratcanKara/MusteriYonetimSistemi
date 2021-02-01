using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriYonetimSistemi.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Consumer Added : " + customer.FirstName + customer.LastName);
        }

        public virtual void Save(Customer customer) // virtual bu fonksiyonun ezilebilecegini gösterir.
        {
            Console.WriteLine("Saved to db : " + customer.FirstName);
        }
    }
}
