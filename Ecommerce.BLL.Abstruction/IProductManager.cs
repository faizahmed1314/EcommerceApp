using Ecommerce.BLL.Abstruction.Base;
using Ecommerce.Models.EntityModels.ProductEM;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.BLL.Abstruction
{
    public interface IProductManager:IManager<Product>
    {
        
        Product GetById(int? id);
    }
}
