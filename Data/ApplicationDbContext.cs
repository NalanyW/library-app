using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SoftwareDevelopment2.Models;

namespace SoftwareDevelopment2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SoftwareDevelopment2.Models.Course> Course { get; set; } = default!;
        public DbSet<SoftwareDevelopment2.Models.Student> Student { get; set; } = default!;
        public DbSet<SoftwareDevelopment2.Models.Teacher> Teacher { get; set; } = default!;
        public DbSet<SoftwareDevelopment2.Models.Book> Book { get; set; } = default!;
    }
}