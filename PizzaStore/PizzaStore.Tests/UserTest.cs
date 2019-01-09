using d = PizzaStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using PizzaStore.Data;

namespace PizzaStore.Tests
{
    public class UserTest
    {
        public d.User sut { get; private set; }
        public EntityHelper eh { get; set; }

        public PizzaStoreDbContext MyProperty { get; set; }

        public UserTest()
        {
            sut = new d.User();
            eh = new EntityHelper();
        }
        [Fact]
        public void Test_UserName()
        {
            sut.Name = "John Brouwer";
            Assert.True(eh.SetUser(sut));
        }
    }
}
