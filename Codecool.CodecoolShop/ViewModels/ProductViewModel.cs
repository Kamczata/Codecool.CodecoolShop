using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.ViewModels
{
    public class ProductViewModel
    {
        public Product Item { get; set; }
        public Supplier Supplier { get; set; }
        public int ItemsInCart { get; set; }
    }
}
