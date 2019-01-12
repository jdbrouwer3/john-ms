using System;
using System.Collections.Generic;
using System.Text;
using PizzaStore.Domain.Models;
using PizzaStore.Data.Helpers;

namespace PizzaStore.CliClient.ViewModels
{
    public class LocationViewModel
    {
        public List<Location> GetLocations()
        {
            return LocationHelper.GetLocations();
        }
    }
}