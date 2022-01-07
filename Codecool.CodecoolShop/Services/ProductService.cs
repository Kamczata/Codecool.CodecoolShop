using System;
using System.Collections.Generic;
using System.Net;
using Codecool.CodecoolShop.Daos;
using Codecool.CodecoolShop.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Codecool.CodecoolShop.Services
{
    public class ProductService
    {
        private readonly IProductDao productDao;
        private readonly IProductCategoryDao productCategoryDao;
        private readonly ICartDao cartDao;
        private readonly ICustomerDao customerDao;
        private readonly ISupplierDao supplierDao;

        public ProductService(IProductDao productDao, IProductCategoryDao productCategoryDao, ICartDao cartDao, ICustomerDao customerDao, ISupplierDao supplierDao)
        {
            this.productDao = productDao;
            this.productCategoryDao = productCategoryDao;
            this.cartDao = cartDao;
            this.customerDao = customerDao;
            this.supplierDao = supplierDao;
        }

        public ProductCategory GetProductCategory(int categoryId)
        {
            return this.productCategoryDao.Get(categoryId);
        }

        public IEnumerable<Product> GetProductsForCategory(int categoryId)
        {
            ProductCategory category = this.productCategoryDao.Get(categoryId);
            return this.productDao.GetBy(category);
        }

        public IEnumerable<Product> GetProductsForSupplier(int supplierId)
        {
            Supplier supplier = this.supplierDao.Get(supplierId);
            return this.productDao.GetBy(supplier);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return this.productDao.GetAll();
        }

        public Product GetProductById(int id)
        {
            return this.productDao.Get(id);
        }

        public Dictionary<Product, int> GetProductsFromCart()
        {
            return this.cartDao.GetItems();
        }

        public Cart GetCart() => this.cartDao.Get();

        public void AddCustomerToCart(Customer customer)
        {
            this.cartDao.AssignCustomer(customer);
        }

        public Customer CreateCustomer(IFormCollection collection)
        {
            Customer customer = this.customerDao.Get();
            customer.FirstName = collection["firstName"];
            customer.LastName = collection["lastName"];
            customer.Email = collection["email"];
            customer.Address = collection["address"];
            customer.Country = collection["country"];
            customer.City = collection["city"];
            customer.Zip = collection["zip"];
            customer.CardHolder = collection["cardHolder"];
            customer.CardNumber = collection["cardNumber"];
            customer.CardExpiry = collection["expiry"];
            customer.SecurityCode = Convert.ToInt32(collection["securityCode"]);
            return customer;
        }

        public void AddProductToCart(Product product)
        {
            this.cartDao.Add(product);
        }

        public int GetProductsQuantity() => this.cartDao.ProductsQuantity();

        public void RemoveFromCart(int id, int quantity) => this.cartDao.Remove(id, quantity);


    }
}
