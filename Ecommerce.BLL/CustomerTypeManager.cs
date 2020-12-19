using Ecommerce.BLL.Abstruction;
using Ecommerce.BLL.Abstruction.Base;
using Ecommerce.DAL.Abstruction;
using Ecommerce.Models.EntityModels.CustomerTypeEM;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.BLL
{
    public class CustomerTypeManager:Manager<CustomerType>, ICustomerTypeManager
    {
         ICustomerTypeRepository _customerTypeRepository;
        public CustomerTypeManager(ICustomerTypeRepository customerTypeRepository) :base(customerTypeRepository)
        {
            _customerTypeRepository = customerTypeRepository;
        }
    }
}
