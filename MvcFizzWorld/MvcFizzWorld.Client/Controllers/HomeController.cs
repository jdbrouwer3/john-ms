using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcFizzWorld.Client.Models;

namespace MvcFizzWorld.Client.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            for (var i = 1; i <= 50; i++)
            {
                ViewData[i.ToString()] = Invite.Categorize(i);
            }
            return View();
        }
    }
}