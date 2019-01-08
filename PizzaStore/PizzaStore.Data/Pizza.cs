using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class Pizza
    {
        public Pizza()
        {
            LocationPizza = new HashSet<LocationPizza>();
        }

        public long PizzaId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<LocationPizza> LocationPizza { get; set; }
    }
}
