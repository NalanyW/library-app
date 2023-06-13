using SoftwareDevelopment2.Models;

namespace SoftwareDevelopment2.Data
{
	public class AppDbInitializer
	{
		public static void SeedData(IApplicationBuilder applicationBuilder)
		{
			using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
			{
				var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

				context.Database.EnsureCreated();
				

				if (!context.Book.Any())
				{
					context.Book.AddRange(new List<Book>()
					{
						new Book()
						{
							Title = "test1",
							Author = "test1",
							Price = 15,
							YearOfRelease = 07121998,
							Location = "verdieping1"
						},

						new Book()
						{
							Title = "test2",
							Author = "test2",
							Price = 15,
							YearOfRelease = 07121998,
							Location = "verdieping2"
						},

						new Book()
						{
							Title = "test3",
							Author = "test3",
							Price = 15,
							YearOfRelease = 07121998,
							Location = "verdieping3"
						},
					});
					context.SaveChanges();
				}

				/*if (!context.Item.Any())
				{
					context.Item.AddRange(new List<Item>()
					{
						new Item()
						{
							*//*there needs to be a connection to the course*//*
						},

						new Item()
						{
							*//*there needs to be a connection to the course*//*
						},

						new Item()
						{
							*//*there needs to be a connection to the course*//*
						},
					});
				}*/

				/*if (!context.Roles.Any())
				{

				}*/








			}
		}
	}
}
