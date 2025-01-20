using Microsoft.EntityFrameworkCore;
using SoftwareDevelopment2.Models;
using SoftwareDevelopment2.Controllers;
using SoftwareDevelopment2.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LibraryTest
{
    public class BooksControllerTest(TestDatabaseFixture fixture) : IClassFixture<TestDatabaseFixture>
    {
        public TestDatabaseFixture Fixture { get; } = fixture;

        // tests whether a book exists in the db after we create it
        [Fact]
        public async Task TestCreateBook()
        {
            using var context = Fixture.CreateContext();
            context.Database.BeginTransaction();

            var controller = new BooksController(context);

            var createBook = new CreateBookViewModel();
            createBook.Book = new Book();
            createBook.Book.Title = "MyBook";
            createBook.Book.YearOfRelease = 2012;
            createBook.Book.Id = 31415;
            createBook.AuthorChoice = await context.Authors.FirstOrDefaultAsync(a => a.Id == 2000);
            createBook.LocationChoice = await context.Locations.FirstOrDefaultAsync(l => l.Id == 3000);

            // call the method we are testing
            await controller.Create(createBook);

            context.ChangeTracker.Clear();

            var book = await context.Books.SingleAsync(b => b.Title == "MyBook");
            Assert.NotNull(book);

            Assert.Equal(31415, book.Id);
            Assert.Equal(2012, book.YearOfRelease);
            Assert.Equal(2000, book.AuthorId);
            Assert.Equal(3000, book.LocationId);
        }

        // tests if we can edit a book
        [Fact]
        public async Task TestEditBook()
        {
            using var context = Fixture.CreateContext();
            context.Database.BeginTransaction();

            var controller = new BooksController(context);

            var createBook = new CreateBookViewModel();

            createBook.Book = new Book();
            createBook.Book.Id = 31415;
            createBook.Book.Title = "MyBook";
            createBook.Book.YearOfRelease = 2012;
            createBook.AuthorChoice = await context.Authors.FirstOrDefaultAsync(a => a.Id == 2000);
            createBook.LocationChoice = await context.Locations.FirstOrDefaultAsync(l => l.Id == 3000);

            await controller.Create(createBook);

            createBook.Book.Title = "YourBook";
            createBook.Book.YearOfRelease = 2025;
            createBook.AuthorChoice = await context.Authors.FirstOrDefaultAsync(a => a.Id == 2005);
            createBook.LocationChoice = await context.Locations.FirstOrDefaultAsync(l => l.Id == 3005);

            // call the method we are testing
            await controller.Edit(createBook.Book.Id, createBook);

            context.ChangeTracker.Clear();

            var book = await context.Books.SingleAsync(b => b.Id == 31415);
            Assert.NotNull(book);
            Assert.Equal("YourBook", book.Title);
            Assert.Equal(2025, book.YearOfRelease);
            Assert.Equal(2005, book.AuthorId);
            Assert.Equal(3005, book.LocationId);
        }

        // tests if we can delete a book and it no longer exists
        [Fact]
        public async Task TestDeleteBook()
        {
            using var context = Fixture.CreateContext();
            context.Database.BeginTransaction();

            var controller = new BooksController(context);

            var createBook = new CreateBookViewModel();

            createBook.Book = new Book();
            createBook.Book.Id = 31415;
            createBook.Book.Title = "MyBook";
            createBook.Book.YearOfRelease = 2012;
            createBook.AuthorChoice = await context.Authors.FirstOrDefaultAsync(a => a.Id == 2000);
            createBook.LocationChoice = await context.Locations.FirstOrDefaultAsync(l => l.Id == 3000);

            await controller.Create(createBook);

            // call the method we are testing
            await controller.DeleteConfirmed(createBook.Book.Id);

            context.ChangeTracker.Clear();

            var doesBookExist = context.Books.Any(b => b.Id == createBook.Book.Id);
            Assert.False(doesBookExist);
        }

        // test that we can search a book based on the title
        [Fact]
        public async Task TestSearchBookOnTitle()
        {
            using var context = Fixture.CreateContext();
            context.Database.BeginTransaction();

            var controller = new BooksController(context);

            var search = new SearchViewModel();
            search.SearchOn = SearchOn.Title;
            search.SearchPhrase = "BOOK1";

            // call the method we are testing
            ViewResult view = (ViewResult)await controller.ShowSearchResult(search);

            context.ChangeTracker.Clear();

            Assert.NotNull(view);
            Assert.NotNull(view.ViewData);
            Assert.NotNull(view.ViewData.Model);
            var resultBooks = ((IEnumerable<BookViewModel>)view.ViewData.Model);
            Assert.Single(resultBooks);
            Book? book = resultBooks.First().Book;
            Assert.NotNull(book);

            Assert.Equal(1001, book.Id);
            Assert.Equal("book1", book.Title);
            Assert.Equal(2001, book.YearOfRelease);
            Assert.Equal(2001, book.AuthorId);
            Assert.Equal(3001, book.LocationId);
        }

        // test that we can search a book based on the author
        [Fact]
        public async Task TestSearchBookOnAuthor()
        {
            using var context = Fixture.CreateContext();
            context.Database.BeginTransaction();

            var controller = new BooksController(context);

            var search = new SearchViewModel();
            search.SearchOn = SearchOn.Author;
            search.SearchPhrase = "Author1";

            // call the method we are testing
            ViewResult view = (ViewResult)await controller.ShowSearchResult(search);

            context.ChangeTracker.Clear();

            Assert.NotNull(view);
            Assert.NotNull(view.ViewData);
            Assert.NotNull(view.ViewData.Model);
            var resultBooks = ((IEnumerable<BookViewModel>)view.ViewData.Model);
            Assert.Single(resultBooks);
            Book? book = resultBooks.First().Book;
            Assert.NotNull(book);

            Assert.Equal(1001, book.Id);
            Assert.Equal("book1", book.Title);
            Assert.Equal(2001, book.YearOfRelease);
            Assert.Equal(2001, book.AuthorId);
            Assert.Equal(3001, book.LocationId);
        }

        // test that we can search a book based on the location
        [Fact]
        public async Task TestSearchBookOnLocation()
        {
            using var context = Fixture.CreateContext();
            context.Database.BeginTransaction();

            var controller = new BooksController(context);

            var search = new SearchViewModel();
            search.SearchOn = SearchOn.Location;
            search.SearchPhrase = "Location5";

            // call the method we are testing
            ViewResult view = (ViewResult)await controller.ShowSearchResult(search);

            context.ChangeTracker.Clear();

            // assert that view contains a list with 1 book
            Assert.NotNull(view);
            Assert.NotNull(view.ViewData);
            Assert.NotNull(view.ViewData.Model);
            var resultBooks = ((IEnumerable<BookViewModel>)view.ViewData.Model);
            Assert.Single(resultBooks);
            Book? book = resultBooks.First().Book;
            Assert.NotNull(book);

            Assert.Equal(1005, book.Id);
            Assert.Equal("book5", book.Title);
            Assert.Equal(2005, book.YearOfRelease);
            Assert.Equal(2005, book.AuthorId);
            Assert.Equal(3005, book.LocationId);
        }
    }
}