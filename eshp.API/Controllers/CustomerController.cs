using eshop.Models.Models;
using shop.Domain.Repo;
using shop.Domain.Repo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace eshp.API.Controllers
{
    [Route("api/Customer")]

    public class CustomerController : ApiController
    {
        private readonly ICustomerRepo customerRepo = new CustomerRepo();

        [HttpGet]
        public IEnumerable<Customers> GetCus()
        {
            var cus = customerRepo.GetCustomers();
            return cus;
        }
        [HttpPost]
        public bool Post(Customers customer)
        {
            customerRepo.AddCustomer(customer);
            return true;
        }
              
    }
}
