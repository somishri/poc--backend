using eshop.Models.Models;
using System;
using System.Collections.Generic;


namespace shop.Domain.Repo.Interface
{
    public interface ILoginRepo
    {
        IEnumerable<string> LoginUser(Customers customer);    }
}
