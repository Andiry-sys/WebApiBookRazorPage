using BooksLibrary.Models;
using DataAccessLayer.Service;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApiBook.Pages
{
    public class SelectedBookModel : PageModel
    {
        private readonly IBookService _bookService;
        private readonly ILogger<Book> _logger;
        private readonly Book _book = new();

        public string? Title { get => _book.Title;  }
        public string? Author { get => _book.Author; }
        public string? Style { get => _book.Style;  }
        public string? Publisher { get => _book.Publisher; }
        public int? PublishYear { get => _book.PublishYear;  }

        public SelectedBookModel(ILogger<Book> logger, IBookService bookService)
        {            
            _logger = logger;
            _bookService = bookService;
            _book = _bookService.GetBook(_book.Id);
        }

        public void OnGet(int id)
        {
        }
    }
}
