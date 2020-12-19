using Ecommerce.Models.EntityModels.CategoryEM;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Models.EntityModels.ProductEM
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public double Price { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
