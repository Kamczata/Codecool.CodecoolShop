using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.Models
{
    public class NavbarModel
    {
        public IEnumerable<ProductCategory> Categories { get; set; }
        public int ItemsInCart { get; set; }
        public NavbarModel(IEnumerable<ProductCategory> categories, int itemsInCart)
        {
            Categories = categories;
            ItemsInCart = itemsInCart;
        }
    }
}
