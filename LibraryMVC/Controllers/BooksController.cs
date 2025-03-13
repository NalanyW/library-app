using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using NuGet.Versioning;
using SoftwareDevelopment2.Data;
using SoftwareDevelopment2.Models;
using SoftwareDevelopment2.ViewModels;

namespace SoftwareDevelopment2.Controllers
{

    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Books
        public async Task<IActionResult> Index()
        {

            return _context.Books != null ?
                View(await GetBookViewModels()) :
                Problem("Entity set 'ApplicationDbContext.Book'  is null.");
        }

        // GET: Show form Books
        public async Task<IActionResult> ShowSearchForm()
        {
            return View(new SearchViewModel { });
        }

        // POST: form Books
        public async Task<IActionResult> ShowSearchResult(SearchViewModel search)
        {
            if (search.SearchPhrase == null)
                return NotFound();

            var bookViewModels = await GetBookViewModels();

            switch (search.SearchOn)
            {
                case SearchOn.Title:
                    return View("Index", bookViewModels.Where(book => book.Book.Title.ToUpper().Contains(search.SearchPhrase.ToUpper())));
                case SearchOn.Author:

                    return View("Index", bookViewModels.Where(book => book.Author.Name.ToUpper().Contains(search.SearchPhrase.ToUpper())));
                case SearchOn.Location:

                    return View("Index", bookViewModels.Where(book => book.Location.Name.ToUpper().Contains(search.SearchPhrase.ToUpper())));
            }

            return View("Index", bookViewModels);
        }

        // GET: Books/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var bookViewModel = await GetBookViewModel(id);

            if (bookViewModel == null)
            {
                return NotFound();
            }

            return View(bookViewModel);
        }

        // [] = Decorator
        // unless you've been logged in
        [Authorize]

        // GET: Books/Create
        [Authorize(Roles = "Employee, Admin")]
        public async Task<IActionResult> Create()
        {
            var createBookViewModel = new CreateBookViewModel
            {
                Book = new Book { },
                Author = await _context.Authors.ToListAsync(),
                Location = await _context.Locations.ToListAsync(),
                AuthorChoice = new Author { },
                LocationChoice = new Models.Location { }
            };

            return View(createBookViewModel);
        }

        // POST: Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Employee, Admin")]
        public async Task<IActionResult> Create([Bind("Book, AuthorChoice, LocationChoice")] CreateBookViewModel bookViewModel)
        {
            var book = bookViewModel.Book;
            if (ModelState.IsValid)
            {

                book.AuthorId = bookViewModel.AuthorChoice.Id;
                book.LocationId = bookViewModel.LocationChoice.Id;
                _context.Add(book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        // GET: Books/Edit/5
        [Authorize(Roles = "Employee, Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            var bookViewModel = await GetCreateBookViewModel(id);

            if (bookViewModel == null)
            {
                return NotFound();
            }

            return View(bookViewModel);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Employee, Admin")]
        public async Task<IActionResult> Edit(int id, [Bind("Book, AuthorChoice, LocationChoice")] CreateBookViewModel bookViewModel)
        {
            if (id != bookViewModel.Book.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var book = bookViewModel.Book;
                    book.AuthorId = bookViewModel.AuthorChoice.Id;
                    book.LocationId = bookViewModel.LocationChoice.Id;
                    _context.Update(bookViewModel.Book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(bookViewModel.Book.Id))
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
            return View(bookViewModel);
        }

        // GET: Books/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Books == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Books == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Book'  is null.");
            }
            var book = await _context.Books.FindAsync(id);
            if (book != null)
            {
                _context.Books.Remove(book);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
            return (_context.Locations?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        private async Task<IEnumerable<BookViewModel>> GetBookViewModels()
        {
            var books = await _context.Books.ToListAsync();

            var authors = await _context.Authors.ToListAsync();
            var locations = await _context.Locations.ToListAsync();

            var bookViewModels = new List<BookViewModel>();

            //Find the correspond authors and locations for each book
            foreach (var book in books)
            {
                var author = await _context.Authors.FirstOrDefaultAsync(author => author.Id == book.AuthorId);
                var location = await _context.Locations.FirstOrDefaultAsync(location => location.Id == book.LocationId);
                bookViewModels.Add(new BookViewModel
                {
                    Book = book,
                    Author = author,
                    Location = location,
                });
            }

            return bookViewModels;
        }
        private async Task<BookViewModel?> GetBookViewModel(int? id)
        {
            if (id == null || _context.Books == null)
            {
                return null;
            }
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return null;
            }
            var author = await _context.Authors.FindAsync(book.AuthorId);
            var location = await _context.Locations.FindAsync(book.LocationId);
            if (author == null || location == null)
            {
                return null;
            }

            var bookViewModel = new BookViewModel
            {
                Book = book,
                Author = author,
                Location = location
            };
            return bookViewModel;
        }

        private async Task<CreateBookViewModel?> GetCreateBookViewModel(int? id)
        {
            if (id == null || _context.Books == null)
            {
                return null;
            }
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return null;
            }
            var author = await _context.Authors.FindAsync(book.AuthorId);
            var location = await _context.Locations.FindAsync(book.LocationId);
            if (author == null || location == null)
            {
                return null;
            }

            var bookViewModel = new CreateBookViewModel
            {
                Book = book,
                Author = await _context.Authors.ToListAsync(),
                Location = await _context.Locations.ToListAsync(),
                AuthorChoice = author,
                LocationChoice = location
            };
            return bookViewModel;
        }


    }

}
