﻿using PizzaStore.Data.Models;
using System.Collections.Generic;
using System.Linq;
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
    }
}