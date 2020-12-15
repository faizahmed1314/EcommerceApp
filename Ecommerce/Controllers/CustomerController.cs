using Ecommerce.BLL;
using Ecommerce.BLL.Abstruction;
using Ecommerce.Database.Database;
using Ecommerce.Models;
using Ecommerce.Models.Customer;
using Ecommerce.Models.EntityModels.CustomerEM;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class CustomerController : Controller
    {
        ICustomerManager _customerManager;
        public CustomerController(ICustomerManager customerManager)
        {
            _customerManager = customerManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            Customer customer = new Customer();
            customer.Customers = _customerManager.GetAll();
            return View(customer);
        }
        [HttpPost]
        public IActionResult Index(Customer customer)
        {
            if (ModelState.IsValid)
            {

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
            if(id!=null & id > 0)
            {
                Customer customer = _customerManager.GetById(id);
                if (customer != null)
                {
                    return View(customer);
                }
            }
            


            return View();
        }

        [HttpPost]
        public IActionResult Edit(Customer customer)
        {

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
