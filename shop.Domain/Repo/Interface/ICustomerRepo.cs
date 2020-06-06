using eshop.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Domain.Repo.Interface
{
    public interface ICustomerRepo
    {
        void AddCustomer(Customers customer);
        List<Customers> GetCustomers();

    }
}
