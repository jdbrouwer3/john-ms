using PizzaStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using pdm = PizzaStore.Domain.Models;

namespace PizzaStore.Data.Helpers
{
    public static class LocationHelper
    {
        private static PizzaStoreDbContext _db = new PizzaStoreDbContext();

        public static void GetLocationSales(pdm.Location location) { }

        public static void GetLocationUsers(pdm.Location location) { }
    }
}
