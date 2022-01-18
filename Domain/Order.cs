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
        public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();



        public void EmailSender()
        {

        }
    }
}
