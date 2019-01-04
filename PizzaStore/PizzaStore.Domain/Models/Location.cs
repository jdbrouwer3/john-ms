using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
    public class Location
    {
        public int Id { get; set; }

        private object expected;

        public Location(object expected)
        {
            this.expected = expected;
        }

        public int Sold { get; set; }
        public double Profit { get; set; }
        public string User { get; set; }
        public string Name { get; set; }

        //from fred:
        public double Sales()
        {
            double sum = 0;

            foreach (var order in Orders)
            {
                sum += order.Total;
            }

            return sum;
        }
    }
}
