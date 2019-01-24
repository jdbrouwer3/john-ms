using MovieNight.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MoveNight.Testing.UnitTests
{
    public class UserTests
    {
        private User sut;

        public Name Name { get; set; }
        public Address Address { get; set; }
        public Payment Payment { get; set; }
        public Membership Membership { get; set; }
        public Movie Movie { get; set; }
        public Library Library { get; set; }
        public Dictionary<Movie, int> Content { get; set; }



        public UserTests()
        {
            Name = new Name()
            {
                Prefix = new Prefix()
                {
                    Name = "Mr."
                },
                First = "John",
                Last = "Brouwer"
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

            Payment = new Payment()
            {
                Address = Address,
                CardHolder = Name,
                CardNumber = 1000200030004000,
                Month = 1,
                Year = 22,
                VerificationCode = 567
            };

            Membership = new Membership()
            {
                Level = 3,
                Price = 9.99M
            };

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

            Content = new Dictionary<Movie, int>()
            {
                {Movie, 10}
            };

            sut = new User()
            {
                Name = Name,
                Payment = Payment,
                Membership = Membership,
                Address = Address
            };
            sut.Collection.Add(Movie);
            sut.Queue.Add(Movie);

            Library = new Library();
            Library.Content = Content;
        }

        [Fact]
        public void Test_IsValid()
        {
            Assert.True(sut.IsValid());
        }

        [Fact]
        public void Test_ReturnMovie()
        {
            Assert.True(sut.ReturnMovie(Movie, Library));
            Assert.True(sut.Collection.Count == 1);
            Assert.True(sut.Queue.Count == 0);
        }
    }
}
