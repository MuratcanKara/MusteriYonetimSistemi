using System;
using System.Collections.Generic;
using System.Text;
using MusteriYonetimSistemi.Abstract;

namespace MusteriYonetimSistemi.Concrete
{
    class PersonCheckManager : IPersonCheckService
    {
        public bool CheckIfRealCustomer(Customer customer)
        {
            return true;
        }
    }
}
