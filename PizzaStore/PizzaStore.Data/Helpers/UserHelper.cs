using Microsoft.EntityFrameworkCore;
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

        public static List<pdm.User> GetUsers()
        {
            var du = new List<pdm.User>();

            foreach (var item in _db.User.ToList())
            {
                du.Add(new pdm.User()
                {
                    UserId = item.UserId,
                    Name = item.Name
                    //and other things e.i. name
                });
            }

            return du;
        }

        public static bool SetUser(pdm.User user)
        {
            var address = _db.Address.First(a => a.Street == user.Address.Street);
            var dataUser = new User()
            {
                Name = user.Name,
                //password if you have it
            };

            if (address == null)
            {
                dataUser.Address = new Address()
                {
                    City = user.Address.City,
                    State = user.Address.State,
                    Street = user.Address.Street
                };
            } else
            {
                dataUser.AddressId = address.AddressId;
            }

            _db.User.Add(dataUser);

            return address == null ? _db.SaveChanges() == 2 : _db.SaveChanges() == 1;
        }

        public static void SetUser2()
        {
            var q1 = _db.Query<User>().FromSql("exec yourStoredProcedure");
            var q2 = from u in _db.User
                     where u.AddressId >= 1
                     select u;

            _db.Add(new User());

            var l = q2.ToList();
        }
    }
}