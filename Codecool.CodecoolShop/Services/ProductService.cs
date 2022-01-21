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

        public List<Product> GetAllProducts()
        {
            return this.productRepository.GetAll2();
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

        public List<Product> GetProductsForCategory(int categoryId)
        {
            return this.productRepository.GetProductsByCategory(categoryId);
        }

        public List<Product> GetProductsForSupplier(int supplierId)
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
        }*/

    }
}
