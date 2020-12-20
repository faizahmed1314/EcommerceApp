using Ecommerce.BLL.Abstruction.Base;
using Ecommerce.Models.EntityModels.CustomerEM;
using Ecommerce.Models.RequestModels;
using System;
using System.Collections.Generic;
using System.Text;


namespace Ecommerce.BLL.Abstruction
{
    public interface ICustomerManager:IManager<Customer>
    {
        Customer GetById(int? id);
        ICollection<Customer> GetByRequest(CustomerRequestModel customer);
    }
}
