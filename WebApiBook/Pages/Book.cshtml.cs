using BooksLibrary.Models;
using DataAccessLayer.Service;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace WebApiBook.Pages
{
    public class BookModel : PageModel
    {
        private readonly IBookService _bookService;
        private readonly ILogger<BookModel> _logger;
        public List<Book> Books { get; set; }

        public BookModel( ILogger<BookModel> logger,IBookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
            Books = _bookService.GetBooks();
        }
        public void OnGet()
        {
        }

        public void OnPost(string text)
        {
            Books = _bookService.FilterBooks(text);
        }
    }
}
