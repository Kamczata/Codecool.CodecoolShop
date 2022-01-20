using Codecool.CodecoolShop.Services;
using Codecool.CodecoolShop.ViewModels;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.Controllers
{
    public class CartController : Controller
    {

        private readonly ILogger<CartController> _logger;
        private readonly ShoppingCart shoppingCart;
        private readonly CartService cartService;

        public CartController(ILogger<CartController> logger, ShoppingCart shoppingCart, CartService cartService)
        {
            _logger = logger;
            this.shoppingCart = shoppingCart;
            this.cartService = cartService;
        }

        public IActionResult Index()
        {
            ViewData["ProductsQuantity"] = shoppingCart.GetShoppingCartTotalQuantity();
            var itemsInCart = shoppingCart.GetShoppingCartItems();
            var shoppingCartTotal = shoppingCart.GetShoppingCartTotal();
            var model = new CartViewModel(itemsInCart, shoppingCartTotal);
            return View("Cart", model);
        }

        public IActionResult AddToCart(int id)
        {
            Product product = cartService.GetProductById(id);
            shoppingCart.AddToCart(product);
            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromCart(int id, string quantity)
        {
            shoppingCart.RemoveFromCart(id, quantity);
            return RedirectToAction("Index");
        }
    }
}
