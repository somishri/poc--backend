using eshop.Models.Models;
using System.Collections.Generic;

namespace shop.Domain.Repo.Interface
{
    public interface IProductRepo
    {
        List<Products> GetProducts();
        Products GetProduct(int id);
        void AddProduct(Products product);
    }
}
