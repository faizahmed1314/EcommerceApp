using Ecommerce.BLL;
using Ecommerce.BLL.Abstruction;
using Ecommerce.Database.Database;
using Ecommerce.Models;
using EcommerceApp.Models.Customer;
using Ecommerce.Models.EntityModels.CustomerEM;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Models.ResponseModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ecommerce.Controllers
{
    public class CustomerController : Controller
    {
        
        ICustomerManager _customerManager;
        ICustomerTypeManager _customerTypeManager;
        IMapper _mapper;
        public CustomerController(ICustomerManager customerManager, IMapper mapper, ICustomerTypeManager customerTypeManager)
        {
            _customerManager = customerManager;
            _customerTypeManager = customerTypeManager;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Index()
        {
            CustomerCreateViewModel customer = new CustomerCreateViewModel();
            //customer.CustomerList = _customerManager.GetAll().Select(c=>new CustomerResponseModel
            //{
            //    Id=c.Id,
            //    Name=c.Name,
            //    PhoneNo=c.PhoneNo,
            //    Address=c.Address
            //}).ToList();
            customer.CustomerList = _customerManager.GetAll()
                .Select(c => _mapper.Map<CustomerResponseModel>(c))
                .ToList();

            customer.CustomerTypeItems = _customerTypeManager.GetAll().Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.Id.ToString()
            }).ToList();
            return View(customer);

        }
        [HttpPost]
        public IActionResult Index(CustomerCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                //Customer customer = new Customer() { 
                //Name=model.Name,
                //PhoneNo=model.PhoneNo,
                //Address=model.Address,
                //IsDeleted=model.IsDeleted,
                //};

                Customer customer = _mapper.Map<Customer>(model);

                bool isAdded = _customerManager.Add(customer);
                if (isAdded)
                {
                    return RedirectToAction("List", "Customer", null);
                }
            }
            
           
           
            return View();
        }
        [HttpGet]
        public IActionResult List()
        {
            ICollection<Customer> customers = _customerManager.GetAll();

            
            return View(customers);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            CustomerEditViewModel model = new CustomerEditViewModel();
            model.CustomerTypeItems = _customerTypeManager.GetAll().Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.Id.ToString()
            }).ToList();
           

            if (id!=null & id > 0)
            {
                Customer existingCustomer = _customerManager.GetById(id);
                
               
                if (existingCustomer != null)
                {
                    _mapper.Map<Customer, CustomerEditViewModel>(existingCustomer, model);
                    
                }
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(CustomerEditViewModel model)
        {
            var customer=_mapper.Map<Customer>(model);

            bool isUpdated = _customerManager.Update(customer);
            if (isUpdated)
            {
                return RedirectToAction("List");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if(id!=null && id > 0)
            {
                var customer = _customerManager.GetById(id);
                var isDeleted = _customerManager.Remove(customer);
                if (isDeleted)
                {
                    return RedirectToAction("List");
                }
            }
           
            return RedirectToAction("List");
        }
    }
}
