using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using d = PizzaStore.Domain.Models;
using PizzaStore.Data;

namespace PizzaStore.Tests
{
    public class LocationTest
    {
        public d.Location sut { get; private set; }
        public EntityHelper eh { get; set; }

        public PizzaStoreDbContext MyProperty { get; set; }

        public LocationTest()
        {
            sut = new d.Location();
            eh = new EntityHelper();
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



        //january 8
        [Fact]
        public void Test_LocationData()
        {
            Assert.NotNull(eh.GetLocations());
            Assert.True(eh.GetLocations().Count >= 0);
        }

        [Fact]
        public void Test_OrderData()
        {
            Assert.NotNull(eh.GetOrders());
            Assert.True(eh.GetOrders().Count >= 0);
        }

        [Fact]
        public void Test_PizzaData()
        {
            Assert.NotNull(eh.GetPizzas());
            Assert.True(eh.GetPizzas().Count >= 0);

        }

        [Fact]
        public void Test_UserData()
        {
            Assert.NotNull(eh.GetUsers());
            Assert.True(eh.GetUsers().Count >= 0);

        }
    }
}
//get locations, get orders, get pizzas, get user