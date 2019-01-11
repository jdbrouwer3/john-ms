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

        public static void EnterName()
        {
            var AllUsers = GetUsers();
            Console.WriteLine("Hello! Please type your name.");
            var typed = Console.ReadLine();
            var un = AllUsers.FirstOrDefault(x => x.Name == typed);
            if (un == null)
            {
                Console.WriteLine("Name is incorrect. Please type your name.");
                EnterName();
            }
            else
            {
                Console.WriteLine($"Welcome {un.Name}!");
                LocationViewModel.PrintLocations();
            }

        }
    }
}
