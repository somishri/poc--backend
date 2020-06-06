using eshop.Models.Models;
using shop.Domain.Repo.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Domain.Repo
{
    public class CartRepo:ICartRepo
    {
        public List<Carts> AddToCart(Carts cart, int customerId)
        {
            List<Carts> existingCart = new List<Carts>();
            using (var context = new shopEntities())
            {
                var product = context.Products.Where(x => x.ProductId == cart.ProductId).FirstOrDefault();
                var check = 0;
                if (product.Quantity > cart.Quantity)
                {
                    existingCart = GetCartItemByCustomerId(customerId);


                    foreach(Carts itemss in existingCart)
                    {
                        if(itemss.ProductId == cart.ProductId)
                        {
                            check = cart.ProductId;
                        }
                    }

                    if (existingCart.Count == 0 || check == 0)
                    {
                        cart.Amount = cart.Price * cart.Quantity;
                        context.Carts.Add(cart);
                        context.SaveChanges();
                    }
                    else
                    {
                        
                        foreach (Carts item in existingCart )
                        {
                            if(item.ProductId == check)
                            {
                                item.Quantity = item.Quantity + cart.Quantity;
                                item.Amount = item.Quantity * cart.Price;
                                context.Entry(item).State = EntityState.Modified;

                                context.SaveChanges();
                            }
                               
                           
                        }

                    }
                }

            }
            return existingCart;

        }

        public List<Carts> GetCartItemByCustomerId(int customerId)
        {
            using (var context = new shopEntities())
            {
                var cartItem = from customerItem in context.Carts where customerItem.CusId == customerId select customerItem;
                return cartItem.ToList();
            }

        }

      
       
        public bool DeleteCartItem(int cartid)
        {
            using (var context = new shopEntities())
            {
                var deleteItem = context.Carts.Where(k => k.CartId == cartid).FirstOrDefault();

                if (deleteItem == null)
                {
                    return false;
                }

                context.Carts.Remove(deleteItem);
                context.SaveChanges();

                return true;
            }
         
        }

       
    }
}
