
using BooksLibrary.Models;

namespace DataAccessLayer.DTO
{
    public interface IDataAccess
    {
       
        void WriteToFile(List<Book> books);
        List<Book> Read();
        void AddBook(Book book);

    }
}
