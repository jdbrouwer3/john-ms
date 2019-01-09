using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using PizzaStore.Domain.Models;

namespace PizzaStore.Tests
{
    public class OrderTest
    {


        [Fact]
        public void Test_Order()
        {
            var sut = new Order();

            Assert.IsType<DateTime>(sut.Date);
            Assert.IsType<List<Pizza>>(sut.Pizzas);
            Assert.IsType<double>(sut.Total);
        }
    }
}
