using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using PizzaStore.Domain.Models;

namespace PizzaStore.Tests
{
    public class LocationTest
    {
        [Fact]
        public void Test_Location()
        {
            var expected = S1;
            var sut = new Location(expected);

            Assert.IsType<int>(sut.Sold);
            Assert.True(sut.Sold >= 0);
            Assert.IsType<double>(sut.Profit);
            Assert.True(sut.Profit >= 0);
            Assert.IsType<string>(sut.User);
        }
    }
}
