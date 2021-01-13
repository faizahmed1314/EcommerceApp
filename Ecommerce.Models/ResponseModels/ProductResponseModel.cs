using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Models.ResponseModels
{
    public class ProductResponseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public double Price { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
