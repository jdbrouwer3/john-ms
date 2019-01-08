using System.Collections.Generic;
using System.Xml.Serialization;
using PizzaStore.Domain.Enums;

namespace PizzaStore.Domain.Models
{
    public class Pizza
    {
        private static Dictionary<string, double> Pricing = new Dictionary<Size, double> //some other change
        {
          {ESize.Large, 15},
          {ESize.Medium, 10},
          {ESize.Small, 5}
        };

        public int PizzaId { get; set; }
        public Crust Crust { get; set; }
        public double Price { get; set; }
        public Size Size { get; set; }
        public List<Topping> Toppings { get; set; }

        public Pizza()
        {
            Crust = new Crust();
            Price = Pricing[Size.Name];
            Size = new Size();
            Toppings = new List<Topping>
            {
                new Topping(),
                new Topping()
            };
        }
    }
}
