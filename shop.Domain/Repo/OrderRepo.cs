using eshop.Models.Models;
using shop.Domain.Repo.Interface;

namespace shop.Domain.Repo
{
    public class OrderRepo:IOrderRepo
    {
        public void AddOrder(OrderPlaces orderPlace)
        {
            using (var context = new shopEntities())
            {
                context.OrderPlaces.Add(orderPlace);
                context.SaveChanges();

            }
        }
       
    }
}
