using BookServer.BLL.Models;

namespace BookServer.BLL.Services.Interfaces;

public interface IBookService
{
    IEnumerable<Book> GetAll();
    IEnumerable<Book> GetRange(int start, int end);
}
