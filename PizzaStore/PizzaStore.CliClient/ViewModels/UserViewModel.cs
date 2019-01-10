using System;
using System.Collections.Generic;
using System.Text;
using PizzaStore.Domain.Models;
using PizzaStore.Data.Helpers;

namespace PizzaStore.CliClient.ViewModels
{
    public class UserViewModel
    {
        public List<User> GetUsers()
        {
            return UserHelper.GetUsers();
        }
    }
}
