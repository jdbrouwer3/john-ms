using System;
using System.Collections.Generic;
using System.Text;
using PizzaStore.Domain.Models;
using PizzaStore.Data.Helpers;
using System.Linq;

namespace PizzaStore.CliClient.ViewModels
{
    public static class OrderViewModel
    {
        public static bool SetOrder(Order order)
        {
            return OrderHelper.SetOrder(order);
        }
    }
}
