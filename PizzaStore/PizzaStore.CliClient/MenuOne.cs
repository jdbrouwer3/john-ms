﻿using System;
using System.Collections.Generic;
using System.Text;
using PizzaStore.Domain.Models;
using PizzaStore.Data.Helpers;
using System.Linq;
using PizzaStore.CliClient.ViewModels;

namespace PizzaStore.CliClient
{
    public class MenuOne
    {
        public void StartMenu()
        {
            Console.WriteLine("Welcome to JB's GRAND OPENING Pizza Store! \n" +
                "Enter 1 to Login, or 2 to Register.");
            int SelectedStart = int.Parse(Console.ReadLine());
            switch (SelectedStart)
            {
                case 1:
                    LoginMenu();
                    break;
                case 2:
                    RegisterMenu();
                    break;
                default:
                    Console.WriteLine("\n Oops... that's not an option. Try again \n");
                    StartMenu();
                    break;
            }
        }

        public void RegisterMenu()
        {
            Console.WriteLine("Create a username");
            var CreatedName = Console.ReadLine();
            var user = UserViewModel.GetUser(CreatedName);

        }

        public void LoginMenu()
        {
            var AllUsers = UserViewModel.GetUsers();
            Console.WriteLine("Welcome back!");
            Console.WriteLine("");
            Console.WriteLine("Please type your name.");
            var typed = Console.ReadLine();
            var un = AllUsers.FirstOrDefault(x => x.Name == typed);
            if (un == null)
            {
                Console.WriteLine("");
                Console.WriteLine("Name is incorrect. Please type your name.");
                LoginMenu();
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine($"Welcome {un.Name}!");
                PrintLocations();
                Console.WriteLine("");
            }

        }

        public void PrintLocations()
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
                    Console.WriteLine("");
                    Console.WriteLine("Thank you for choosing the IQ Pizza Store!");
                    Console.WriteLine("");
                    ChooseSize();
                    break;
                case 5:
                    Console.WriteLine("");
                    Console.WriteLine("Thank you for choosing the USF Pizza Store!");
                    Console.WriteLine("");
                    ChooseSize();
                    break;
                case 6:
                    Console.WriteLine("");
                    Console.WriteLine("Thank you for choosing the University Pizza Store!");
                    Console.WriteLine("");
                    ChooseSize();
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("Sorry, that location is currently unavailable. Please choose a different location.");
                    Console.WriteLine("");
                    PrintLocations();
                    break;
            }

        }

        public void ChooseSize()
        {
            Console.WriteLine("What size would you like? Select it by its number.");
            var sizes = new PizzaViewModel();

            foreach (var item in sizes.GetSizes())
            {
                Console.WriteLine(item.SizeId + " " + item.Name);
            }

            int SelectedSize = int.Parse(Console.ReadLine());
            switch (SelectedSize)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("You selected Small.");
                    ChooseCrust();
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("You selected Medium.");
                    ChooseCrust();
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("You selected Large!");
                    ChooseCrust();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("That's not a size. Try again.");
                    ChooseSize();
                    Console.WriteLine("");
                    break;
            }
        }

        public void ChooseCrust()
        {
            Console.WriteLine("How about the crust? Select it by its number.");
            var crusts = new PizzaViewModel();

            foreach (var item in crusts.GetCrusts())
            {
                Console.WriteLine(item.CrustId + " " + item.Name);
            }

            int SelectedCrust = int.Parse(Console.ReadLine());
            switch (SelectedCrust)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("You selected the New Crispy Thin Crust!");
                    ShowOrder();
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("You selected the Original Pan Crust!");
                    ShowOrder();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("We're always working on new crust ideas, but we don't have that one yet. For now you'll have to pick a different one.");
                    ChooseCrust();
                    Console.WriteLine("");
                    break;
            }
        }

        public static void ShowOrder()
        {
            Console.WriteLine("");
            Console.WriteLine("Your order was successful!");
        }
    }
}