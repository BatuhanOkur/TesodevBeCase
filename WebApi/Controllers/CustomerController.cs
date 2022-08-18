using BusinessLayer.Concrete;
using BusinessLayer.Abstract;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;

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
        public IActionResult Create([FromBody] Customer customer)
        {
            CustomerValidator customerValidator = new CustomerValidator();
            ValidationResult results = customerValidator.Validate(customer);

            if (results.IsValid)
            {
                _customerService.CreateCustomer(customer);
                return Ok(results);
            }
            else
            {
                return BadRequest(results.Errors);
            }
        }

        [HttpGet]
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
        public IActionResult Update([FromBody] Customer customer)
        {
            CustomerValidator customerValidator = new CustomerValidator();
            ValidationResult results = customerValidator.Validate(customer);

            if (results.IsValid)
            {
                _customerService.UpdateCustomer(customer);
                return Ok(results);
            }
            else
            {
                return BadRequest(results.Errors);
            }
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _customerService.DeleteCustomer(id);
        }
    }
}
