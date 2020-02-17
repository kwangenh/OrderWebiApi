using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface ICustomerRepository
    {
        public List<Customer> GetCustomers();
        public Customer GetCustomer(int customerId);
        public Customer CreateCustomer(Customer thisCustomer);
        public Customer DeleteCustomer(int customerId);
        public Customer EditCustomer(Customer thisCustomer);
    }
}
