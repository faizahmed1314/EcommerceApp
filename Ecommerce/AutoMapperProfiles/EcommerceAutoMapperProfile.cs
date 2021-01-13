using AutoMapper;
using Ecommerce.Models.EntityModels.CustomerEM;
using Ecommerce.Models.ResponseModels;
using EcommerceApp.Models.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApp.AutoMapperProfiles
{
    public class EcommerceAutoMapperProfile:Profile
    {
        public EcommerceAutoMapperProfile()
        {
            CreateMap<CustomerCreateViewModel, Customer>();
            CreateMap<Customer, CustomerCreateViewModel>();
            CreateMap<Customer, CustomerResponseModel>();
            CreateMap<Customer, CustomerEditViewModel>();
            CreateMap<CustomerEditViewModel, Customer>();
        }
    }
}
