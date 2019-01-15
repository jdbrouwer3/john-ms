using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcWorld.Client.Models;

namespace MvcWorld.Client.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["CurrentTime"] = DateTime.Now;
            ViewBag.TimeNow = DateTime.Now;

            var i = new Invite();

            ViewBag.Name = "fred";
            i.AreYouComing(ViewBag.Name);

            if (i.Rsvp)
            {
                return View("Pass");
            }

            return View("Fail");
        }
    }
}