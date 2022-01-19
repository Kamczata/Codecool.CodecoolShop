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
        public int ItemsInCart { get; set; }
    }
}
