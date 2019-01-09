using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using d = PizzaStore.Domain.Models;
using PizzaStore.Data;
using System.Linq;

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
            Assert.IsType<Address>(sut.Address);
            Assert.IsType<List<Order>>(sut.Orders);
            Assert.IsType<List<Pizza>>(sut.Pizzas);
            Assert.IsType<List<User>>(sut.Users);
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
        [InlineData (-10,-100)]
        public void Test_LocationGetSales(int count, double sales)
        {
            Assert.True(sut.Orders.Count >= 0);
            Assert.True(sut.Sales() >= 0);
        }




        [Fact]
        public void Test_LocationData()
        {
            var actual = eh.GetLocations();

            Assert.NotNull(actual);
            Assert.True(actual.First().LocationId == 7); //where is 7 coming from????
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
