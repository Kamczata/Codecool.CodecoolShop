using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.ViewModels
{
    public class CheckoutViewModel
    {

        public int ItemsInCart { get; set; }
        public CheckoutViewModel(int itemsInCart)
        {
            ItemsInCart = itemsInCart;
        }
    }
}
