using PizzaStore.CliClient.ViewModels;
using System;

namespace PizzaStore.CliClient
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayUsers();
        }

        static void DisplayUsers()
        {
            var users = new UserViewModel();

            foreach (var item in users.GetUsers())
            {
                Console.WriteLine(item.UserId);
            }
        }
    }
}
