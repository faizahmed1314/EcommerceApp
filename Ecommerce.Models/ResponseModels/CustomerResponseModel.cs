﻿using Ecommerce.Models.EntityModels.CustomerTypeEM;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ecommerce.Models.ResponseModels
{
   public class CustomerResponseModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        
        public CustomerType CustomerType { get; set; }

    }
}
