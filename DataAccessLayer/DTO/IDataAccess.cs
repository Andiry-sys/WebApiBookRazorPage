
using BooksLibrary.Models;

namespace DataAccessLayer.DTO
{
    public interface IDataAccess
    {
        IEnumerable<Book> Read ();
        void WriteToFile(string path);
    }
}
