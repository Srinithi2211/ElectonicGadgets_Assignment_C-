using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.businesslayer.Services;
using TechShop.entity;

namespace TechShop.businesslayer.Repository
{
    public class CustomerRepository : ICustomerService
    {
        private List<Customer> customers = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            var existingCustomer = GetCustomer(customer.CustomerID);
            if (existingCustomer != null)
            {
                existingCustomer.FirstName = customer.FirstName;
                existingCustomer.LastName = customer.LastName;
                existingCustomer.Email = customer.Email;
                existingCustomer.Phone = customer.Phone;
                existingCustomer.Address = customer.Address;
            }
        }

        public Customer GetCustomer(int id)
        {
            return customers.Find(c => c.CustomerID == id);
        }
    }
}

