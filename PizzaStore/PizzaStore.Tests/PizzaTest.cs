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

            //Assert.IsType<ECrust>(sut.Crust);
            Assert.IsType<double>(sut.Price);
            //Assert.IsType<ESize>(sut.Size);
            //Assert.IsType<List<ETopping>>(sut.Toppings);
        }
    }
}
