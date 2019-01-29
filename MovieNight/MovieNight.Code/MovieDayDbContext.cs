using Microsoft.EntityFrameworkCore;
using MovieNight.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Code
{
    public class MovieDayDbContext : DbContext 
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Name> Names { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Prefix> Prefixes { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("server=johndotnet2019.database.windows.net; database=MovieNightDB; user id=sqladmin; password=Florida2019;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Address>().HasKey(e => e.Id);
            builder.Entity<Country>().HasKey(e => e.Id);
            builder.Entity<Genre>().HasKey(e => e.Id);
            builder.Entity<Library>().HasKey(e => e.Id);
            builder.Entity<Membership>().HasKey(e => e.Id);
            builder.Entity<Movie>().HasKey(e => e.Id);
            builder.Entity<Name>().HasKey(e => e.Id);
            builder.Entity<Payment>().HasKey(e => e.Id);
            builder.Entity<Prefix>().HasKey(e => e.Id);
            builder.Entity<Rating>().HasKey(e => e.Id);
            builder.Entity<User>().HasKey(e => e.Id);

            builder.Entity<Library>().Ignore(e => e.Content);
        }
    }
}
