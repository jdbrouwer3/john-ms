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

        public List<d.Order> GetOrders() //grab the information from the db and give it to me in a type we understand
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

        public List<d.Pizza> GetPizzas()
        {
            var ps = new List<d.Pizza>();

            foreach (var p in _db.Pizza.ToList())
            {
                ps.Add(new d.Pizza()
                {
                    PizzaId = p.PizzaId
                    //add more later
                });
            }
            return ps;
        }

        public List<d.User> GetUsers()
        {
            var us = new List<d.User>();

            foreach (var u in _db.User.ToList())
            {
                us.Add(new d.User()
                {
                    UserId = u.UserId
                    //add more later
                });
            }
            return us;
        }
    }
}


//add more stuff to .add(new....
