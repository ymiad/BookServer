using BookServer.BLL.Models;
using BookServer.BLL.Services.Interfaces;
using BookServer.BLL.Extensions.Mappers;
using BookServer.DAL.Repositories.Interfaces;
using DALModels = BookServer.DAL.Models;

namespace BookServer.BLL.Services;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public IEnumerable<Book> GetAll()
    {
        IEnumerable<DALModels.Book> books = _bookRepository.GetAll();

        return books.Select(x => x.ToBusinessModel());
    }

    public IEnumerable<Book> GetRange(int start, int end)
    {
        (int Start, int End, bool Reverse) = PrepareRangeArgs(start, end);

        IEnumerable<DALModels.Book> books = Start != End && End == -1
            ? _bookRepository.GetRange(Start)
            : _bookRepository.GetRange(Start, End);

        IEnumerable<Book> result = books.Select(x => x.ToBusinessModel());

        return Reverse
            ? result.Reverse()
            : result;
    }

    private static (int Start, int End, bool Reverse) PrepareRangeArgs(int start, int end)
    {
        return start > end && end != -1
            ? (end, start, true)
            : (start, end, false);
    }
}
