﻿using System;
using System.Collections.Generic;

namespace PizzaStore.Data.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int LocationId { get; set; }
        public int UserId { get; set; }
        public decimal Total { get; set; }
        public DateTime DateOrdered { get; set; }
        public DateTime DateModified { get; set; }
        public bool? Active { get; set; }

        public virtual User User { get; set; }
    }
}
