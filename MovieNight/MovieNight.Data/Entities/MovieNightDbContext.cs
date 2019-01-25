using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MovieNight.Data.Entities
{
    public partial class MovieNightDbContext : DbContext
    {
        public MovieNightDbContext()
        {
        }

        public MovieNightDbContext(DbContextOptions<MovieNightDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AddressLibrary> Address1 { get; set; } 
        public virtual DbSet<Collection> Collection { get; set; }
        public virtual DbSet<Content> Content { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Library> Library { get; set; }
        public virtual DbSet<Membership> Membership { get; set; }
        public virtual DbSet<Movie> Movie { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Queue> Queue { get; set; }
        public virtual DbSet<Rating> Rating { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=johndotnet2019.database.windows.net; database=MovieNightDB; user id=sqladmin; password=Florida2019;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address", "User");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PostalCode).HasMaxLength(10);

                entity.Property(e => e.StateProvince).HasMaxLength(100);

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<AddressLibrary>(entity =>
            {
                entity.HasKey(e => e.AddressId)
                    .HasName("PK_LibAddress_AddressId");

                entity.ToTable("Address", "Library");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PostalCode).HasMaxLength(10);

                entity.Property(e => e.StateProvince).HasMaxLength(100);

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Collection>(entity =>
            {
                entity.ToTable("Collection", "Movie");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Collection)
                    .HasForeignKey(d => d.MovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Collection_MovieId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Collection)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Collection_UserId");
            });

            modelBuilder.Entity<Content>(entity =>
            {
                entity.ToTable("Content", "Library");

                entity.HasOne(d => d.Library)
                    .WithMany(p => p.Content)
                    .HasForeignKey(d => d.LibraryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Content_LibraryId");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Content)
                    .HasForeignKey(d => d.MovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Content_MovieId");
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.ToTable("Genre", "Movie");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Library>(entity =>
            {
                entity.ToTable("Library", "Library");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Library)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Library_AddressId");
            });

            modelBuilder.Entity<Membership>(entity =>
            {
                entity.ToTable("Membership", "User");

                entity.HasIndex(e => e.Level)
                    .HasName("UQ_Membership_Level")
                    .IsUnique();

                entity.Property(e => e.Price).HasColumnType("numeric(5, 2)");
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("Movie", "Movie");

                entity.Property(e => e.Imdb).HasMaxLength(500);

                entity.Property(e => e.Summary).HasMaxLength(1000);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.Movie)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Movie_GenreId");

                entity.HasOne(d => d.Rating)
                    .WithMany(p => p.Movie)
                    .HasForeignKey(d => d.RatingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Movie_RatingId");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment", "User");

                entity.Property(e => e.CardHolder)
                    .IsRequired()
                    .HasMaxLength(110);

                entity.Property(e => e.CardNumber).HasColumnType("numeric(16, 0)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment_UserId");
            });

            modelBuilder.Entity<Queue>(entity =>
            {
                entity.ToTable("Queue", "Movie");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Queue)
                    .HasForeignKey(d => d.MovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Queue_MovieId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Queue)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Queue_UserId");
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.ToTable("Rating", "Movie");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User", "User");

                entity.Property(e => e.First)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Last)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prefix).HasMaxLength(5);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_AddressId");

                entity.HasOne(d => d.Membership)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.MembershipId)
                    .HasConstraintName("FK_User_MembershipId");
            });
        }
    }
}
