using AutoMapper;
using Ecommerce.Models.EntityModels.CustomerEM;
using Ecommerce.Models.RequestModels;
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
            CreateMap<CustomerCreateDTO, Customer>();
            CreateMap<CustomerUpdateDTO, Customer>();
            CreateMap<Customer, CustomerUpdateDTO>();
        }
    }
}
