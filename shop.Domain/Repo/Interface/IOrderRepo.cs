using eshop.Models.Models;

namespace shop.Domain.Repo.Interface
{
    public interface IOrderRepo
    {
        void AddOrder(OrderPlaces orderPlace);
    }
}
