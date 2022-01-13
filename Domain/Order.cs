using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        //public List<Product> Products { get; set; }
        public Dictionary<int, int> ProductsInCart { get; set; }
        public Dictionary<int, decimal> ProductsWithPrice { get; set; }

        public decimal FullPrice { get; set; }

        public Order()
        {
            FullPrice = 0;
            ProductsInCart = new Dictionary<int, int>();
            ProductsWithPrice = new Dictionary<int, decimal>();
        }

        public void EmailSender()
        {

        }
    }
}
