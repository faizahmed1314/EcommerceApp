using Ecommerce.Models;
using Ecommerce.Models.EntityModels.CategoryEM;
using Ecommerce.Models.EntityModels.CustomerEM;
using Ecommerce.Models.EntityModels.CustomerTypeEM;
using Ecommerce.Models.EntityModels.ProductEM;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Database.Database
{
    public class EcommerceDbContext : DbContext
    {
        public DbSet<Customer> customers { get; set; }
        //public DbSet<Product> products { get; set; }
        //public DbSet<Category> categories { get; set; }
        //public DbSet<CustomerType> customerTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connectionString = "Server=(local); Database=EcommerceDB; Integrated Security = true;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
