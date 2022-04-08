using BooksLibrary.Models;
using DataAccessLayer.Service;



namespace DataAccessLayer.DTO
{
    public class DataAccess : IDataAccess
    {
        private List<string> list = new List<string>();
        private List<Book> _books = new List<Book>();
        private readonly string _path = @"C:\Users\Admin\source\repos\.ASPNET\Modul_2_3\Web2.0\WebApiBook\DataAccessLayer\Data.txt";
        public DataAccess()
        {
            
        }

        public void WriteToFile(List<Book> books)
        {
            using StreamWriter writer = new StreamWriter(_path,false);
            
            
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

        

        public List<Book> Read()
        {           
            using StreamReader reader = new StreamReader(_path);
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                list.Add(line);
            }

            for (int i = 0; i < list.Count; i+=6)
            {
                _books.Add(new Book { Id = int.Parse(list[i]),Title = list[i + 1],Author = list[i + 2],Style = list[i + 3],Publisher = list[i + 4],PublishYear = int.Parse(list[i + 5]) });
            }
            return _books;
        }

        private int GetNewId()
        {
            var newId = _books.Max(x => x.Id) + 1;
            return newId;
        }

        public void AddBook(Book book)
        {
            var bookToUpdate = _books.FirstOrDefault(x => x.Id == book.Id);

            if (bookToUpdate != null)
            {
                bookToUpdate.Id = GetNewId();
                bookToUpdate.Author = book.Author;
                bookToUpdate.Title = book.Title;
                bookToUpdate.Publisher = book.Publisher;
                bookToUpdate.Style = book.Style;
                bookToUpdate.PublishYear = book.PublishYear;
                _books.Add(bookToUpdate);
                WriteToFile(_books);
            }
            
        }
    }
}
