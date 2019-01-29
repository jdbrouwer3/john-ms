using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MovieNight.Data.Helpers;
using Xunit;

namespace MoveNight.Testing.UnitTests
{
    public class UserHelperTests
    {
        public UserHelper Sut { get; set; }

        public UserHelperTests()
        {
            Sut = new UserHelper();
        }

        [Fact]
        public void Test_GetUsers()
        {
            var actual = Sut.GetUsers();

            Assert.NotNull(actual);
            Assert.True(actual.Count > 0);
            Assert.NotNull(actual.First().Name);
        }
    }
}
