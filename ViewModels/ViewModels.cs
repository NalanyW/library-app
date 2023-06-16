using SoftwareDevelopment2.Controllers;
using SoftwareDevelopment2.Models;

namespace SoftwareDevelopment2.ViewModels
{

    // Use viewmodels because we can only send one object to the view.
    // This way we can send multiple things as a bundle because they 
    // are saved in one ViewModel object.


    // Enum for deciding what to search on when searching for a book
    public enum SearchOn
    {
        Title,
        Author,
        Location
    }

    public class SearchViewModel
    {
        public string? SearchPhrase { get; set; }
        public SearchOn SearchOn { get; set; }
    }

    public class BookViewModel
    {
        public Book? Book { get; set; }
        public Author? Author { get; set; }
        public Location? Location { get; set; }

    }
    public class CreateBookViewModel
    {
        public Book? Book { get; set; }
        public IEnumerable<Author>? Author { get; set; }
        public IEnumerable<Location>? Location { get; set; }
        public Author? AuthorChoice { get; set; }
        public Location? LocationChoice { get; set; }
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

    public class EditUserViewModel
    {
        public string? Id { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public bool IsLocked { get; set; }
        public bool Authorized { get; set; }

        public EditUserViewModel() { }
    }

}
