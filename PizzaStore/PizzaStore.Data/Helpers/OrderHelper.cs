using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using pdm = PizzaStore.Domain.Models;
using PizzaStore.Data.Models;

namespace PizzaStore.Data.Helpers
{
    public static class OrderHelper
    {
        private static PizzaStoreDbContext _db = new PizzaStoreDbContext();

        //public static List<pdm.Order> GetOrderByLocation(pdm.Location location)
        //{
        //    var dataLocation = _db.Location.Where(l => l.LocationId == location.LocationId).FirstOrDefault();

        //    if (dataLocation == null)
        //    {
        //        return null;
        //    }

        //    return GetOrders(dataLocation.Order);
        //}

        public static List<pdm.Order> GetOrderByUser(pdm.User user)
        {
            var dataUser = _db.User.Where(u => u.UserId == user.UserId).FirstOrDefault();

            if (dataUser == null)
            {
                return null;
            }

            return GetOrders(dataUser.Order);
        }

        internal static List<pdm.Order> GetOrders(ICollection<Order> orderCollection)
        {
            var orders = new List<pdm.Order>();

            foreach (var item in orderCollection.ToList())
            {
                orders.Add(new pdm.Order()
                {
                    OrderId = item.OrderId
                });
            }

            return orders;
        }


    }
}
