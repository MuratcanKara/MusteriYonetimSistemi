using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriYonetimSistemi.Abstract
{
    public interface IPersonCheckService
    {
        Boolean CheckIfRealCustomer(Customer customer);
    }
}
