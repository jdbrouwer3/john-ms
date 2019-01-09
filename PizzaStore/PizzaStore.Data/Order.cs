using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class Order
    {
        public Order()
        {
            LocationOrder = new HashSet<LocationOrder>();
        }

        public int OrderId { get; set; }
        public int LocationId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public DateTime DateModified { get; set; }
        public bool? Active { get; set; }

        public virtual Location Location { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<LocationOrder> LocationOrder { get; set; }
    }
}
