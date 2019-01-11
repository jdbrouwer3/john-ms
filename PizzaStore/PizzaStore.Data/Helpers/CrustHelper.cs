using Microsoft.EntityFrameworkCore;
using PizzaStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pdm = PizzaStore.Domain.Models;

namespace PizzaStore.Data.Helpers
{
    public static class CrustHelper
    {
        private static PizzaStoreDbContext _db = new PizzaStoreDbContext();

        public static List<pdm.Crust> GetCrusts()
        {
            var du = new List<pdm.Crust>();

            foreach (var item in _db.Crust.ToList())
            {
                du.Add(new pdm.Crust()
                {
                    CrustId = item.CrustId,
                    Name = item.Name
                    //and other things e.i. name
                });
            }

            return du;
        }
    }
}
