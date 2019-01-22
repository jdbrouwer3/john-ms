using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaStore.MvcClient.Models
{
    public class OrderViewModel
    {
        public int Location { get; set; }
        public int User { get; set; }
        public double Total { get; set; }
        public string Size { get; set; }
        public string Crust { get; set; }
        public string Pizza { get; set; }
    }
}
