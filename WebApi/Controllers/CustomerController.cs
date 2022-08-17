using BusinessLayer.Concrete;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        CustomerManager customerManager = new CustomerManager();

        [HttpPost]
        public Customer Create([FromBody] Customer customer)
        {
            return customerManager.CreateCustomer(customer);
        }

        [HttpGet]
        [Route("GetAll")]
        public List<Customer> GetAll()
        {
            return customerManager.GetCustomers();
        }

        [HttpGet("{id}")]
        public Customer Get(Guid id)
        {
            return customerManager.GetCustomer(id);
        }

        [HttpPut]
        public Customer Update([FromBody] Customer customer)
        {
            return customerManager.UpdateCustomer(customer);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            customerManager.DeleteCustomer(id);
        }
    }
}
