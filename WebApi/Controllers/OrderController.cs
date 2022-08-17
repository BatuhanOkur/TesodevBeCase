﻿using BusinessLayer.Concrete;
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


        [HttpPut]
        public Order ChangeStatus([FromBody] Order order)
        {
            dynamic orderstatus = order.Status;
            order.Status = !orderstatus;
            return orderManager.UpdateOrder(order);
        }
    }
}
