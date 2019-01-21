using PizzaStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pdm = PizzaStore.Domain.Models;

namespace PizzaStore.Data.Helpers 
{
    public static class PizzaHelper
    {
        //access to DB
        private static PizzaStoreDbContext _db = new PizzaStoreDbContext();

        //get pizzas
        //public static List<pdm.Pizza> GetPizzaByLocation(pdm.Location location)
        //{
        //    var dataLocation = _db.Location.Where(l => l.LocationId == location.LocationId).FirstOrDefault();

        //    if (dataLocation == null)
        //    {
        //        return null;
        //    }

        //    return GetPizzas(dataLocation.Order);
        //}

        public static List<pdm.Pizza> GetPizzaByOrder(pdm.Order order)
        {
            var dataOrder = _db.Order.Where(o => o.OrderId == order.OrderId).FirstOrDefault();

            if (dataOrder == null)
            {
                return null;
            }

            return GetPizzas(new List<Order>() { dataOrder });
        }

        private static List<pdm.Pizza> GetPizzas(ICollection<Order> orderCollection)
        {
            var pizzas = new List<pdm.Pizza>();

            foreach (var item in _db.Pizza.ToList())
            {
                pizzas.Add(new pdm.Pizza()
                {
                    PizzaId = item.PizzaId,
                    Name = item.Name
                });
            }

            return pizzas;

            //foreach (var item in orderCollection.ToList())
            //{
            //    foreach (var stuff in item.Pizza.ToList())
            //    {
            //        pizzas.Add(new pdm.Pizza()
            //        {
            //            PizzaId = stuff.PizzaId
            //        });
            //    }
            //}

            //return pizzas;
        }
    }
}