using Ecommerce.Database;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class CustomerController : Controller
    {
        CustomerDbContext _db = new CustomerDbContext();
        [HttpGet]
        public IActionResult Index()
        {
            Customer customer = new Customer();
            customer.Customers = _db.customers.Where(c => c.IsDeleted == false).ToList();
            return View(customer);
        }
        [HttpPost]
        public IActionResult Index(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _db.Add(customer);
                bool isAdded = _db.SaveChanges() > 0;
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
            List<Customer> customers = _db.customers.Where(c=>c.IsDeleted==false).ToList();

            
            return View(customers);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if(id!=null & id > 0)
            {
                Customer customer = _db.customers.Find(id);
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
            _db.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            bool isUpdated = _db.SaveChanges()>0;
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
                var customer = _db.customers.Find(id);
                customer.IsDeleted = true;
                _db.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                var isSaved = _db.SaveChanges() > 0;
                if (isSaved)
                {
                    return RedirectToAction("List");
                }
            }
           
            return RedirectToAction("List");
        }
    }
}
