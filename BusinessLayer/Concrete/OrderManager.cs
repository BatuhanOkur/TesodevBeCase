using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
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
        IOrderRepository _orderRepository;

        public OrderManager()
        {
            _orderRepository = new OrderRepository();
        }
        public Order CreateOrder(Order order)
        {
            return _orderRepository.CreateOrder(order);
        }

        public void DeleteOrder(Guid id)
        {
            _orderRepository.DeleteOrder(id);
        }

        public Order GetOrder(Guid id)
        {
            return _orderRepository.GetOrder(id);
        }

        public List<Order> GetOrders()
        {
            return _orderRepository.GetOrders();
        }

        public Order UpdateOrder(Order order)
        {
            return _orderRepository.UpdateOrder(order);
        }
    }
}
