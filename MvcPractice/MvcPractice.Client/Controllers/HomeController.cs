using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using MvcPractice.Client.Models;

namespace MvcPractice.Client.Controllers
{
    [Route("[Controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            var m = new Menu();
            //{
            //    Message = "Thanks for choosing JB's!"
            //};

            return View("Index", m);
        }
            
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Post(Menu menu)
        {
            if (menu.Location > 0)
            {
                //january 31
                ViewBag.Location = menu.Location;
                ViewBag.Size = menu.Size;
                ViewBag.Crust = menu.Crust;
                ViewBag.Pizza = menu.Pizza;

                return View("Processed");
            }

            return View("Unsuccessful");
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
