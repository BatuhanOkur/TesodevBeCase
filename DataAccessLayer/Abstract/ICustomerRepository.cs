using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustormers();

        Customer GetCustomer(Guid id);

        Customer CreateCustomer(Customer customer);

        Customer UpdateCustomer(Customer customer);

        void DeleteCustomer(Guid id);
    }
}
