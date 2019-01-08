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
        public DateTime ModifiedDate { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<LocationOrder> LocationOrder { get; set; }
    }
}
