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
        List<Carts> AddToCart(Carts cart,int customerIdNo);
        bool DeleteCartItem(int id);
        bool ClearCart(int cusId);
        List<Carts> GetCartItemByCustomerId(int customerId);
    }
}
