using Microsoft.EntityFrameworkCore;
using SoftwareDevelopment2.Data;
using SoftwareDevelopment2.Models;

namespace LibraryTest
{
    public class TestDatabaseFixture
    {
        private const string ConnectionString = @"DataSource=database.db; Cache=Shared";

        private static readonly object _lock = new();
        private static bool _databaseInitialized;

        public TestDatabaseFixture()
        {
            lock (_lock)
            {
                if (!_databaseInitialized)
                {
                    using (var context = CreateContext())
                    {
                        context.Database.EnsureDeleted();
                        context.Database.EnsureCreated();
                        Seed(context);
                        context.SaveChanges();
                    }

                    _databaseInitialized = true;
                }
            }
        }

        public ApplicationDbContext CreateContext()
            => new ApplicationDbContext(
                new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseSqlite(ConnectionString)
                    .Options);


        private void Seed(ApplicationDbContext context)
        {
            for (int i = 0; i < 10; i++)
            {
                var book = new Book();
                book.Id = 1000 + i;
                book.Title = "book" + i;
                book.AuthorId = i;
                book.YearOfRelease = 2000 + i;
                context.Books.Add(book);
            }

            for (int i = 0; i < 10; i++)
            {
                var author = new Author();
                author.Name = "author" + 1;
                author.Age = 50 + i;
                author.Id = 2000 + i;
                context.Authors.Add(author);
            }

            for (int i = 0; i < 10; i++)
            {
                var location = new Location();
                location.Id = 3000 + i;
                location.Name = "location" + i;
                context.Locations.Add(location);
            }

        }
    }
}
