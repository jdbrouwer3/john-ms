using pd = PizzaStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using PizzaStore.Data;
using PizzaStore.Data.Models;
using PizzaStore.Data.Helpers;

namespace PizzaStore.Tests
{
    public class UserTest
    {
        private readonly User sut;

        public UserTest()
        {
            sut = new User()
            {
                Name = "fred",
                Address = new Address()
                {
                    City = "Tampa",
                    State = "Florida",
                    Street = "Fletcher Ave"
                }
            };
        }
        
        [Fact]
        public void Test_UserProperties()
        {
            Assert.IsType<Address>(sut.Address);
            Assert.IsType<string>(sut.Name);
            Assert.IsType<List<Order>>(sut.Order);

        }

        [Fact]
        public void Test_SetDataUser()
        {
            Assert.True(UserHelper.SetUser(sut));
        }
    }
}
