using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.ViewModels
{
    public class HomeViewModel
    {

        public List<Product> Products { get; set; }
        public IEnumerable<ProductCategory> Categories { get; set; }
        public IEnumerable<Supplier> Suppliers { get; set; }
        public int ItemsInCart { get; set; }
        public Filter Filter {get; set;}

        public HomeViewModel(List<Product> products, IEnumerable<ProductCategory> categories,
            IEnumerable<Supplier> suppliers, int itemsInCart, Filter filter)
        {
            Products = products;
            Categories = categories;
            Suppliers = suppliers;
            ItemsInCart = itemsInCart;
            Filter = filter;
        }



    }
}
