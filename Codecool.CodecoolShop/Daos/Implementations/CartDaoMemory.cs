using Codecool.CodecoolShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.Daos.Implementations
{
    public class CartDaoMemory : ICartDao
    {
        private Cart cart = new Cart();
        private static CartDaoMemory instance = null;

        private CartDaoMemory()
        {
        }

        public static CartDaoMemory GetInstance()
        {
            if (instance == null)
            {
                instance = new CartDaoMemory();
            }
                return instance;
        }
        
        public void Add(Product product)
        {
            if (cart.ProductsInCart.ContainsKey(product))
            {
                cart.ProductsInCart[product] += 1;
                cart.ProductsWithPrice[product.Id] += product.DefaultPrice;
            }
            else
            {
                cart.ProductsInCart[product] = 1;
                cart.ProductsWithPrice[product.Id] = product.DefaultPrice;
            }
            cart.FullPrice += product.DefaultPrice;
        }

        public void Remove(int productId, int quantity)
        {
            var product = cart.ProductsInCart.FirstOrDefault(x => x.Key.Id == productId);

            if (quantity == 1000 || product.Value == 1)
            {
                cart.ProductsInCart.Remove(product.Key);
                cart.FullPrice -= product.Key.DefaultPrice * product.Value;
                cart.ProductsWithPrice.Remove(product.Key.Id);
            }
            else
            {
                cart.ProductsInCart[product.Key] -= 1;
                cart.FullPrice -= product.Key.DefaultPrice;
                cart.ProductsWithPrice[product.Key.Id] -= product.Key.DefaultPrice;
            }
                
        }

        public Cart Get() => cart;

        public Dictionary<Product, int> GetItems() => cart.ProductsInCart;

        public int ProductsQuantity()
        {
            int quantity = 0;
            foreach (var item in cart.ProductsInCart)
            {
                quantity += item.Value;
            }
            return quantity;
        }
        public void AssignCustomer(Customer customer)
        {
            cart.Customer = customer;
        }


    }
}
