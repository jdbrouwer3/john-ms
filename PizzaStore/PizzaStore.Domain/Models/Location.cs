using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public Address Address { get; set; }
        public List<Order> Orders { get; set; }
        public List<Pizza> Pizzas { get; set; }
        public List<User> Users { get; set; }

        public Location()
        {
            Address = new Address();
            Orders = new List<Order>();
            Pizzas = new List<Pizza>();
            Users = new List<User>();
        }



        public double Sales()
        {
            double sum = 0;

            foreach (var order in Order)
            {
                sum += order.Total;
            }

            return sum;
        }
    }
}
