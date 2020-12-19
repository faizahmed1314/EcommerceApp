using Ecommerce.Models.EntityModels.ProductEM;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Models.EntityModels.CategoryEM
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
