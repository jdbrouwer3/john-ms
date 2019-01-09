using System;
using System.Collections.Generic;

namespace PizzaStore.Data.Models
{
    public partial class Address
    {
        public Address()
        {
            Location = new HashSet<Location>();
            User = new HashSet<User>();
        }

        public int AddressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public DateTime DateModified { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Location> Location { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
