using BusinessLayer.Concrete;
using BusinessLayer.Abstract;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("webapi/[controller]s")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomerController()
        {
            _customerService = new CustomerManager();
        }

        [HttpPost]
        public Customer Create([FromBody] Customer customer)
        {
            return _customerService.CreateCustomer(customer);
        }

        [HttpGet]
        [Route("GetAll")]
        public List<Customer> GetAll()
        {
            return _customerService.GetCustomers();
        }

        [HttpGet("{id}")]
        public Customer Get(Guid id)
        {
            return _customerService.GetCustomer(id);
        }

        [HttpPut]
        public Customer Update([FromBody] Customer customer)
        {
            return _customerService.UpdateCustomer(customer);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _customerService.DeleteCustomer(id);
        }
    }
}
