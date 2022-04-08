using BooksLibrary.Models;

namespace DataAccessLayer.Service
{
    public interface IBookService
    {       
        List<Book> GetBooks();
        Book GetBook (int id);
        List<Book> FilterBooks(string SearchText);
        Book Update(Book book);
        void Add(Book book);
        void Delete(int id);
        
    }
}
