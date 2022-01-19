using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.ViewModels
{
    public class ProductViewModel
    {

        public Product Product { get; set; }
        //public Supplier Supplier { get; set; }
        public int ItemsInCart { get; set; }

        public ProductViewModel(Product product, int itemsInCart)
        {
            Product = product;
            //Supplier = supplier;
            ItemsInCart = itemsInCart;
        }
    }
}
