using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Codecool.CodecoolShop.Daos;
using Codecool.CodecoolShop.Daos.Implementations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Codecool.CodecoolShop.Models;
using Codecool.CodecoolShop.Services;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;

namespace Codecool.CodecoolShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private ProductService productService;

        public ProductController(ILogger<ProductController> logger, ProductService productService)
        {
            _logger = logger;
            this.productService = productService;
        }

        /*public IActionResult Index()
        {
            ViewData["ProductsQuantity"] = ProductService.GetProductsQuantity();
            var products = ProductService.GetAllProducts();
            return View(products.ToList());
        }

        public IActionResult Category(int id)
        {
            ViewData["ProductsQuantity"] = ProductService.GetProductsQuantity();
            var products = ProductService.GetProductsForCategory(id);
            return View("Index", products.ToList());
        }

        public IActionResult Supplier(int id)
        {
            ViewData["ProductsQuantity"] = ProductService.GetProductsQuantity();
            var products = ProductService.GetProductsForSupplier(id);
            return View("Index", products.ToList());
        }

        public IActionResult Product(int id)
        {
            ViewData["ProductsQuantity"] = ProductService.GetProductsQuantity();
            var product = ProductService.GetProductById(id);
            return View(product);
        }

        public IActionResult Privacy()
        {
            ViewData["ProductsQuantity"] = ProductService.GetProductsQuantity();
            return View();
        }

        public IActionResult Cart()
        {
            ViewData["ProductsQuantity"] = ProductService.GetProductsQuantity();
            var cart = ProductService.GetCart();
            return View(cart);
        }

        public IActionResult AddToCart(int id, string view)
        {
            var product = ProductService.GetProductById(id);
            ProductService.AddProductToCart(product);
            ViewData["ProductsQuantity"] = ProductService.GetProductsQuantity();
            if (view =="Product")
            {
                return RedirectToAction(view, new { id = id });
            }
            return RedirectToAction(view);
        }

        public IActionResult RemoveFromCart(int id, int quantity)
        {
            ProductService.RemoveFromCart(id, quantity);
            return RedirectToAction("Cart");
        }

        public IActionResult Checkout()
        {
            ViewData["ProductsQuantity"] = ProductService.GetProductsQuantity();
            var cart = ProductService.GetCart();
            return View(cart);
        }


        [HttpPost]
        public IActionResult Checkout(IFormCollection collection)
        {
            try
            {
                var cart = ProductService.GetCart();
                Customer customer = ProductService.CreateCustomer(collection);
                ProductService.AddCustomerToCart(customer);
                //string cartJson = JsonSerializer.Serialize(cart.ProductsInCart);
                string customerJson= JsonSerializer.Serialize(customer);
                ViewData["order"] = customerJson;
                return View("Order");
            }
            catch
            {
                return RedirectToAction("Error");
            }
            
        }*/


        /*[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}
