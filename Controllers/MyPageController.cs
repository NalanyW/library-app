using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoftwareDevelopment2.Data;
using SoftwareDevelopment2.Models;
using SoftwareDevelopment2.Utils;

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
            //get list of only users' reservations and all books
            var loans = await _context.Loans.Where(loan => loan.UserId == user.Id).ToListAsync();
            var books = await _context.Books.ToListAsync();

            // list of all ID's of books we loaned
            var loanBookIds = new List<int>();
            foreach (var loan in loans)
            {
                loanBookIds.Add(loan.ItemId);
            }

            // list of all the book objects that the user has loaned
            var myBooks = books.Where(book => loanBookIds.Contains(book.Id));

            // zip is a sort of join between two lists. taking every element of both list and turning them into one element
            // in this case turning loanbookids and mybooks into one list of reservationviewmodels.
            var loanViewModels = myBooks.Zip(loans, (book, loan) => new LoanViewModel(loan, book));
            return loanViewModels;
        }
        public async Task<IEnumerable<ReservationViewModel>> GetReservationViewModels(IdentityUser user)
        {
            //get list of only users' reservations and all books
            var reservations = await _context.Reservations.Where(x => x.UserId == user.Id).ToListAsync();
            var books = await _context.Books.ToListAsync();
            var reservationBookIds = new List<int>();
            foreach (var reservation in reservations)
            {
                reservationBookIds.Add(reservation.ItemId);
            }

            var myBooks = books.Where(book => reservationBookIds.Contains(book.Id));

            var reservationViewModels = myBooks.Zip(reservations, (book, reservation) => new ReservationViewModel(reservation, book));
            return reservationViewModels;
        }
    }

    public class IndexViewModel
    {
        public IEnumerable<Reservation> Reservations { get; set; }
        public IEnumerable<Loan> Loans { get; set; }

        public IndexViewModel(IEnumerable<Reservation> reservationViewModel, IEnumerable<Loan> loanViewModel)
        {
            Reservations = reservationViewModel;
            Loans = loanViewModel;
        }
    }

    public class ReservationViewModel
    {
        public Reservation Reservation { get; set; }
        public Book Book { get; set; }

        public ReservationViewModel(Reservation reservation, Book book)
        {
            Reservation = reservation;
            Book = book;
        }
    }

    public class LoanViewModel
    {
        public Loan Loan { get; set; }
        public Book Book { get; set; }

        public LoanViewModel(Loan loan, Book book)
        {
            Loan = loan;
            Book = book;
        }
    }

    // Use a viewmodel because we can only send one object to the view.
    // This way we can send multiple lists because they are saved in this
    // one ViewModel object.
    public class MyPageViewModel
    {
        public IEnumerable<ReservationViewModel> Reservations { get; set; }
        public IEnumerable<LoanViewModel> Loans { get; set; }

        public MyPageViewModel(IEnumerable<ReservationViewModel> reservationViewModel, IEnumerable<LoanViewModel> loanViewModel)
        {
            Reservations = reservationViewModel;
            Loans = loanViewModel;
        }
    }
}
