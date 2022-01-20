using Codecool.CodecoolShop.Services;
using Codecool.CodecoolShop.ViewModels;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly ILogger<CheckoutController> _logger;
        private CustomerService customerService;
        private readonly ShoppingCart shoppingCart;

        public CheckoutController(ILogger<CheckoutController> logger, CustomerService customerService, ShoppingCart shoppingCart)
        {
            _logger = logger;
            this.customerService = customerService;
            this.shoppingCart = shoppingCart;
        }

        public IActionResult Index()
        {
            //var model = new CheckoutViewModel();
            return View("Checkout");
        }

        [HttpPost]
        public IActionResult Index(IFormCollection collection)
        {
            try
            {
                //var cart = ProductService.GetCart();
                Customer customer = customerService.CreateCustomer(collection);
                customerService.AddNewCustomer(customer);
                //Order order = 
                //customerService.AddOrder()
                //ConfirmationViewModel model = new ConfirmationViewModel(customer, order);
                return View("Order");
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }
    }
}
