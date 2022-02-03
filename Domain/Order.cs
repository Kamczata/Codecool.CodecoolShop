using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Order
    {
        
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public List<ShoppingCartItem> Items { get; set; }

        public Order()
        {
        }
        public Order(Customer customer, List<ShoppingCartItem> items)
        {
            Customer = customer;
            Items = items;
        }
        public void EmailSender()
        {

        }
    }
}
