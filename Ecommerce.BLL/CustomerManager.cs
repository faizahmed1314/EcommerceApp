using Ecommerce.BLL.Abstruction;
using Ecommerce.DAL;
using Ecommerce.DAL.Abstruction;
using Ecommerce.Models.EntityModels.CustomerEM;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.BLL
{
    public    class CustomerManager:ICustomerManager
    {
        ICustomerReopsitory _customerRepository;
        public CustomerManager(ICustomerReopsitory customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public  ICollection<Customer> GetAll()
        {
           return _customerRepository.GetAll();
        }

        public bool Add(Customer customer)
        {
            return _customerRepository.Add(customer);
        }

        public Customer GetById(int? id)
        {
            return _customerRepository.GetById(id);
        }

        public bool Update(Customer customer)
        {
            return _customerRepository.Update(customer);
        }

        public bool Remove(Customer customer)
        {
            return _customerRepository.Remove(customer);
        }
    }
}
