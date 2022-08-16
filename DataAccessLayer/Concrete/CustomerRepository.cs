using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class CustomerRepository : ICustomerRepository
    {
        Context dbContext = new Context();
        public Customer CreateCustomer(Customer customer)
        {
            dbContext.Customers.Add(customer);
            dbContext.SaveChanges();
            return customer;
        }

        public void DeleteCustomer(Guid id)
        {
            var deletedCustomer = GetCustomer(id);
            dbContext.Customers.Remove(deletedCustomer);
            dbContext.SaveChanges();
        }

        public Customer GetCustomer(Guid id)
        {
            return dbContext.Customers.Find(id);
        }

        public List<Customer> GetCustormers()
        {
            return dbContext.Customers.ToList();
        }

        public Customer UpdateCustomer(Customer customer)
        {
            dbContext.Customers.Update(customer);
            dbContext.SaveChanges();
            return customer;
        }
    }
}
