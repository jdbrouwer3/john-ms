using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using PizzaStore.Domain.Models;

namespace PizzaStore.Tests
{
    public class LocationTest
    {
        public Location sut { get; private set; }

        public LocationTests()
        {
            var sut = new Location(); 
        }

        [Fact]
        public void Test_LocationProperties()
        {
            Assert.IsType<int>(sut.Sold);
            Assert.True(sut.Sold >= 0);
            Assert.IsType<double>(sut.Profit);
            Assert.True(sut.Profit >= 0);
            Assert.IsType<string>(sut.User);
        }

        [Fact]
        public void Test_LocationGetUsers()
        {
            Assert.True(sut.Users.Count >= 0);
        }

        [Fact]
        public void Test_LocationGetInventory()
        {
            Assert.True(sut.Pizzas.Count >= 0);
        }

        [Theory]
        [InlineData(0,0)]
        [InlineData (10,100)]
        public void Test_LocationGetSales(int count, double sales)
        {
            Assert.True(sut.Orders.Count >= 0);
            Assert.True(sut.Sales() >= 0);
        }
    }
}
