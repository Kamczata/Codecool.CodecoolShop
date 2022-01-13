using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.Repository
{
    public interface IOrderRepository
    {
        public Order Get(int Id);
        public void Add(Order order);
        public IEnumerable<Order> GetCustomerOrders(int customerId);
        public void Increase(int productId, int orderId);
        public void Decrease(int productId, int orderId);
        public void Remove(int productId, int orderId);


    }
}
