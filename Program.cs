using System;
using MusteriYonetimSistemi.Abstract;
using MusteriYonetimSistemi.Concrete;

namespace MusteriYonetimSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1985, 1, 6), FirstName = "Muratcan", LastName = "Kara", Id = 1, NationalId = "6541865" }) ;
            Console.ReadLine();
        }
    }



}
