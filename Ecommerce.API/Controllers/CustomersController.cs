using AutoMapper;
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
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerManager _customerManager;
        IMapper _mapper;
        public CustomersController(ICustomerManager customerManager, IMapper mapper)
        {
            _customerManager = customerManager;
            _mapper = mapper;
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

        [HttpGet("{id}", Name ="GetById")]
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

        [HttpPost]
        public IActionResult PostCustomer([FromBody]CustomerCreateDTO customerDto)
        {
            if (ModelState.IsValid)
            {
                var customerEntity = _mapper.Map<Customer>(customerDto);
                bool isSaved = _customerManager.Add(customerEntity);
                if (isSaved)
                {
                    customerDto.Id = customerEntity.Id;
                    //return Ok(customerDto);
                    return CreatedAtRoute("GetById", new { id = customerDto.Id }, customerDto);
                }
                else
                {
                    return BadRequest("Customer could not be saved!");
                }
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        //api/customers/12
        [HttpPut("{id}")]
        public IActionResult PutCustomer(int? id, [FromBody] CustomerUpdateDTO CustomerDto)
        {
            try
            {
                var existingCustomer = _customerManager.GetById(id);
                if (existingCustomer == null)
                {
                    return NotFound();
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                //map update dto data to existing customer data
                var customer = _mapper.Map(CustomerDto, existingCustomer);
                var isUpdated = _customerManager.Update(customer);
                if (isUpdated)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest("Update Failed!");
                }
            }
            catch(Exception ex)
            {
                return BadRequest("Server error occured. Please contact with the vendor");
            }
        }
    }
}
