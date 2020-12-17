using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Models.EntityModels.CustomerEM;
using Ecommerce.Models.ResponseModels;

namespace EcommerceApp.Models.Customer
{
    public class CustomerCreateViewModel
    {
        [Required]
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<CustomerResponseModel> CustomerList { get; set; }
    }
}
