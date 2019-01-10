using PizzaStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using d = PizzaStore.Domain.Models;

namespace PizzaStore.Data //take data objects and convert them to domain objects
                            // because I dont want people to have access to my database
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

        public bool SetUser(d.User u)
        {
            var du = new User();

            du.UserId = 5;
            du.DateModified = DateTime.Now.AddHours(6);
            du.Active = true;

            _db.User.Add(du);
            return _db.SaveChanges() == 1;
        }
    }
}


//add more stuff to .add(new....
