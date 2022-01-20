using Codecool.CodecoolShop.Services;
using Codecool.CodecoolShop.ViewModels;
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
        private OrderService orderService;
        private readonly ShoppingCart shoppingCart;

        public CartController(ILogger<CartController> logger, OrderService orderService, ShoppingCart shoppingCart)
        {
            _logger = logger;
            this.orderService = orderService;
            this.shoppingCart = shoppingCart;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cart()
        {
            ViewData["ProductsQuantity"] = shoppingCart.GetShoppingCartTotalQuantity();
            var itemsInCart = shoppingCart.ShoppingCartItems;
            var shoppingCartTotal = shoppingCart.GetShoppingCartTotal();
            var model = new CartViewModel(itemsInCart, shoppingCartTotal);
            return View(model);
        }

       /* public IActionResult RemoveFromCart(int id, int quantity)
        {
            ProductService.RemoveFromCart(id, quantity);
            return RedirectToAction("Cart");
        }*/
    }
}
