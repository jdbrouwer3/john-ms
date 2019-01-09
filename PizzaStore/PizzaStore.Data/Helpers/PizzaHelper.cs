using PizzaStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dom = PizzaStore.Domain.Models;

namespace PizzaStore.Data.Helpers  //This neeeds to be updated to match fred's
{
    public class PizzaHelper
    {
        public static List<pdm.Pizza> GetPizzaByLocation(pdm.Location location)
        {
            var dataLocation = _db.Location.Where(l => l.LocationId == location.LocationId).First
        }

        //access to DB
        private static PizzaStoreDbContext _db = new PizzaStoreDbContext();

        //get pizzas
        public List<dom.Pizza> GetPizzasByLocation(Location location)
        {
            var pizzas = _db.LocationPizza.Where(l => l.LocationId == location.LocationId).Pizza.ToList();
            var pi = new List<dom.Pizza>();

            foreach (var item in pizzas)
            {
                pi.Add(new dom.Pizza()
                {
                    PizzaId = item.PizzaId,
                    Price = item.Price
                });
            }

            return pi;
        }

        public List<dom.Pizza> GetPizzasByOrder(Order order)
        {

        }
    }
}
