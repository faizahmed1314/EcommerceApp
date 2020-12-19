using Ecommerce.DAL.Abstruction;
using Ecommerce.DAL.Abstruction.Base;
using Ecommerce.Database.Database;
using Ecommerce.Models.EntityModels.CustomerTypeEM;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.DAL
{
    public class CustomerTypeRepository : Repository<CustomerType>, ICustomerTypeRepository
    {
        EcommerceDbContext _db;
        public CustomerTypeRepository(DbContext db) : base(db)
        {
            _db = (EcommerceDbContext)db;
        }
    }
}
