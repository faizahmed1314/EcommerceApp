using Ecommerce.BLL.Abstruction;
using Ecommerce.Models.EntityModels.CustomerEM;
using Ecommerce.Models.RequestModels;
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
    public class CustomersController : ControllerBase
    {
        ICustomerManager _customerManager;
        public CustomersController(ICustomerManager customerManager)
        {
            _customerManager = customerManager;
        }

        [HttpGet]
        public IActionResult GetCustomer([FromQuery]CustomerRequestModel customer)
        {
            var result= _customerManager.GetByRequest(customer);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
            
        }

        //api/customers/12

        [HttpGet("{id}")]
        public IActionResult GetById(int? id)
        {
            if (id <= 0)
            {
                return BadRequest("Id must be greater than zero");
            }
           var customer= _customerManager.GetById(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }
    }
}
