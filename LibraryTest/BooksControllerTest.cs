using Microsoft.EntityFrameworkCore;
using SoftwareDevelopment2.Data;
using SoftwareDevelopment2.Models;
using SoftwareDevelopment2.Controllers;
using SoftwareDevelopment2.ViewModels;
using Xunit;

namespace LibraryTest
{
    public class BooksControllerTest(TestDatabaseFixture fixture) : IClassFixture<TestDatabaseFixture>
    { 
        public TestDatabaseFixture Fixture { get; } = fixture;


        [Fact]
        public async Task TestCreateBook()
        {
            using var context = Fixture.CreateContext();
            context.Database.BeginTransaction();

            var controller = new BooksController(context);
            var createBook = new CreateBookViewModel();
            createBook.Book = new Book();
            createBook.Book.Title = "MyBook";
            createBook.Book.Id = 31415;
            createBook.AuthorChoice = await context.Authors.FirstOrDefaultAsync(a => a.Id == 2000);
            createBook.LocationChoice = await context.Locations.FirstOrDefaultAsync(a => a.Id == 3000);
            await controller.Create(createBook);

            context.ChangeTracker.Clear();

            var blog = await context.Books.SingleAsync(b => b.Title == "MyBook");
            Assert.NotNull(blog);
        }

        [Fact]
        public void TestBadge()
        {
            Assert.NotNull(null);
        }
    }
}