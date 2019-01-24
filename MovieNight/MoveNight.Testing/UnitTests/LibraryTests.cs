using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MovieNight.Domain.Models;
using Xunit;

namespace MoveNight.Testing.UnitTests
{
    public class LibraryTests
    {
        private Library sut;
        public Address Address { get; set; }
        public Dictionary<Movie, int> Content { get; set; }
        public Movie Movie { get; set; }

        public LibraryTests()
        {
            Movie = new Movie()
            {
                Title = "Titanic",
                Rating = new Rating()
                {
                    Name = "NC-17",
                    Description = "too much romance"
                },
                Genre = new Genre()
                {
                    Name = "Horror",
                    Description = "too much romance still"
                },
                Summary = "big boat. people die.",
                Duration = new TimeSpan(3, 0, 0),
                Imdb = "url"
            };

            

            Address = new Address()
            {
                Street = "3220 Banyan Cir",
                City = "Tampa",
                StateProvince = "FL",
                Country = new Country()
                {
                    Name = "United States of America",
                    Code = "USA"
                },
                PostalCode = "33612"
            };

            Content = new Dictionary<Movie, int>()
            {
                {Movie, 10}
            };

            sut = new Library();
            sut.Address = Address;
            sut.Content = Content;
        }

        [Fact]
        public void Test_IsValid()
        {
            Assert.True(sut.IsValid());
        }

        [Fact]
        public void Test_Checkin()
        {
            var count = sut.Content[Movie];

            Assert.True(sut.CheckIn(Movie));
            Assert.True(sut.Content.Count == 1);
        }

        [Fact]
        public void Test_Checkout()
        {
            var count = sut.Content[Movie];

            Assert.True(sut.CheckOut(Movie.Title));
            Assert.True(sut.Content[Movie] == (count - 1));
        }
    }
}
