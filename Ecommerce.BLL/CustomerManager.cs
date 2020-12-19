using Ecommerce.BLL.Abstruction;
using Ecommerce.BLL.Abstruction.Base;
using Ecommerce.DAL;
using Ecommerce.DAL.Abstruction;
using Ecommerce.Models.EntityModels.CustomerEM;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.BLL
{
    public class CustomerManager:Manager<Customer>,ICustomerManager
    {
        ICustomerReopsitory _customerRepository;
        public CustomerManager(ICustomerReopsitory customerRepository):base(customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer GetById(int? id)
        {
            return _customerRepository.GetFirstOrDefault(c=>c.Id==id);
        }

      
    }
}
