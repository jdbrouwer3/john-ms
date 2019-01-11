//using PizzaStore.Data.Models;
//using System.Collections.Generic;
//using System.Linq;
//using pdm = PizzaStore.Domain.Models;

using Microsoft.EntityFrameworkCore;
using PizzaStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pdm = PizzaStore.Domain.Models;

namespace PizzaStore.Data.Helpers
{
    public static class LocationHelper
    {
        private static PizzaStoreDbContext _db = new PizzaStoreDbContext();

        public static double GetLocationSales(pdm.Location location)
        {
            var orders = OrderHelper.GetOrderByLocation(location);
            var sum = 0D;

            foreach (var item in orders)
            {
                sum += item.Total;
            }

            return sum;
        }

        public static List<pdm.User> GetLocationUsers(pdm.Location location)
        {
            var dataLocation = _db.Location.Where(l => l.LocationId == location.LocationId).FirstOrDefault();
            var users = new List<pdm.User>();

            foreach (var item in dataLocation.Order.ToList())
            {
                users.Add(new pdm.User()
                {
                    UserId = item.User.UserId
                });
            }

            return users;
        }

        public static bool SetLocation(pdm.Location location)
        {
            var dataLocation = new Location()
            {
                Address = new Address()
                {
                    City = location.Address.City,
                    State = location.Address.State,
                    Street = location.Address.Street
                }
            };

            _db.Location.Add(dataLocation);

            return _db.SaveChanges() == 1;
        }


        //Get Location -- change all users to location to make it work
        public static List<pdm.Location> GetLocations()
        {
            var dl = new List<pdm.Location>();

            foreach (var item in _db.Location.ToList())
            {
                dl.Add(new pdm.Location()
                {
                    LocationId = item.LocationId,
                    Name = item.Name
                    //and other things e.i. name
                });
            }

            return dl;
        }
    }
}