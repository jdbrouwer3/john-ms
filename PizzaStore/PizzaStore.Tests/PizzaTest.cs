using PizzaStore.Data;
using PizzaStore.Domain.Enums;
using PizzaStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PizzaStore.Tests
{
    public class PizzaTest
    {
        [Fact]
        public void Test_PizzaProperties()
        {
            var sut = new Data.Pizza();

            Assert.IsType<decimal>(sut.Price);

        }
    }
}
