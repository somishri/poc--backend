using eshop.Models.Models;
using shop.Domain.Repo;
using shop.Domain.Repo.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace eshp.API.Controllers
{
    [Route("api/Product")]
    public class ProductController : ApiController
    {
        private readonly IProductRepo productRepo = new ProductRepo();
        [HttpGet]
        public List<Products> Get()
        {
            var products = productRepo.GetProducts();
            return products;
        }

        [HttpGet]
        public Products Get(int id)
        {
            return productRepo.GetProduct(id);
        }
        [HttpPost]
        public bool Post(Products product)
        {
            productRepo.AddProduct(product);
            return true;
        }
       
    }
}
