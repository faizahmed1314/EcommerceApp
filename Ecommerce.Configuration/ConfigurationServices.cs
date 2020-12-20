using Ecommerce.BLL;
using Ecommerce.BLL.Abstruction;
using Ecommerce.DAL;
using Ecommerce.DAL.Abstruction;
using Ecommerce.Database.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Configuration
{
    public static class ConfigurationServices
    {
        public static void configure(IServiceCollection services)
        {
            services.AddTransient<ICustomerManager, CustomerManager>();
            services.AddTransient<ICustomerReopsitory, CustomerRepository>();
            services.AddTransient<ICustomerTypeManager, CustomerTypeManager>();
            services.AddTransient<ICustomerTypeRepository, CustomerTypeRepository>();
            services.AddTransient<DbContext, EcommerceDbContext>();
        }
    }
}
