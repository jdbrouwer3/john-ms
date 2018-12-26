using GenericConsole.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GenericConsole.Tests.Library
{
    public class EmployeeTests
    {
        [Fact]
        public void Test_PeepName()
        {
            var sut = new Peep();
            // var expected;
            var actual = sut.Name;

            Assert.IsType<string>(actual); // if typeof(string).name == string then true. else false
            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_Title()
        {
            var sut = new Peep();
            var actual = sut.Title;

            Assert.IsType<string>(actual);
            Assert.NotNull(actual);
        }
            
        
    }
}
