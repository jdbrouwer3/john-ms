using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome.Test
{
    public class PalindromeTest
    {
        [Fact]
        public void Test_Palindrome()
        {
            var sut = new Words();
            var actual = sut.Reverse;

            Assert.NotNull(actual);
            Assert.AreEqual(sut, actual);
        }

    }
}
