using ParallelWorld.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ParallelWorld.Tests
{
    public class ThreadModelTest
    {
        [Fact]
        public void Test_ThreadMaster_Thread()
        {
            var sut = new ThreadModel();
            var expected = "fred";
            var actual = sut.ThreadMaster(expected);

            Assert.True(expected == actual);
        }

    }
}
