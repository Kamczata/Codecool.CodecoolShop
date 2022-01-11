using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Order
    {
        public Customer Customer { get; set; }
        //public List<Product> Products { get; set; }
        public Dictionary<Product, int> ProductsInCart { get; set; }
        public Dictionary<int, decimal> ProductsWithPrice { get; set; }

        public decimal FullPrice { get; set; }

        public Order()
        {
            //Products = new List<Product>();
            FullPrice = 0;
            ProductsInCart = new Dictionary<Product, int>();
            ProductsWithPrice = new Dictionary<int, decimal>();
        }

        public void EmailSender()
        {

        }
    }
}
