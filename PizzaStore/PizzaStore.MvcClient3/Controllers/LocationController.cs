using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaStore.MvcClient3.Models;

namespace PizzaStore.MvcClient3.Controllers
{
    public class LocationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Pizza(LocationViewModel locationViewModel)
        {
            //ViewBag.Name = "florida";
            TempData.Name = "Florida";
            //ViewBag.Name = locationViewModel.Name;
            ViewBag.Name = LocationName;

            return View();
        }
    }
}