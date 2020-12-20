using Ecommerce.DAL.Abstruction.Base;
using Ecommerce.Models.EntityModels.CustomerEM;
using Ecommerce.Models.RequestModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.DAL.Abstruction
{
    public interface ICustomerReopsitory:IRepository<Customer>
    {
        Customer GetById(int? id);
        ICollection<Customer> GetByRequest(CustomerRequestModel customer);
    }
}
