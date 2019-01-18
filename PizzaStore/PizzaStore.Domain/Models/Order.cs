using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int LocationId { get; set; }
        public int UserId { get; set; }
        public int PizzaId { get; set; }
        public double Total { get; set; }
        public DateTime DateOrdered { get; private set; }
        //public List<Pizza> Pizzas { get; set; }


        //public Order()
        //{
        //    Date = DateTime.Now;
        //    Pizzas = new List<Pizza>();
        //    Total = 0;
        //}


    }
}
