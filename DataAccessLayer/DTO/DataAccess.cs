using BooksLibrary.Models;
using DataAccessLayer.Service;


namespace DataAccessLayer.DTO
{
    public class DataAccess : IDataAccess
    {
        List<string> list = new List<string>();
        List<Book> _books = new List<Book>();
        public DataAccess()
        {
            
        }

        public void WriteToFile(string path, List<Book> books)
        {
            using StreamWriter writer = new StreamWriter(path,true);
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

        

        public List<Book> Read(string path)
        {           
            using StreamReader reader = new StreamReader(path);
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
    }
}
