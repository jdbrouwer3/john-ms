using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class LocationPizza
    {
        public int LocationUserId { get; set; }
        public byte? LocationId { get; set; }
        public long? PizzaId { get; set; }

        public virtual Location Location { get; set; }
        public virtual Pizza Pizza { get; set; }
    }
}
