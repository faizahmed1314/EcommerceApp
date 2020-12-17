using Ecommerce.Database.Database;
using Ecommerce.Models.EntityModels.CustomerEM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Ecommerce.DAL.Abstruction;
using Ecommerce.DAL.Abstruction.Base;

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
            return _db.customers.Where(c => c.IsDeleted == false).ToList();
        }

        public Customer GetById(int? id)
        {
            if (id == null)
            {
                return null;
            }
            return GetFirstOrDefault(c => c.Id == id);
        }

    }
}
