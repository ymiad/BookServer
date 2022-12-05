using BookServer.DAL.Generators;
using BookServer.DAL.Models;
using BookServer.DAL.Repositories.Interfaces;

namespace BookServer.DAL.Repositories.InMemory;

public class BookRepository : IBookRepository
{
    private readonly List<Book> _books;

    public BookRepository()
    {
        _books = BookGenerator.GenerateBooks(100);
    }

    public IEnumerable<Book> GetAll()
    {
        return _books;
    }

    public IEnumerable<Book> GetRange(int start, int end)
    {
        if (start > _books.Count || end > _books.Count)
        {
            throw new ArgumentException("Start and End numbers can not be greater than count of books");
        }

        return _books.GetRange(start, end - start + 1);
    }

    public IEnumerable<Book> GetRange(int start)
    {
        if (start > _books.Count)
        {
            throw new ArgumentException("Start number can not be greater than count of books");
        }

        return _books.Skip(start);
    }
}
