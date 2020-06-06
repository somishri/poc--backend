using eshop.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Domain.Repo.Interface
{
    public interface ICartRepo
    {
        List<Carts> AddToCart(Carts cart,int customerId);
        bool DeleteCartItem(int id);
        List<Carts> GetCartItemByCustomerId(int customerId);
    }
}
