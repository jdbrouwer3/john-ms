using System;
using System.Collections.Generic;
using System.Text;
using PizzaStore.Domain.Models;
using PizzaStore.Data.Helpers;

namespace PizzaStore.CliClient.ViewModels
{
    public class PizzaViewModel
    {

        public List<Size> GetSizes()
        {
            return SizeHelper.GetSizes();
        }

        public List<Crust> GetCrusts()
        {
            return CrustHelper.GetCrusts();
        }

    }
}
