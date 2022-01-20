using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.ViewModels
{
    public class CartViewModel
    {

        public List<ShoppingCartItem> Items { get; set; }
        public decimal ShoppingCartTotal { get; set; }

        public CartViewModel(List<ShoppingCartItem> items, decimal shoppingCartTotal)
        {
            Items = items;
            ShoppingCartTotal = shoppingCartTotal;
        }
    }
}
