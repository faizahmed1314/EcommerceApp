using Ecommerce.Models.EntityModels.CustomerEM;
using System;
using System.Collections.Generic;
using System.Text;


namespace Ecommerce.BLL.Abstruction
{
    public interface ICustomerManager
    {
         ICollection<Customer> GetAll();
         bool Add(Customer customer);


        Customer GetById(int? id);


        bool Update(Customer customer);


         bool Remove(Customer customer);
      
    }
}
