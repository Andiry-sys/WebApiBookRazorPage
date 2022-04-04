using BooksLibrary.Models;
using DataAccessLayer.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApiBook.Pages
{
    public class SelectedBookModel : PageModel
    {
        private readonly IBookService _bookService;
        private readonly ILogger<Book> _logger;

       

        private  Book _book = new();       

        [BindProperty(SupportsGet = true)]
        public int Id { get;  set; }
        public string? Title { get => _book.Title;  }
        public string? Author { get => _book.Author; }
        public string? Style { get => _book.Style;  }
        public string? Publisher { get => _book.Publisher; }
        public int? PublishYear { get => _book.PublishYear;  }

        public SelectedBookModel(ILogger<Book> logger, IBookService bookService)
        {            
            _logger = logger;
            _bookService = bookService;            
        }

        
        public void OnGet(int id)
        {
            Id = id;
            _book = _bookService.GetBook(id);
        }
    }
}
