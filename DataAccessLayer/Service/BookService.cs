using BooksLibrary.Models;
using DataAccessLayer.DTO;
using Utilites;

namespace DataAccessLayer.Service
{
    public class BookService: IBookService
    {
        private List<Book> _books { get; }
        private List<string> _book { get; }
        private readonly IDataAccess _dataAccess;
        public BookService (IDataAccess dataAccess)
        {
            _books = new List<Book>();  
            _books = CreateBooks();
            _book = new();          
            _dataAccess = dataAccess;
            _dataAccess.WriteToFile(@"C:\Users\Admin\source\repos\.ASPNET\Modul_2_3\WebApiBook\DataAccessLayer\Data.txt");
            
        }      

        private Book CreateBook(int id)
        {
            
            return new Book {Id= id,Author = RandomService.RandomString(),Title = RandomService.RandomString(),Publisher = RandomService.RandomString(),Style = RandomService.RandomString(),PublishYear = RandomService.RandomNumber() };
        }

        private List<Book> CreateBooks()
        {
            for (int i = 0; i < 5; i++)
            {
                _books.Add(CreateBook(i));
            }
            return _books; 
        }

        public List<Book> GetBooks ()
        {
            return _books;
        }

        public Book GetBook(int id)
        {
            return CreateBook(id);
        }

        public void UpLoad(string path)
        {
            using StreamReader reader = new StreamReader(path);
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                _book.Add(line);
            }
        }
    }
}
