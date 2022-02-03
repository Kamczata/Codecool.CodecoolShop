using Codecool.CodecoolShop.Repository;
using Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.Services
{
    public class CustomerService
    {
        private readonly ICustomerRepository customerRepository;
        private readonly IOrderRepository orderRepository;
        public CustomerService(ICustomerRepository customerRepository, IOrderRepository orderRepository)
        {
            this.customerRepository = customerRepository;
            this.orderRepository = orderRepository;
        }

        public Customer CreateCustomer(IFormCollection collection)
        {
            Customer customer = new Customer();
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

        public void AddNewCustomer(Customer customer)
        {
            customerRepository.Add(customer);
        }

        public void AddNewOrder(Order order)
        {
            orderRepository.Add(order);
        }
    }
}
