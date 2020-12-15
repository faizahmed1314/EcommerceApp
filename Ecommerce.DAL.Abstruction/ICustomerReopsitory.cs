using Ecommerce.Models.EntityModels.CustomerEM;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.DAL.Abstruction
{
    public interface ICustomerReopsitory
    {
        ICollection<Customer> GetAll();
        bool Add(Customer customer);


        Customer GetById(int? id);


        bool Update(Customer customer);


        bool Remove(Customer customer);
    }
}
