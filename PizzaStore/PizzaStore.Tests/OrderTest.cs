using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PizzaStore.Tests
{
    public class OrderTest
    {
        [Fact]
        public void Test_Order()
        {
            var expected = Ticket;
            var sut = new Order();

            Assert.NotNull(sut.Pizza);
            Assert.True(sut.Pizza <= Pizza.Quantity);
            Assert.True(sut.Price < 5000);
        }
    }
}
