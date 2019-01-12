using PizzaStore.CliClient.ViewModels;
using System;

namespace PizzaStore.CliClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //UserViewModel.EnterName();
            //DisplayUsers();
            //DisplayLocations();
            //DisplayMenu();
            //MainMenu()
            var menu = new MenuOne();
            menu.Menu();
        }







        ////////////// old stuff

        //static void DisplayUsers()
        //{
        //    var users = new UserViewModel();

        //    foreach (var item in users.GetUsers())
        //    {
        //        Console.WriteLine(item.UserId + " " + item.Name);
        //        //Console.WriteLine(item.Name);
        //    }
        //}

        //static void DisplayLocations()
        //{
        //    var locations = new LocationViewModel();

        //    foreach (var item in locations.GetLocations())
        //    {
        //        Console.WriteLine(item.LocationId + " " + item.Name);
        //    }
        //}

        //private static int DisplayMenu()
        //{
        //    Console.WriteLine("Select a location (1-3)");
        //    Console.WriteLine();
        //}

        //public void MainMenu()
        //{
        //    Console.WriteLine("Choose");
        //    var input = Console.ReadLine
        //        (
        //            Console.WriteLine("1");
        //            Console.WriteLine("2");
        //        )
        //    int choice;
        //    bool success = TryParse.Int32(input, out choice);
        //    if (success)
        //    {
        //        switch(choice)
        //            case 1:
        //            break
        //                case 2:
        //            break
        //                default
        //            break
        //    }
        //        else
        //        {
        //            Main Menu()
        //        }
        //}
    }
}
