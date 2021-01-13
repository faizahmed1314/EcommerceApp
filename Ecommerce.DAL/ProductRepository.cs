using Ecommerce.DAL.Abstruction;
using Ecommerce.DAL.Abstruction.Base;
using Ecommerce.Database.Database;
using Ecommerce.Models.EntityModels.ProductEM;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return _db.products.Include(c => c.Category).FirstOrDefault(c => c.Id == id);
        }
        public override ICollection<Product> GetAll()
        {
            return _db.products.Include(c => c.Category).ToList();
        }
    }
}
