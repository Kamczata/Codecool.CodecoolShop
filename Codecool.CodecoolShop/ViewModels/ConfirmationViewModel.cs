using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.ViewModels
{
    public class ConfirmationViewModel
    {

        public Customer Customer { get; set; }
        public Order Order { get; set; }

        public decimal TotalPrice { get; set; }
        public ConfirmationViewModel(Customer customer, Order order, decimal totalPrice)
        {
            Customer = customer;
            Order = order;
            TotalPrice = totalPrice;
        }
    }
}
