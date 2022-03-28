using BooksLibrary.Models;

namespace DataAccessLayer.Service
{
    public interface IBookService
    {
        void Upload(string path);
        List<Book> GetBooks();
        void ConvertToBook ();
    }
}
