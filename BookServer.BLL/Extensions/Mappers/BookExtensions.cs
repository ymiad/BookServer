using BookServer.BLL.Models;
using DALModels = BookServer.DAL.Models;

namespace BookServer.BLL.Extensions.Mappers;

public static class BookExtensions
{
    public static Book ToBusinessModel(this DALModels.Book book)
    {
        return new Book
        {
            Id = book.Id,
            Title = book.Title
        };
    }

    public static DALModels.Book ToDataModel(this Book book)
    {
        return new DALModels.Book
        {
            Id = book.Id,
            Title = book.Title
        };
    }
}
