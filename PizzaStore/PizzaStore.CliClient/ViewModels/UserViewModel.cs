using System;
using System.Collections.Generic;
using System.Text;
using PizzaStore.Domain.Models;
using PizzaStore.Data.Helpers;
using System.Linq;

namespace PizzaStore.CliClient.ViewModels
{
    public static class UserViewModel
    {
        public static List<User> GetUsers()
        {
            return UserHelper.GetUsers();
        }

        public static bool SetUser(User user)
        {
            return UserHelper.SetUser(user);
        }

        public static User GetUser(string username)
        {
            User user = new User();

            user.Name = username;

            return UserHelper.GetUser(user);
        }
    }
}
