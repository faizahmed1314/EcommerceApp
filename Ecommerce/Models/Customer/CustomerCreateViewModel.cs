using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Models.EntityModels.CustomerEM;

namespace Ecommerce.Models.Customer
{
    public class CustomerCreateViewModel
    {
        [Required]
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public bool IsDeleted { get; set; }
        
        //public ICollection<Customer> Customers { get; set; }
    }
}
