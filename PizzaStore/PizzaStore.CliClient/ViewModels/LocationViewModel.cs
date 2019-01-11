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

        public static void PrintLocations()
        {
            Console.WriteLine("Please select a location by its number.");
            var locations = new LocationViewModel();

            foreach (var item in locations.GetLocations())
            {
                Console.WriteLine(item.LocationId + " " + item.Name);
            }

            int SelectedLocation = int.Parse(Console.ReadLine());
            switch (SelectedLocation)
            {
                case 4:
                    Console.WriteLine("Thank you for choosing the IQ Pizza Store");
                    break;
                case 5:
                    Console.WriteLine("Thank you for choosing the USF Pizza Store");
                    break;
                case 6:
                    Console.WriteLine("Thank you for chooseing the University Pizza Store");
                    break;
                default:
                    Console.WriteLine("Sorry, that location is currently unavailable. Please choose a different location.");
                    PrintLocations();
                    break;
            }
        }
    }
}