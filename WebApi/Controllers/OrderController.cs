using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using BusinessLayer.ValidationRules;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace WebApi.Controllers
{
    [Route("webapi/[controller]s")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        IOrderService _orderService;

        public OrderController()
        {
            _orderService = new OrderManager();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Order order)
        {
            OrderValidator orderValidator = new OrderValidator();
            ValidationResult results = orderValidator.Validate(order);

            if(results.IsValid)
            {
                _orderService.CreateOrder(order);
                return Ok(results);
            }
            else
            {
                return BadRequest(results.Errors);
            }
            
        }

        [HttpGet]
        public List<Order> GetAll()
        {
            return _orderService.GetOrders();
        }

        [HttpGet("{id}")]
        public Order Get(Guid id)
        {
            return _orderService.GetOrder(id);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Order order)
        {
            OrderValidator orderValidator = new OrderValidator();
            ValidationResult results = orderValidator.Validate(order);

            if (results.IsValid)
            {
                _orderService.UpdateOrder(order);
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
            _orderService.DeleteOrder(id);
        }


        [HttpPut]
        public Order ChangeStatus([FromBody] Order order)
        {
            dynamic orderstatus = order.Status;
            order.Status = !orderstatus;
            return _orderService.UpdateOrder(order);
        }
    }
}
