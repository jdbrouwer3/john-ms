using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        //public Address Address { get; set; }
        //public List<Order> Orders { get; set; }
        //public List<Pizza> Pizzas { get; set; }
        //public List<User> Users { get; set; } 
        public string Name { get; set; }

        public Location()
        {
            //Address = new Address();
            //Orders = new List<Order>();
            //Pizzas = new List<Pizza>();
            //Users = new List<User>();
            Name = string.Empty;
        }



        //public double Sales()
        //{
        //    double sum = 0;

        //    foreach (var order in Orders)
        //    {
        //        sum += order.Total;
        //    }

        //    return sum;
        //}
    }
}
