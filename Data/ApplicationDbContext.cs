using Bogus;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using SoftwareDevelopment2.Models;
using System.Reflection.Emit;

namespace SoftwareDevelopment2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //set of books
        public DbSet<Book> Books { get; set; } = default!;
        public DbSet<Reservation> Reservations { get; set; } = default!;
        public DbSet<Subscription> Subscriptions { get; set; } = default!;
        public DbSet<Loan> Loans { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder builder)
        {
            int amountToSeed = 120;

            base.OnModelCreating(builder);
            for (int i = 1; i < amountToSeed; i++)
            {
                builder.Entity<Book>().HasData(
                    new Book { Id = i, Title = "Harry Potter: " + i.ToString(), AuthorId = i, YearOfRelease = 1997 + i, LocationId = i });
                builder.Entity<Loan>().HasData(
                   new Loan { Id = i, UserId = (i % 10).ToString(), ItemId = i, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(21) });
                builder.Entity<Reservation>().HasData(
                   new Reservation { Id = i*100, UserId = (i % 10).ToString(), ItemId = i });
                builder.Entity<Location>().HasData(
                   new Location { Id = i, Name = "Verdieping " + i.ToString() });
            }

            var id = 1;
            var fakeAuthors = new Faker<Author>()
                .RuleFor(author => author.Id, faker => id++)
                .RuleFor(author => author.Name, faker => faker.Person.FullName)
                .RuleFor(author => author.Age, faker => 50);

            // generate items
            builder
                .Entity<Author>()
                .HasData(fakeAuthors.GenerateBetween(amountToSeed, amountToSeed));

            id = 1;
            var stock = new Faker<IdentityUser>()
            .RuleFor(m => m.Id, faker => id++.ToString())
            .RuleFor(m => m.UserName, faker => faker.Person.Email)
            .RuleFor(m => m.Email, faker => faker.Person.Email)
            .RuleFor(m => m.EmailConfirmed, faker => true)
            .RuleFor(m => m.PasswordHash, faker => faker.Random.Hash());

            // generate Users
            builder
                .Entity<IdentityUser>()
                .HasData(stock.GenerateBetween(amountToSeed, amountToSeed));
        }


        public DbSet<Author> Authors { get; set; } = default!;

        public DbSet<Location> Locations { get; set; } = default!;
    }
}