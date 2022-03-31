using BooksLibrary.Models;
using DataAccessLayer.Service;


namespace DataAccessLayer.DTO
{
    public class DataAccess : IDataAccess
    {
        //private readonly IBookService _bookService;
        //private List<Book> _books ;  
        public DataAccess(/*IBookService bookService*/)
        {
            //_bookService = bookService;
            //_books = _bookService.GetBooks();
        }

        public void WriteToFile(string path, List<Book> books)
        {
            using StreamWriter writer = new StreamWriter(path,false);
            foreach (Book it in books)
            {
                writer.WriteLine(it.Id);
                writer.WriteLine(it.Title);
                writer.WriteLine(it.Author);
                writer.WriteLine(it.Style);
                writer.WriteLine(it.Publisher);
                writer.WriteLine(it.PublishYear);
            }
        }

        public IEnumerable<Book> Read ()
        {
            return null;
        }
    }
}
