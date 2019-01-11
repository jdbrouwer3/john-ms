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

        public static void ChooseSize()
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
                    PizzaViewModel.ChooseCrust();
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("You selected Medium.");
                    PizzaViewModel.ChooseCrust();
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("You selected Large!");
                    PizzaViewModel.ChooseCrust();
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

        public List<Crust> GetCrusts()
        {
            return CrustHelper.GetCrusts();
        }

        public static void ChooseCrust()
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
                    PizzaViewModel.ChooseCrust();
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("You selected the Original Pan Crust!");
                    PizzaViewModel.ChooseCrust();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("We're always working on new crust ideas, but we don't have that one yet. For now you'll have to pick a different one.");
                    ChooseSize();
                    Console.WriteLine("");
                    break;
            }
        }
    }
}
