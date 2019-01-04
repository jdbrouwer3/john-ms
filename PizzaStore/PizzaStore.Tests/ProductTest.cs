using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PizzaStore.Tests
{
    public class ProductTest
    {
        [Fact]
        public void Test_ProductToppings()
        {
            var expected = Toppings
            var sut = new Pizza();

            Assert.True(sut.Toppings.Count <= 5);
            Assert.NotNull(sut.Crust);
            Assert.True(sut.Size == PizzaSize.Medium);
            Assert.True(sut.Price > 0);
        }
    }
}
