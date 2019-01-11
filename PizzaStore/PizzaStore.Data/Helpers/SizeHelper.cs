using Microsoft.EntityFrameworkCore;
using PizzaStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pdm = PizzaStore.Domain.Models;

namespace PizzaStore.Data.Helpers
{
    public static class SizeHelper
    {
        private static PizzaStoreDbContext _db = new PizzaStoreDbContext();

        public static List<pdm.Size> GetSizes()
        {
            var du = new List<pdm.Size>();

            foreach (var item in _db.Size.ToList())
            {
                du.Add(new pdm.Size()
                {
                    SizeId = item.SizeId,
                    Name = item.Name
                    //and other things e.i. name
                });
            }

            return du;
        }
    }
}
