using Microsoft.EntityFrameworkCore;
using SoftwareDevelopment2.Models;
using SoftwareDevelopment2.Controllers;

namespace LibraryTest
{
    public class AuthorsControllerTest(TestDatabaseFixture fixture) : IClassFixture<TestDatabaseFixture>
    {
        public TestDatabaseFixture Fixture { get; } = fixture;

        // tests whether a Author exists in the db after we create it
        [Fact]
        public async Task TestCreateAuthor() 
        {
            using var context = Fixture.CreateContext();
            context.Database.BeginTransaction();

            var controller = new AuthorsController(context);

            var authorToCreate = new Author();
            authorToCreate.Name = "MyAuthor";
            authorToCreate.Age = 40;
            authorToCreate.Id = 12345;

            // call the method we are testing
            await controller.Create(authorToCreate);

            context.ChangeTracker.Clear();

            var author = await context.Authors.SingleAsync(b => b.Name == "MyAuthor");
            Assert.NotNull(author);

            Assert.Equal(12345, author.Id);
            Assert.Equal(40, author.Age);
        }

        // tests if we can edit a author
        [Fact]
        public async Task TestEditAuthor()
        {
            using var context = Fixture.CreateContext();
            context.Database.BeginTransaction();

            var controller = new AuthorsController(context);

            var author = new Author();
            author.Name = "MyAuthor";
            author.Age = 40;
            author.Id = 12345;

            await controller.Create(author);

            author.Name = "MyEditedAuthor";
            author.Age = 41;

            // call the method we are testing
            await controller.Edit(author.Id, author);

            context.ChangeTracker.Clear();

            var editedAuthor = await context.Authors.SingleAsync(a => a.Id == 12345);

            Assert.NotNull(editedAuthor);
            Assert.Equal("MyEditedAuthor", editedAuthor.Name);
            Assert.Equal(41, editedAuthor.Age);
        }

        // tests if we can delete a author and it no longer exists
        [Fact]
        public async Task TestDeleteAuthor()
        {
            using var context = Fixture.CreateContext();
            context.Database.BeginTransaction();

            var controller = new AuthorsController(context);

            var authorToCreate = new Author();
            authorToCreate.Name = "MyAuthor";
            authorToCreate.Age = 40;
            authorToCreate.Id = 12345;

            await controller.Create(authorToCreate);

            // call the method we are testing
            await controller.DeleteConfirmed(authorToCreate.Id);

            context.ChangeTracker.Clear();

            var doesAuthorExist = context.Authors.Any(a => a.Id == authorToCreate.Id);
            Assert.False(doesAuthorExist);
        }

    }
}