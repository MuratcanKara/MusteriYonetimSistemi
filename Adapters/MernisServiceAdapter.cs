using System;
using System.Collections.Generic;
using System.Text;
using MusteriYonetimSistemi.Abstract;

namespace MusteriYonetimSistemi.Adapters
{
    public class MernisServiceAdapter : IPersonCheckService
    {
        public bool CheckIfRealCustomer(Customer customer)
        {
            KPSPUBlicSoapClient client = new KPSPUBlicSoapClient();
            return client.TCKimlikDogrula(customer.NationalId,customer.FirstName.ToUpper(), customer.LastName.ToUpper(),
                customer.DateOfBirth);
        }
    }
}
