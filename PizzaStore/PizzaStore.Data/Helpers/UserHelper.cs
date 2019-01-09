using PizzaStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pdm = PizzaStore.Domain.Models;

namespace PizzaStore.Data.Helpers
{
    public class UserHelper
    {
        private static PizzaStoreDbContext _db = new PizzaStoreDbContext();

        public static List<Order> GetOrderByUser(pdm.User user)
        {
            var orders = _db.User.Where(u => u.UserId == user.UserId).FirstOrDefault();

            if (dataUser != null)
            {
                //return dataUser.Order.ToList();
                var orders = new List<pdm.Order>();

                foreach (var item in dataUser.Order.ToList())
                {
                    orders.Add(new pdm.Order()
                    {
                        OrderId = item.OrderId
                    });
                }

                return orders;
            }

            return null;
        }
    }
}
