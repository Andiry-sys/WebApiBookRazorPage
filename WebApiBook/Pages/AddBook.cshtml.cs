using BooksLibrary.Models;
using DataAccessLayer.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApiBook.Pages
{
    public class AddBookModel : PageModel
    {
        private readonly IBookService _bookService;
        private readonly ILogger<Book> _logger;
        private Book _book = new();

        public AddBookModel(IBookService bookService,ILogger<Book> logger)
        {
            _bookService = bookService;
            _logger = logger;
        }

        [BindProperty(SupportsGet = true)]
        public int Id { get ; set; }
        public string? Title { get => _book.Title; set => _book.Title = value; }
        public string? Author { get => _book.Author; set => _book.Author = value; }
        public string? Style { get => _book.Style; set => _book.Style = value; }
        public string? Publisher { get => _book.Publisher; set => _book.Publisher = value; }
        public int? PublishYear { get => _book.PublishYear; set => _book.PublishYear = value; }
        
        public IActionResult OnPostAdd(Book book)
        {
            _bookService.Add(book);
            return RedirectToPage("/Book");
        }
    }
}
