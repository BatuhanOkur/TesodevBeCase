using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        OrderRepository orderRepository = new OrderRepository();
        public Order CreateOrder(Order order)
        {
            return orderRepository.CreateOrder(order);
        }

        public void DeleteOrder(Guid id)
        {
            orderRepository.DeleteOrder(id);
        }

        public Order GetOrder(Guid id)
        {
            return orderRepository.GetOrder(id);
        }

        public List<Order> GetOrders()
        {
            return orderRepository.GetOrders();
        }

        public Order UpdateOrder(Order order)
        {
            return orderRepository.UpdateOrder(order);
        }
    }
}
