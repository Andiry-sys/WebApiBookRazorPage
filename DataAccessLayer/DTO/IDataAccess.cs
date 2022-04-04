
using BooksLibrary.Models;

namespace DataAccessLayer.DTO
{
    public interface IDataAccess
    {
       
        void WriteToFile(string path, List<Book> books);
        List<Book> Read(string path);
        
    }
}
