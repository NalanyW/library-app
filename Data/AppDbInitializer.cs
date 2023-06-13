using Microsoft.AspNetCore.Identity;
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

                context.Roles.AddRange(new List<IdentityRole>()
				{
					new IdentityRole("Admin"),
                    new IdentityRole("Employee"),
					new IdentityRole("User"),

                });

				var admin = new IdentityUser("admin")
				{
					Email = "admin@gmail.com"
				};

                var password = new PasswordHasher<IdentityUser>();
				var hashed = password.HashPassword(admin, "password");
				admin.PasswordHash = hashed;

                context.Users.AddRange(new List<IdentityUser>()
                {
                    admin,
                    new IdentityUser("Employee"),
                    new IdentityUser("User"),

                });

                if (!context.Book.Any())
				{
					context.Book.AddRange(new List<Book>()
					{
						new Book()
						{
							Title = "Harry Potter and the Philosopher's Stone",
							Author = "J.K Rowling",
							Price = 8.99,
							YearOfRelease = 1997,
							Location = "verdieping1"
						},

						new Book()
						{
							Title = "Harry Potter and the Chamber of Secrets",
							Author = "J.K Rowling",
							Price = 8.99,
							YearOfRelease = 1998,
							Location = "verdieping2"
						},

						new Book()
						{
							Title = "Harry Potter and the Prisoner of Azkaban",
							Author = "J.K Rowling",
							Price = 8.99,
							YearOfRelease = 1999,
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
