using AutoMapper;
using Ecommerce.BLL.Abstruction;
using Ecommerce.Models.ResponseModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IMapper _mapper;
        IProductManager _productManager;
        public ProductsController(IProductManager productManager, IMapper mapper)
        {
            _productManager = productManager;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetProducts()
        {
            var result = _productManager.GetAll();
            if (result == null)
            {
                return NotFound();
            }
            var responseProductData = _mapper.Map<List<ProductResponseModel>>(result);
            return Ok(responseProductData);
        }
    }
}
