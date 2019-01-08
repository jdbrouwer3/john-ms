using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class Address
    {
        public Address()
        {
            Location = new HashSet<Location>();
        }

        public int AddressId { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }

        public virtual ICollection<Location> Location { get; set; }
    }
}
