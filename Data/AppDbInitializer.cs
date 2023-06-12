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


				if (!context.Student.Any())
				{
					context.Student.AddRange(new List<Student>()
					{
						new Student()
						{
							FirstName = "Jan",
							LastName = "Zuur",
							Email = "placeholder"
							/*there needs to be a connection to the course*/
						},

						new Student()
						{
							FirstName = "Jan",
							LastName = "Zuur",
							Email = "placeholder"
							/*there needs to be a connection to the course*/
						},

						new Student()
						{
							FirstName = "Jan",
							LastName = "Zuur",
							Email = "placeholder"
							/*there needs to be a connection to the course*/
						},
					});
				}

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
							/*there needs to be a connection to the course*/
						},

						new Teacher()
						{
							FirstName = "Jan",
							LastName = "Zuur",
							Email = "placeholder"
							/*there needs to be a connection to the course*/
						},
					});
				};


				if (!context.Course.Any())
				{
					context.Course.AddRange(new List<Course>()
					{
						new Course()
						{
							Id = 1,
							Title = "test",
							Code = "test",
							Description = "test"
							/*there needs to be a connection to the student*/
							/*there needs to be a connection to the teacher*/
						},

						new Course()
						{
							Id = 2,
							Title = "test2",
							Code = "test2",
							Description = "test2"
							/*there needs to be a connection to the student*/
							/*there needs to be a connection to the teacher*/
						},

						new Course()
						{
							Id = 3,
							Title = "test3",
							Code = "test3",
							Description = "test3"
							/*there needs to be a connection to the student*/
							/*there needs to be a connection to the teacher*/
						},
					});
				}

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
