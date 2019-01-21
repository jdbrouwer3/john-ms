using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PizzaStore.MvcClient.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult GetAction()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult PostAction(Order order)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        order.MakeOrder();

        //        return View("Index");
        //    }

        //    return View("Error");
        //}
    }
}