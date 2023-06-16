using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoftwareDevelopment2.Data;
using SoftwareDevelopment2.Models;
using SoftwareDevelopment2.ViewModels;
using System;

namespace SoftwareDevelopment2.Controllers
{
    [Authorize(Roles = "Employee, Admin")]
    public class UsersController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly ApplicationDbContext _context;

        public UsersController(UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            this.userManager = userManager;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var users = userManager.Users;
            return View(users);
        }


        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            var userRole = await _context.UserRoles.FirstOrDefaultAsync(userRole => userRole.UserId == id);
            IdentityRole? role;

            // if unable to find associated role, we assume user role
            IdentityRole defaultRole = new IdentityRole
            {
                Name = "User"
            };

            if (userRole != null)
            {
                role = await _context.Roles.FirstOrDefaultAsync(role => role.Id == userRole.RoleId);
                if (role == null)
                {
                    role = defaultRole;
                }
            }
            else
            {
                role = defaultRole;
            }

            bool authorized =
                User.IsInRole("Admin") ||
                User.IsInRole("Employee") &&
                role.Name == "User";

            var userViewModel = new EditUserViewModel
            {
                Id = id,
                Email = user.Email,
                PasswordHash = user.PasswordHash,
                IsLocked = user.LockoutEnd > DateTime.UtcNow,
                Authorized = authorized
            };

            return View(userViewModel);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Email, PasswordHash, Id, IsLocked")] EditUserViewModel userViewModel)
        {
            if (id != userViewModel.Id)
            {
                return NotFound();
            }
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //set input values
                    user.Email = userViewModel.Email;
                    user.UserName = user.Email;
                    user.PasswordHash = userViewModel.PasswordHash;

                    // locks or unlocks users based on input
                    if (userViewModel.IsLocked)
                    {
                        user.LockoutEnd = DateTime.UtcNow.AddYears(999);
                        user.LockoutEnabled = true;
                    }
                    else
                    {
                        user.LockoutEnd = DateTime.Now;
                        user.LockoutEnabled = false;
                    }

                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(user => user.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Users == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Users'  is null.");
            }
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(string id)
        {
            return (_context.Users?.Any(e => e.Id == id)).GetValueOrDefault();
        }

    }

}
