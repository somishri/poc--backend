using eshop.Models.Models;
using shop.Domain.Repo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Domain.Repo
{
    public class CustomerRepo:ICustomerRepo
    {
        public  void AddCustomer(Customers customer)
        {
            using (var context = new shopEntities())
            {

                var Role = customer.Role = "user";
                var FirstName = customer.FirstName;
                var LastName = customer.LastName;
                var EmailAddress = customer.EmailAddress;
                var PhoneNo = customer.PhoneNumber;
                var Password = customer.Password;
                try
                {
                    context.Customers.Add(customer);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                }
            }

        }
        //private shopEntities shop;
        public List<Customers> GetCustomers()
        {
            using (var context = new shopEntities())
            {
                return context.Customers.ToList();

            }
        }
        //public void AddCustomer(Customer customer)
        //{



        //}
    }
}
