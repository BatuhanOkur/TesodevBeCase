using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class OrderRepository : IOrderRepository
    {
        Context dbContext = new Context();
        public Order CreateOrder(Order order)
        {
            dbContext.Orders.Add(order);
            dbContext.SaveChanges();
            return order;
        }

        public void DeleteOrder(Guid id)
        {
            var deletedOrder = GetOrder(id);
            dbContext.Orders.Remove(deletedOrder);
            dbContext.SaveChanges();
        }

        public Order GetOrder(Guid id)
        {
            return dbContext.Orders.Find(id);
        }

        public List<Order> GetOrders()
        {
            return dbContext.Orders.ToList();
        }

        public Order UpdateOrder(Order order)
        {
            dbContext.Orders.Update(order);
            dbContext.SaveChanges();
            return order;
        }
    }
}
