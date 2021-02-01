using System;
using System.Collections.Generic;
using System.Text;
using MusteriYonetimSistemi.Abstract;

namespace MusteriYonetimSistemi.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private IPersonCheckService _checkService;

        public StarbucksCustomerManager(IPersonCheckService checkService)
        {
            _checkService = checkService;
        }
        
        
        public void Add()
        {
            throw new NotImplementedException();
        }


        public override void Save(Customer customer)
        {

            if (_checkService.CheckIfRealCustomer(customer))
            {
                base.Save(customer); // db'ye kaydeder
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }

        
    }
}
