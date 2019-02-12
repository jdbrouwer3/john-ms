using System;
using System.Collections.Generic;
using System.Text;
using PizzaStore.Domain.Models;
using PizzaStore.Data.Helpers;

namespace PizzaStore.MvcClient3.Models
{
    public class LocationViewModel
    {
        public int LocationId { get; set; }
        public string Name { get; set; }

        public List<Location> GetLocations()
        {
            return LocationHelper.GetLocations();
        }
    }
}
