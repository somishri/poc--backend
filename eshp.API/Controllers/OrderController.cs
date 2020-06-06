using eshop.Models.Models;
using shop.Domain.Repo;
using shop.Domain.Repo.Interface;
using System.Web.Http;

namespace eshp.API.Controllers
{
    [Route("api/order")]
    public class OrderController : ApiController
    {

        private readonly IOrderRepo orderRepo =  new OrderRepo();
       
        [HttpPost]
        public bool PostOrder(OrderPlaces orderPlace)
        {

            orderRepo.AddOrder(orderPlace);
            return true;
        }
    }
}
