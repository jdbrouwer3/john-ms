using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcWorld.Client.Models;

namespace MvcWorld.Client.Controllers
{
    [Route("[controller]")]
    public class InviteController : Controller
    {

        [HttpGet]
        public IActionResult Get()
        {
            var i = new Invitation()
            {
                Name = "John",
                Message = "Come to room 200b"
            };

            return View("Invitation", i);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Post(Invitation invite)
        {

            if (invite.Rsvp)
            {
                ViewBag.Name = invite.Name;
                ViewBag.Guests = invite.Guests;
                ViewBag.Menu = invite.Menu;

                return View("ThankYou");
            }

            return View("ShameOnYou");
        }



    }
}