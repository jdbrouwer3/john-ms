using System;
using System.Collections.Generic;
using System.Text;
using d = PizzaStore.Data;
using m = PizzaStore.Domain.Models;

namespace PizzaStore.Domain.Helpers
{
    public class PizzaHelper
    {
        public m.Address AddressDataToAddressModel(d.Address a) //something with generics 
        {
            var mu = new m.Address();

            ma.AddressId = a.AddressId;

            return ma;
        }

        public m.User UserDataToUserModel(d.User u)
        {
            var mu = new m.User();

            mu.Address = AddressDataToAddressModel(u.Address);
            mu.Name = u.Name;
            mu.Orders = u.Order;

            return mu;
        }
    }
}
