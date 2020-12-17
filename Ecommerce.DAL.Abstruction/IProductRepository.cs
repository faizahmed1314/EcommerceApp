using Ecommerce.DAL.Abstruction.Base;
using Ecommerce.Models.EntityModels.ProductEM;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.DAL.Abstruction
{
    public interface IProductRepository:IRepository<Product>
    {
        Product GetById(int? id);

    }
}
