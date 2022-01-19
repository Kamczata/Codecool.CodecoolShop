using System;
using System.Collections.Generic;
using System.Net;
using Codecool.CodecoolShop.Repository;
using Domain;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Codecool.CodecoolShop.Services
{
    public class ProductService
    {

        private readonly IProductRepository productRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly ISupplierRepository supplierRepository;
        private readonly IOrderRepository orderRepository;

        public ProductService(IProductRepository productRepository, ICategoryRepository categoryRepository,
            ISupplierRepository supplierRepository, IOrderRepository orderRepository)
        {
            this.productRepository = productRepository;
            this.categoryRepository = categoryRepository;
            this.supplierRepository = supplierRepository;
            this.orderRepository = orderRepository;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return this.productRepository.GetAll();
        }

        public IEnumerable<ProductCategory> GetAllCategories()
        {
            return this.categoryRepository.GetAll();
        }

        public ProductCategory GetCategoryById(int id)
        {
            return this.categoryRepository.Get(id);
        }

        public IEnumerable<Supplier> GetAllSuppliers()
        {
            return this.supplierRepository.GetAll();
        }

        public Supplier GetSupplierById(int id)
        {
            return this.supplierRepository.Get(id);
        }

        public int GetItemsInCartQuantity()
        {
            int quantity = 0;
            return quantity;
        }

        public IEnumerable<Product> GetProductsForCategory(int categoryId)
        {
            return this.productRepository.GetProductsByCategory(categoryId);
        }

        public IEnumerable<Product> GetProductsForSupplier(int supplierId)
        {
            return this.productRepository.GetProductsBySupplier(supplierId);
        }

        public Product GetProductById(int id)
        {
            return this.productRepository.Get(id);
        }


        /*public ProductCategory GetProductCategory(int categoryId)
        {
            return this.productCategoryDao.Get(categoryId);
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

        

        public int GetProductsQuantity() => this.cartDao.ProductsQuantity();

        public void RemoveFromCart(int id, int quantity) => this.cartDao.Remove(id, quantity);*/


    }
}
