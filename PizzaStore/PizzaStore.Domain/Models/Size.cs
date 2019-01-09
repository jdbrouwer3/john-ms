using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
    public class Size
    {
        public int SizeId { get; set; }

        public string SizeName { get; }
        public double SizePrice { get; }
    }
}
