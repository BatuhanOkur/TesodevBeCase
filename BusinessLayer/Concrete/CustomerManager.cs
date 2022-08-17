using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        CustomerRepository customerRepository = new CustomerRepository();
        public Customer CreateCustomer(Customer customer)
        {
            return customerRepository.CreateCustomer(customer);
        }

        public void DeleteCustomer(Guid id)
        {
            customerRepository.DeleteCustomer(id);
        }

        public Customer GetCustomer(Guid id)
        {
            return customerRepository.GetCustomer(id);
        }

        public List<Customer> GetCustomers()
        {
            return customerRepository.GetCustormers();
        }

        public Customer UpdateCustomer(Customer customer)
        {
            return customerRepository.UpdateCustomer(customer);
        }
    }
}
