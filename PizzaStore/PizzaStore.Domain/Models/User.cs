using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
    public class User
    {
        public int Id { get; set; }

        private string expected;

        public User(string expected)
        {
            this.expected = expected;
        }

        public object Name { get; set; }
        public int LastOrderTime { get; set; }
        public int TodayLocations { get; set; }
    }
}
