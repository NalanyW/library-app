using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SoftwareDevelopment2.Models;
using System.Data;

namespace SoftwareDevelopment2.Data
{
	public class AppDbInitializer
	{
		/// <summary>
		/// Seeds the roles and 2 users. One admin user and one employee user
		/// </summary>
		/// <param name="applicationBuilder"></param>
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


                string email2 = "employee@mail.com";
                string password2 = "Test123!";

                if (await userManager.FindByEmailAsync(email2) == null)
                {
                    var employee = new IdentityUser();
                    employee.UserName = email2;
                    employee.Email = email2;
                    employee.EmailConfirmed = true;

                    await userManager.CreateAsync(employee, password2);

                    await userManager.AddToRoleAsync(employee, "Employee");
                }

                string email3 = "user@mail.com";
                string password4 = "Password1!";

                if (await userManager.FindByEmailAsync(email2) == null)
                {
                    var employee = new IdentityUser();
                    employee.UserName = email2;
                    employee.Email = email2;
                    employee.EmailConfirmed = true;

                    await userManager.CreateAsync(employee, password2);

                    await userManager.AddToRoleAsync(employee, "User");
                }

                await context.SaveChangesAsync();


            }
        }

    }
}
