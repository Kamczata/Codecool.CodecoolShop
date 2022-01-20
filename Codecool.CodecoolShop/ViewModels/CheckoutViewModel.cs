using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.ViewModels
{
    public class CheckoutViewModel
    {

        public List<ShoppingCartItem> ItemsInCart { get; set; }
        public decimal FullCartPrice { get; set; }
        public CheckoutViewModel(List<ShoppingCartItem> itemsInCart, decimal fullPrice)
        {
            ItemsInCart = itemsInCart;
            FullCartPrice = fullPrice;
        }
    }
}
