using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
    public class Order
    {
        public object Ticket { get; private set; }
        public object Pizza { get; set; }
        public int Price { get; set; }
    }
}
