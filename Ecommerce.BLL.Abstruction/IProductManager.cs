using Ecommerce.Models.EntityModels.ProductEM;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.BLL.Abstruction
{
    public interface IProductManager
    {
        bool Add(Product customer);

        bool Update(Product customer);

        bool Remove(Product customer);
        ICollection<Product> GetAll();
        Product GetById(int? id);
    }
}
