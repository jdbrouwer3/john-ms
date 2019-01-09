﻿using System;
using System.Collections.Generic;

namespace PizzaStore.Data.Models
{
    public partial class Topping
    {
        public Topping()
        {
            PizzaTopping = new HashSet<PizzaTopping>();
        }

        public int ToppingId { get; set; }
        public string Name { get; set; }
        public DateTime DateModified { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<PizzaTopping> PizzaTopping { get; set; }
    }
}
