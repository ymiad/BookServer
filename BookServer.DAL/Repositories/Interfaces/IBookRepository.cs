using BookServer.DAL.Models;

namespace BookServer.DAL.Repositories.Interfaces;

public interface IBookRepository : IRepositoryBase<Book>
{
    IEnumerable<Book> GetAll();
    IEnumerable<Book> GetRange(int start, int end);
    IEnumerable<Book> GetRange(int start);
}
