using BooksLibrary.Models;

namespace DataAccessLayer.Service
{
    public interface IBookService
    {       
        List<Book> GetBooks();
        Book GetBook (int id);
       
        
    }
}
