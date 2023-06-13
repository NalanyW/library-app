using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SoftwareDevelopment2.Models;
using System.Data;

namespace SoftwareDevelopment2.Data
{
	public class AppDbInitializer
	{
		public static async void SeedData(IApplicationBuilder applicationBuilder)
		{
			using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
			{
				var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

				context.Database.EnsureCreated();

				var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                string[] roles = new string[] { "Admin", "Employee", "User"};

                for (int i = 0; i < roles.Length; i++)
                {
					if (!await roleManager.RoleExistsAsync(roles[i]))
						await roleManager.CreateAsync(new IdentityRole(roles[i]));
                }

				var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

				string email = "admin@admin.com";
				string password = "Test1234,";

				if (await userManager.FindByEmailAsync(email) == null)
				{
					var admin = new IdentityUser();
					admin.UserName = email;
					admin.Email = email;
					admin.EmailConfirmed = true;

					await userManager.CreateAsync(admin, password);

					await userManager.AddToRoleAsync(admin, "Admin");
				}



    //            if (!context.Books.Any())
				//{
				//	context.Books.AddRange(new List<Book>()
				//	{
				//		new Book()
				//		{
				//			Title = "Harry Potter and the Philosopher's Stone",
				//			Author = "J.K Rowling",
				//			Price = 8.99,
				//			YearOfRelease = 1997,
				//			Location = "verdieping1"
				//		},

				//		new Book()
				//		{
				//			Title = "Harry Potter and the Chamber of Secrets",
				//			Author = "J.K Rowling",
				//			Price = 8.99,
				//			YearOfRelease = 1998,
				//			Location = "verdieping2"
				//		},

				//		new Book()
				//		{
				//			Title = "Harry Potter and the Prisoner of Azkaban",
				//			Author = "J.K Rowling",
				//			Price = 8.99,
				//			YearOfRelease = 1999,
				//			Location = "verdieping3"
    //                    },
    //                });
    //            }

                //await AssignRoles(serviceScope.ServiceProvider, admin.Email, "Admin");

                await context.SaveChangesAsync();

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

        //public static async Task<IdentityResult> AssignRoles(IServiceProvider services, string email, string role)
        //{
        //    UserManager<IdentityUser> _userManager = services.GetService<UserManager<IdentityUser>>();
        //    IdentityUser user = await _userManager.FindByEmailAsync(email);
        //    var result = await _userManager.AddToRoleAsync(user, role);

        //    return result;
        //}
    }
}
