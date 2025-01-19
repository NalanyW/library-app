using Microsoft.EntityFrameworkCore;
using SoftwareDevelopment2.Models;
using SoftwareDevelopment2.Controllers;

namespace LibraryTest
{
    public class LocationsControllerTest(TestDatabaseFixture fixture) : IClassFixture<TestDatabaseFixture>
    {
        public TestDatabaseFixture Fixture { get; } = fixture;

        // tests whether a Location exists in the db after we create it
        [Fact]
        public async Task TestCreateLocation()
        {
            using var context = Fixture.CreateContext();
            context.Database.BeginTransaction();

            var controller = new LocationsController(context);

            var locationToCreate = new Location();
            locationToCreate.Name = "MyLocation";
            locationToCreate.Id = 12345;

            // call the method we are testing
            await controller.Create(locationToCreate);

            context.ChangeTracker.Clear();

            var location = await context.Locations.SingleAsync(b => b.Name == "MyLocation");
            Assert.NotNull(location);

            Assert.Equal(12345, location.Id);
        }

        // tests if we can edit a location
        [Fact]
        public async Task TestEditLocation()
        {
            using var context = Fixture.CreateContext();
            context.Database.BeginTransaction();

            var controller = new LocationsController(context);

            var location = new Location();
            location.Name = "MyLocation";
            location.Id = 12345;

            await controller.Create(location);

            location.Name = "MyEditedLocation";
            location.Id = 12345;

            // call the method we are testing
            await controller.Edit(location.Id, location);

            context.ChangeTracker.Clear();

            var editedLocation = await context.Locations.SingleAsync(a => a.Id == 12345);
            Assert.NotNull(editedLocation);
            Assert.Equal("MyEditedLocation", editedLocation.Name);
        }

        // tests if we can delete a location and it no longer exists
        [Fact]
        public async Task TestDeleteLocation()
        {
            using var context = Fixture.CreateContext();
            context.Database.BeginTransaction();

            var controller = new LocationsController(context);

            var locationToCreate = new Location();
            locationToCreate.Name = "MyLocation";
            locationToCreate.Id = 12345;

            await controller.Create(locationToCreate);

            // call the method we are testing
            await controller.DeleteConfirmed(locationToCreate.Id);

            context.ChangeTracker.Clear();

            var doesLocationExist = context.Locations.Any(a => a.Id == locationToCreate.Id);
            Assert.False(doesLocationExist);
        }

    }
}