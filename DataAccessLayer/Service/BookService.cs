using BooksLibrary.Models;
using Utilites;

namespace DataAccessLayer.Service
{
    public class BookService: IBookService
    {
        private List<Book> _books { get; }
        public BookService ()
        {
            _books = new List<Book>();  
            _books = CreateBooks();
            
        }

        public void Upload ( string path )
        {
            throw new NotImplementedException();
        }

        private Book CreateBook()
        {
            return new Book { Author = RandomService.RandomString(),Title = RandomService.RandomString(),Publisher = RandomService.RandomString(),Style = RandomService.RandomString(),PublishYear = RandomService.RandomNumber() };
        }

        private List<Book> CreateBooks()
        {
            for (int i = 0; i < 7; i++)
            {
                _books.Add(CreateBook());
            }
            return _books; 
        }

        public List<Book> GetBooks ()
        {
            return _books;
        }

        public void ConvertToBook ()
        {
            throw new NotImplementedException();
        }
    }
}
