using BooksLibrary.Models;
using DataAccessLayer.Service;


namespace DataAccessLayer.DTO
{
    internal class DataAccess : IDataAccess
    {
        private readonly IBookService _bookService;
        private List<Book> _books ;  
        public DataAccess(IBookService bookService)
        {
            _bookService = bookService;
            _books = _bookService.GetBooks();
        }
        public IEnumerable<Book> Read ()
        {
            return _books;
        }
    }
}
