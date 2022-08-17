using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IOrderService
    {
        List<Order> GetOrders();

        Order GetOrder(Guid id);

        Order CreateOrder(Order order);

        Order UpdateOrder(Order order);

        void DeleteOrder(Guid id);
    }
}
