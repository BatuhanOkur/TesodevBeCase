using BusinessLayer.Abstract;
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
        public Order Create([FromBody] Order order)
        {
            return _orderService.CreateOrder(order);
        }

        [HttpGet]
        [Route("GetAll")]
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
        public Order Update([FromBody] Order order)
        {
            return _orderService.UpdateOrder(order);
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
