using eshop.Models.Models;
using shop.Domain.Repo;
using shop.Domain.Repo.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace eshp.API.Controllers
{
    [Route("api/Cart/{customerId}")]
    public class CartController : ApiController
    {
        private readonly ICartRepo cartRepo = new CartRepo();

        [HttpGet]
        public List<Carts> GetCartItems(int customerId )
        {
            var cartItem = cartRepo.GetCartItemByCustomerId(customerId);
            return cartItem.ToList();
        }
        
        [HttpPost]
        [Route("api/Cart/")]

        public List<Carts> Post([FromBody] Carts cart)
        {
            List<Carts> result = cartRepo.AddToCart(cart,cart.CusId).ToList();
            return result;
                
        }
        [HttpDelete]
        [Route("api/Cart/{id}")]
        public bool Delete(int id)
        {
            return cartRepo.DeleteCartItem(id);
        }

    }
}
