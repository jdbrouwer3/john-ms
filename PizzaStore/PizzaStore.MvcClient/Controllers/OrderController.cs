﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;

//using Microsoft.EntityFrameworkCore;
//using PizzaStore.Data;
//using PizzaStoreMvc.Models;
//using pdm = PizzaStore.Domain.Models;
//using PizzaStore.Data.Entities;
//using System.Net;
//using PizzaStore.Data.Models;

//namespace PizzaStore.MvcClient.Controllers
//{
//    [Route("[controller]")]
//    public class OrderController : Controller
//    {
//        public static PizzaStoreDbContext _db = new PizzaStoreDbContext();
//        [HttpGet]
//        public IActionResult GetOrder()
//        {
//            var o = new Order()
//            {
//                Name = "jb",
//                Message = "this is what you just ordered:"
//            };

//            return View(Order, o);
//        }
        
//        [HttpPost]
//        public IActionResult PostOrder(Order order)
//        {
//            if (Order.menu)
//            {
//                return View("ThankYou");
//            }

//            return View("NextTime");
//        }
//    }
//}