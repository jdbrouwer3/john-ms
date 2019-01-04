using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }

        public object Toppings { get; private set; }
        public object Crust { get; internal set; }
        public object Size { get; internal set; }
        public int Price { get; set; }
    }
}
