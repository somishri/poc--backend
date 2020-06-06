using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eshp.API.Controllers
{
    public class LoginUserController : ApiController
    {
        // GET: api/LoginUser
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/LoginUser/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/LoginUser
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/LoginUser/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/LoginUser/5
        public void Delete(int id)
        {
        }
    }
}
