﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime LastTime { get; private set; }
        public int LocationId { get; set; }
        //public Address Address { get; set; }
        public List<Order> Orders { get; set; }

        //public User()
        //{
        //    Address = new Address();
        //    Name = string.Empty;
        //    Orders = new List<Order>();
        //}
        //public override string ToString()
        //{
        //    return $"{UserId}"; 
        //}
    }
}
