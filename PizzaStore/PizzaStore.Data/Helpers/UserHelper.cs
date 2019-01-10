using PizzaStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pdm = PizzaStore.Domain.Models;

namespace PizzaStore.Data.Helpers
{
    public static class UserHelper
    {
        private static PizzaStoreDbContext _db = new PizzaStoreDbContext();

        public static List<pdm.Order> GetOrderByUser(pdm.User user)
        {
            var dataUser = _db.User.Where(u => u.UserId == user.UserId).FirstOrDefault();

            if (dataUser == null)
            {
                return null;
            }

            return OrderHelper.GetOrders(dataUser.Order);
        }
    }
}