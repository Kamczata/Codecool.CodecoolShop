using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.ViewModels
{
    public class HomeViewModel
    {
        public List<ProductViewModel> Products { get; set; }
        public List<ProductCategory> Categories { get; set; }
        public List<Supplier> Suppliers { get; set; }
        public int ItemsInCart { get; set; }

        public Filter Filter {get; set;}

    }
}
