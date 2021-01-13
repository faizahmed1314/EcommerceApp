using AutoMapper;
using Ecommerce.Models.EntityModels.CustomerEM;
using Ecommerce.Models.EntityModels.ProductEM;
using Ecommerce.Models.RequestModels;
using Ecommerce.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.API.AutoMapperProfiles
{
    public class EcommerceApiAutoMapperProfile:Profile
    {
        public EcommerceApiAutoMapperProfile()
        {
            //Customer
            CreateMap<CustomerCreateDTO, Customer>();
            CreateMap<CustomerUpdateDTO, Customer>();
            CreateMap<Customer, CustomerUpdateDTO>();
            //Product
            CreateMap<ProductResponseModel, Product>();
            CreateMap<Product, ProductResponseModel>();
        }
    }
}
