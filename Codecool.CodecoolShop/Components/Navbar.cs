using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Codecool.CodecoolShop.Repository;
using Codecool.CodecoolShop.Models;

namespace Codecool.CodecoolShop.Components
{
    public class Navbar : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ShoppingCart _shoppingCart;

        public Navbar(ICategoryRepository categoryRepository, ShoppingCart shoppingCart)
        {
            _categoryRepository = categoryRepository;
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.GetAll().OrderBy(s => s.Name);
            var itemsInCart = _shoppingCart.GetShoppingCartTotalQuantity();
            var model = new NavbarModel(categories, itemsInCart);

            return View(model);
        }
    }
}
