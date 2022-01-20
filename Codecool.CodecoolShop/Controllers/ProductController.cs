using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Codecool.CodecoolShop.Services;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;
using Codecool.CodecoolShop.ViewModels;
using Domain;

namespace Codecool.CodecoolShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private ProductService productService;
        private readonly ShoppingCart shoppingCart;

        public ProductController(ILogger<ProductController> logger, ProductService productService, ShoppingCart shoppingCart)
        {
            _logger = logger;
            this.productService = productService;
            this.shoppingCart = shoppingCart;
        }

        public IActionResult Index()
        {
            Filter filter = Filter.All;
            var products = productService.GetAllProducts();
            var categories = productService.GetAllCategories();
            var suppliers = productService.GetAllSuppliers();
            int itemsInCart = productService.GetItemsInCartQuantity(); 
            ViewData["ProductsQuantity"] = shoppingCart.GetShoppingCartTotalQuantity();
            var model = new HomeViewModel(products, categories,suppliers,itemsInCart,filter);
            return View(model);
        }

        public IActionResult Category(int id)
        {
            Filter filter = Filter.Category;
            var products = productService.GetProductsForCategory(id);
            var categories = productService.GetAllCategories();
            var suppliers = productService.GetAllSuppliers();
            int itemsInCart = shoppingCart.GetShoppingCartTotalQuantity();
            ViewData["ProductsQuantity"] = shoppingCart.GetShoppingCartTotalQuantity();
            var model = new HomeViewModel(products, categories, suppliers, itemsInCart, filter);
            return View("Index", model);
        }

        public IActionResult Supplier(int id)
        {
            Filter filter = Filter.Supplier;
            var products = productService.GetProductsForSupplier(id);
            var categories = productService.GetAllCategories();
            var suppliers = productService.GetAllSuppliers();
            int itemsInCart = shoppingCart.GetShoppingCartTotalQuantity();
            ViewData["ProductsQuantity"] = shoppingCart.GetShoppingCartTotalQuantity();
            var model = new HomeViewModel(products, categories, suppliers, itemsInCart, filter);
            return View("Index", model);
        }

        public IActionResult Product(int id)
        {
            Product product = productService.GetProductById(id);
            int itemsInCart = shoppingCart.GetShoppingCartTotalQuantity();
            var model = new ProductViewModel(product, itemsInCart);
            return View(model);
        }

        public IActionResult AddToCart(int id, string view)
        {
            Product product = productService.GetProductById(id);
            shoppingCart.AddToCart(product);
            return RedirectToAction(view, new { id = id });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        /*[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}
