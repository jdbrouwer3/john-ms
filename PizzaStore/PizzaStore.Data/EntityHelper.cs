using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using d = PizzaStore.Domain.Models;

namespace PizzaStore.Data
{
    public class EntityHelper
    {
        private static PizzaStoreDbContext _db = new PizzaStoreDbContext();

        public List<d.Location> GetLocations()
        {
            var ls = new List<d.Location>();

            foreach (var l in _db.Location.ToList())
            {
                ls.Add(new d.Location()
                {
                    LocationId = l.LocationId
                    //add more later
                });
            }
            return ls;
        }

        public List<Order> GetOrders() //grab the information from the db and give it to me in a type we understand
        {
            var os = new List<d.Order>();

            foreach (var o in _db.Order.ToList())
            {
                os.Add(new d.Order()
                {
                    OrderId = o.OrderId
                    //add more later
                });
            }
            return os;
        }
    }
}

//do the same for addresses, orders, users 
