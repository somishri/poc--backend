using eshop.Models.Models;
using shop.Domain.Repo;
using shop.Domain.Repo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eshp.API.Controllers
{
    [Route("api/Cus")]
    public class LoginController : ApiController
    {
        private readonly ILoginRepo loginRepo = new LoginRepo();

        [HttpPost]
        public IEnumerable<string> Login(Customers customer)
        {
            var loginUser = loginRepo.LoginUser(customer);
            return loginUser;
        }
    }
}
