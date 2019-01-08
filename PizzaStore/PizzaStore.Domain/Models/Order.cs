using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime Date { get; private set; }
        public List<Pizza> Pizzas { get; set; }
        public double Total { get; set; }

        public Order()
        {
            Date = DateTime.Now;
            Pizzas = new List<Pizza>();
            Total = 0;
        }


    }
}
