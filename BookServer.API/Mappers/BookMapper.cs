using BookServer.API.Models;
using BLLModels = BookServer.BLL.Models;

namespace BookServer.API.Mappers;

public static class BookMapper
{
    public static BLLModels.Book ToBusinessModel(this Book book)
    {
        return new BLLModels.Book
        {
            Id = book.Id,
            Title = book.Title
        };
    }

    public static Book ToViewModel(this BLLModels.Book book)
    {
        return new Book
        {
            Id = book.Id,
            Title = book.Title
        };
    }
}
