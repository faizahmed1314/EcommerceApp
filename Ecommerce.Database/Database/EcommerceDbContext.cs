using Ecommerce.Models;
using Ecommerce.Models.EntityModels.CustomerEM;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connectionString = "Server=(local); Database=EcommerceDB; Integrated Security = true;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
