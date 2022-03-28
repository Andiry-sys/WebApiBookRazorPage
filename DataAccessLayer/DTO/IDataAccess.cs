
using BooksLibrary.Models;

namespace DataAccessLayer.DTO
{
    internal interface IDataAccess
    {
        IEnumerable<Book> Read ();
    }
}
