using System;
using System.Collections.Generic;

namespace PizzaStore.Data.Models
{
    public partial class User
    {
        public User()
        {
            Order = new HashSet<Order>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public DateTime LastTime { get; set; }
        public int? LastLocationId { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
