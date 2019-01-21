using PizzaStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using d = PizzaStore.Domain.Models;

//take data objects and convert them to domain objects
//because I dont want people to have access to my database

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

                });
            }
            return ls;
        }

        public List<d.Order> GetOrders()
        {
            var os = new List<d.Order>();

            foreach (var o in _db.Order.ToList())
            {
                os.Add(new d.Order()
                {
                    OrderId = o.OrderId
                   
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
                    
                });
            }
            return us;
        }

        public bool SetUser(d.User u)
        {
            var du = new User();

            du.Name = "Peter";
            du.LastTime = DateTime.Now;
            //du.UserId = 5;
            //du.DateModified = DateTime.Now.AddHours(6);
            //du.Active = true;

            _db.User.Add(du);
            return _db.SaveChanges() == 1;
        }
    }
}



