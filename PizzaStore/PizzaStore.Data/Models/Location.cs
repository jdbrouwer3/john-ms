﻿using System;
using System.Collections.Generic;

namespace PizzaStore.Data.Models
{
    public partial class Location
    {
        public Location()
        {
            Order = new HashSet<Order>();
        }

        public int LocationId { get; set; }
        public int AddressId { get; set; }
        public string Name { get; set; }
        public DateTime DateModified { get; set; }
        public bool? Active { get; set; }

        public virtual Address Address { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}