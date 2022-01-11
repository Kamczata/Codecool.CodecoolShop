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

    }
}
