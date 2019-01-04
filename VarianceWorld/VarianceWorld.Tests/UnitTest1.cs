using System;
using System.Collections.Generic;
using VarianceLibrary.Models;
using Xunit;
using System.Linq;

namespace VarianceWorld.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Explicit()
        {
            IEnumerable<byte?> expected = new byte?[2];
            var x = (short)10;
            byte? y = 10;
            byte? z = 10;

            var sut = new Casting();
            var actual = sut.Explicit(x);

            Assert.IsType<short>(x);
            Assert.Equal(10, x);
            Assert.IsType<byte?[]> (actual);
            Assert.True(expected.Count() == actual.Count());
            Assert.True(y == actual.ElementAt(0));
            Assert.False(z == actual.ElementAt(1));
        }

        [Fact]
        public void Test_ExplicitOut()
        {
            short x = 10;
            byte y;
            byte? z;
            var sut = new Casting();

            sut.Explicit(x, out y, out z);

            Assert.True(y == x);
            Assert.False(z == x);
        }

        [Fact]
        public void Test_ExplicitRef()
        {
            //short x = 10;
            //short w = x;
            var expected = 100;
            var sut = new Casting();
            byte y;
            byte? z;
            short w = 20;
            short x = 30;


            //sut.Explicit(ref w, ref x, out y, out z);
            sut.Explicit(ref w, ref x, out y, out z);

            //Assert.True(w == x);
            Assert.Equal(expected, w);
            Assert.Equal(expected, x);
        }

        [Fact]
        public void Test_ExplicitNoRef()
        {
            var expected = 100;
            var sut = new Casting();
            short w = 20;
            short x = 30;

            sut.Explicit(w, x);

            Assert.Equal(expected, w);
            Assert.Equal(expected, x);

        }
    }
}
