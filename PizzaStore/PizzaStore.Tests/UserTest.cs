using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PizzaStore.Tests
{
    public class UserTest
    {
        [Fact]
        public void Test_UserName()
        {
            var expected = "John Brouwer";
            var sut = new User(expected);

            Assert.IsType<string>(sut.Name);
            Assert.True(expected == sut.Name);

        }
    }
}
