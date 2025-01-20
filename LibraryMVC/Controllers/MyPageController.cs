using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoftwareDevelopment2.Data;
using SoftwareDevelopment2.Models;
using SoftwareDevelopment2.Utils;
using SoftwareDevelopment2.ViewModels;

namespace SoftwareDevelopment2.Controllers
{
    public class MyPageController : Controller
    {
        protected readonly ApplicationDbContext _context;
        public async Task<IActionResult> Index()
        {
            var reservations = await _context.Reservations.ToListAsync();
            var loans = await _context.Loans.ToListAsync();

            var indexViewModel = new IndexViewModel(reservations, loans);

            return View(indexViewModel);
        }

        public MyPageController(ApplicationDbContext context)
        {
            _context = context;
        }

        // index page for specific user
        [Authorize]
        public async Task<IActionResult> MyIndex()
        {

            var user = await LoggedInUser.GetLoggedInUser(_context, User);
            if (user == null)
            {
                return NotFound();
            }

            var reservationViewModels = await GetReservationViewModels(user);

            var loanViewModels = await GetLoanViewModels(user);

            var myPageViewModel = new MyPageViewModel(reservationViewModels, loanViewModels);

            return _context.Reservations != null ?
                        View(myPageViewModel) :
                        Problem("Entity set 'ApplicationDbContext.Reservations'  is null.");
        }
        public async Task<IEnumerable<LoanViewModel>> GetLoanViewModels(IdentityUser user)
        {
            //get list of only users' loans
            var loans = await _context.Loans.Where(loan => loan.UserId == user.Id).ToListAsync();

            var loanViewModels = new List<LoanViewModel>();

            //find corresponding books for each loan
            foreach (var loan in loans)
            {
                var book = await _context.Books.FirstOrDefaultAsync(book => book.Id == loan.ItemId);
                var loanViewModel = new LoanViewModel(loan, book);
                loanViewModels.Add(loanViewModel);
            }
            return loanViewModels;
        }
        public async Task<IEnumerable<ReservationViewModel>> GetReservationViewModels(IdentityUser user)
        {
            //get list of only users' reservations 
            var reservations = await _context.Reservations.Where(reservation => reservation.UserId == user.Id).ToListAsync();

            var reservationViewModels = new List<ReservationViewModel>();

            //find corresponding book for each reservation
            foreach (var reservation in reservations)
            {
                var book = await _context.Books.FirstOrDefaultAsync(book => book.Id == reservation.ItemId);
                var loanViewModel = new ReservationViewModel(reservation, book);
                reservationViewModels.Add(loanViewModel);
            }
            return reservationViewModels;
        }
    }

}
