using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class Location
    {
        public Location()
        {
            Ingredient = new HashSet<Ingredient>();
            LocationOrder = new HashSet<LocationOrder>();
            LocationPizza = new HashSet<LocationPizza>();
            LocationUser = new HashSet<LocationUser>();
        }

        public byte LocationId { get; set; }
        public int? AddressId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool? Active { get; set; }

        public virtual Address Address { get; set; }
        public virtual ICollection<Ingredient> Ingredient { get; set; }
        public virtual ICollection<LocationOrder> LocationOrder { get; set; }
        public virtual ICollection<LocationPizza> LocationPizza { get; set; }
        public virtual ICollection<LocationUser> LocationUser { get; set; }
    }
}
