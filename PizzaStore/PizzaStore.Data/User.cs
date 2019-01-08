using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class User
    {
        public User()
        {
            LocationUser = new HashSet<LocationUser>();
        }

        public short UserId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<LocationUser> LocationUser { get; set; }
    }
}
