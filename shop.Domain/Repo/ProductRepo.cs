using eshop.Models.Models;
using shop.Domain.Repo.Interface;
using System.Collections.Generic;
using System.Linq;

namespace shop.Domain.Repo
{
    public class ProductRepo:IProductRepo
    {
          public void AddProduct(Products product)
          {
            using (var context = new shopEntities())
            {
                context.Products.Add(product);
                context.SaveChanges();

            }
          }
        public List<Products> GetProducts()
        {
            using (var context = new shopEntities())
            {
               return context.Products.ToList();
            }
        }
      
        public Products GetProduct(int id)
        {
            using (var context = new shopEntities())
            {
                return context.Products.Find(id);

            }
        }
       
    }
}
