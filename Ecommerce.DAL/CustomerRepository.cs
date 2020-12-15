using Ecommerce.Database.Database;
using Ecommerce.Models.EntityModels.CustomerEM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Ecommerce.DAL.Abstruction;

namespace Ecommerce.DAL
{
    public class CustomerRepository:ICustomerReopsitory
    {
        EcommerceDbContext _db;
        public CustomerRepository(DbContext dbContext)
        {
            _db = (EcommerceDbContext)dbContext;
        }

        public  ICollection<Customer> GetAll()
        {
          return _db.customers.Where(c => c.IsDeleted == false).ToList();
        }

        public bool Add(Customer customer)
        {
            _db.customers.Add(customer);
            return _db.SaveChanges() > 0;
        }

        public Customer GetById(int? id)
        {
            if (id == null)
            {
                return null;
            }
            var customer = _db.customers.Find(id);
            return customer;
        }

        public bool Update(Customer customer)
        {
            _db.Entry(customer).State = EntityState.Modified;
            return _db.SaveChanges() > 0;
        }

        public bool Remove(Customer customer)
        {
            customer.IsDeleted = true;
            return Update(customer);
        }
    }
}
