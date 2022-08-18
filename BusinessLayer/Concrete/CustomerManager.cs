using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
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
        ICustomerRepository _customerRepository;

        public CustomerManager()
        {
            _customerRepository = new CustomerRepository();
        }

        public Customer CreateCustomer(Customer customer)
        {
            return _customerRepository.CreateCustomer(customer);
        }

        public void DeleteCustomer(Guid id)
        {
            _customerRepository.DeleteCustomer(id);
        }

        public Customer GetCustomer(Guid id)
        {
            return _customerRepository.GetCustomer(id);
        }

        public List<Customer> GetCustomers()
        {
            return _customerRepository.GetCustormers();
        }

        public Customer UpdateCustomer(Customer customer)
        {
            return _customerRepository.UpdateCustomer(customer);
        }
    }
}
