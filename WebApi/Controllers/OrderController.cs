using BusinessLayer.Concrete;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("webapi/[controller]s")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        OrderManager orderManager = new OrderManager();

        [HttpPost]
        public Order Create([FromBody] Order order)
        {
            return orderManager.CreateOrder(order);
        }

        [HttpGet]
        [Route("GetAll")]
        public List<Order> GetAll()
        {
            return orderManager.GetOrders();
        }

        [HttpGet("{id}")]
        public Order Get(Guid id)
        {
            return orderManager.GetOrder(id);
        }

        [HttpPut]
        public Order Update([FromBody] Order order)
        {
            return orderManager.UpdateOrder(order);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            orderManager.DeleteOrder(id);
        }
    }
}
