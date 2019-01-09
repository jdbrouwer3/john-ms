using System.Collections.Generic;
using System.Xml.Serialization;
using System;
using System.Text;
using System.Linq;

namespace PizzaStore.Domain.Models
{
    public class Pizza
    {
        public int PizzaId { get; set; }
        public double Price { get; set; }
        public List<string> Toppings { get; set; }

        public Pizza()
        {
            var Siz = new Size();
            var Top = new Toppings();
            Price = Siz.SizePrice;
            Toppings = new List<string>();
        }


























        //public void AddTopping(string Toppings)
        //{
        //    if (Toppings.Count < 5)
        //    {
        //        Toppings.Add(Toppings);
        //    }
        //    else
        //    {
        //        return;
        //    }
        //}
    }
}
