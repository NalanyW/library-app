using SoftwareDevelopment2.Models;

namespace SoftwareDevelopment2.Data
{
	public class AppDbInitializer
	{
		public static void Seed(IApplicationBuilder applicationBuilder)
		{
			using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
			{
				var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

				context.Database.EnsureCreated();

				/*if (!context.Users.Any())
				{
					context.Users.AddRange(new List<User>()
					{
						new User()
						{
							name = "Test",
							Age = "24"
						}
					});
				}*/

				/*if (!context.Student.Any())
				{
					context.Student.AddRange(new List<student>()
				}*/

				if (!context.Teacher.Any())
				{
					context.Teacher.AddRange(new List<Teacher>()
					{
						new Teacher()
						{
							FirstName = "Jan",
							LastName = "Zuur",
							Email = "placeholder"
							/*there needs to be a connection to the course*/
						},

						new Teacher()
						{
							FirstName = "Jan",
							LastName = "Zuur",
							Email = "placeholder"
						},

						new Teacher()
						{
							FirstName = "Jan",
							LastName = "Zuur",
							Email = "placeholder"
						},
					});
				};

				if (!context.Roles.Any())
				{

				}

				if (!context.Course.Any())
				{

				}

				if (!context.Book.Any())
				{

				}

				/*if (!context.UserRoles.Any())
				{
					context.UserRoles.AddRange(new List<UserRole>()
					{
						new UserRole()
						{
							name = "Test",
							Age = "24"
						}
					});

				}*/

				if (!context.UserClaims.Any())
				{

				}

				

				

				
			}
		}
	}
}
