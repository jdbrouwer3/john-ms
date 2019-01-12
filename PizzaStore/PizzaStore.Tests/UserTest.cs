using System.Collections.Generic;
using System.Linq;
using pd = PizzaStore.Data;
using PizzaStore.Data.Models;
using Xunit;
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
        }



















        //[Fact]
        //public void Test_SetDataUser()
        //{
        //    Assert.True(UserHelper.SetUser(sut));
        //}
    }
}
