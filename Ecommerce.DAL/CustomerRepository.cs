using Ecommerce.Database.Database;
using Ecommerce.Models.EntityModels.CustomerEM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Ecommerce.DAL.Abstruction;
using Ecommerce.DAL.Abstruction.Base;
using Ecommerce.Models.RequestModels;

namespace Ecommerce.DAL
{
    public class CustomerRepository : Repository<Customer>, ICustomerReopsitory
    {
        EcommerceDbContext _db;
        public CustomerRepository(DbContext dbContext) : base(dbContext)
        {
            _db = (EcommerceDbContext)dbContext;
        }

        public override ICollection<Customer> GetAll()
        {
            return _db.customers.Include(c=>c.CustomerType).Where(c => c.IsDeleted == false).ToList();
        }

        public Customer GetById(int? id)
        {
            if (id == null)
            {
                return null;
            }
            return GetFirstOrDefault(c => c.Id == id);
        }

        public ICollection<Customer> GetByRequest(CustomerRequestModel customer)
        {
            var result=_db.customers.AsQueryable();
            if (customer == null)
            {
                return result.ToList();
            }
            if (customer.Id > 0)
            {
                result = result.Where(c => c.Id == customer.Id);
            }
            if (!string.IsNullOrEmpty(customer.Name))
            {
                result = result.Where(c => c.Name.ToLower().Contains(customer.Name.ToLower()));
            }
            if (!string.IsNullOrEmpty(customer.Address))
            {
                result = result.Where(c => c.Address.ToLower().Contains(customer.Address.ToLower()));
            }
            if (!string.IsNullOrEmpty(customer.PhoneNo))
            {
                result = result.Where(c => c.PhoneNo.ToLower().Equals(customer.PhoneNo.ToLower()));
            }
            if (customer.IsDeleted != null)
            {
                result = result.Where(c => c.IsDeleted == customer.IsDeleted);
            }
            return result.ToList();
        }
    }
}
