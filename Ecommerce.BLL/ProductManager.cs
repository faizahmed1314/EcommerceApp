using Ecommerce.BLL.Abstruction;
using Ecommerce.BLL.Abstruction.Base;
using Ecommerce.DAL.Abstruction;
using Ecommerce.Models.EntityModels.ProductEM;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.BLL
{
    public class ProductManager : Manager<Product>, IProductManager
    {
        IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository):base(productRepository)
        {
            _productRepository = productRepository;
        }
        public Product GetById(int? id)
        {
            return _productRepository.GetById(id);
        }
    }
}
