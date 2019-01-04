using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
    public class Location
    {
        private object expected;

        public Location(object expected)
        {
            this.expected = expected;
        }

        public int Sold { get; set; }
        public double Profit { get; set; }
        public string User { get; set; }
        public string Name { get; set; }
    }
}
