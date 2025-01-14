using Microsoft.AspNetCore.Identity;
using SoftwareDevelopment2.Data;
using System.Security.Claims;

namespace SoftwareDevelopment2.Utils
{
    public class LoggedInUser
    {
        //Helper function for getting the user that is currently logged in
        public static async Task<IdentityUser> GetLoggedInUser(ApplicationDbContext _context, ClaimsPrincipal User)
        {
            var userEmail = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _context.Users.FindAsync(userEmail);
            return user;
        }
    }
}
