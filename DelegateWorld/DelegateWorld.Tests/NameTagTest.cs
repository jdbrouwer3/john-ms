using DelegateWorld.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DelegateWorld.Tests
{
    public class NameTagTest
    {
        [Fact]
        public void Test_ActionFunc()
        {
            var expected = "fred belotte";
            var sut = new ActionFunc();
            var actual = sut.Sharpie2("fred", "belotte");

            Assert.True(expected == actual);
        }
    }
}
