using Ecommerce.DAL.Abstruction;
using Ecommerce.DAL.Abstruction.Base;
using Ecommerce.Database.Database;
using Ecommerce.Models.EntityModels.ProductEM;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.DAL
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        EcommerceDbContext _db;
        public ProductRepository(DbContext db) : base(db)
        {
            _db = (EcommerceDbContext)db;
        }

        public Product GetById(int? id)
        {
            return GetFirstOrDefault(c => c.Id == id);
        }
    }
}
