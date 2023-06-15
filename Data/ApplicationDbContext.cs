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
            base.OnModelCreating(builder);
            for (int i = 1; i < 20; i++)
            {
                builder.Entity<Book>().HasData(
                    new Book { Id = i, Title = "Harry Potter: " + i.ToString(), Author = "J.K. Rowling", YearOfRelease = 1997 + i, Location = "Verdieping " + i });
                builder.Entity<Loan>().HasData(
                   new Loan { Id = i, UserId = i.ToString(), ItemId = i % 50, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(21) });
                builder.Entity<Reservation>().HasData(
                   new Reservation { Id = i, UserId = i.ToString(), ItemId = i % 50 });
            }
            var id = 1;
            var stock = new Faker<IdentityUser>()
            .RuleFor(m => m.Id, faker => id++.ToString())
            .RuleFor(m => m.UserName, faker => faker.Person.Email)
            .RuleFor(m => m.Email, faker => faker.Person.Email)
            .RuleFor(m => m.EmailConfirmed, faker => true)
            .RuleFor(m => m.PasswordHash, faker => faker.Random.Hash());

            // generate 100 items
            builder
                .Entity<IdentityUser>()
                .HasData(stock.GenerateBetween(10, 10));
        }


        public DbSet<SoftwareDevelopment2.Models.Author> Author { get; set; } = default!;
    }
}