using BooksLibrary.Models;
using DataAccessLayer.DTO;
using Microsoft.Extensions.DependencyInjection;
using Utilites;

namespace DataAccessLayer.Service
{
    public static class MyServiceCollectionExtensions
    {
        public static IServiceCollection AddMyServiceDependencies(this IServiceCollection services)
        {
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IDataAccess, DataAccess>();
            return services;
        }
    }
    public class BookService: IBookService
    {
        private List<Book> _books = new List<Book>();
        private readonly IDataAccess _dataAccess;
        public BookService (IDataAccess dataAccess)
        {        
            _dataAccess = dataAccess;            
            _books = _dataAccess.Read();           
        }      
        
        public List<Book> GetBooks ()
        {
            return _books;
        }

        public Book GetBook(int id)
        {
            return _books.FirstOrDefault(x => x.Id == id);
        }

        public List<Book> FilterBooks(string SearchText)
        {
            return _books.Where(x => x.Author.Contains(SearchText) || x.Title.Contains(SearchText) || x.Publisher.Contains(SearchText) || x.Style.Contains(SearchText) || x.PublishYear.ToString().Contains(SearchText)).ToList();
        }

        public Book Update(Book book)
        {
            
           var bookToUpdate = _books.FirstOrDefault(x => x.Id == book.Id);
            
            if (bookToUpdate != null)
            {
                bookToUpdate.Author = book.Author;
                bookToUpdate.Title = book.Title;
                bookToUpdate.Publisher = book.Publisher;
                bookToUpdate.Style = book.Style;
                bookToUpdate.PublishYear = book.PublishYear;
                              
            }
            return bookToUpdate;
            
        }

        public void Add(Book book)
        {
            _dataAccess.AddBook(book);
        }

        public void Delete(int id)
        {
            var bookToDelete = _books.FirstOrDefault(x => x.Id == id);
            if (bookToDelete != null)
            {
                _books.Remove(bookToDelete);
                _dataAccess.WriteToFile(_books);
            }
        }        
    }
}
