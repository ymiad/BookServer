using BookServer.DAL.Models;

namespace BookServer.DAL.Generators;

public static class BookGenerator
{
    public static List<Book> GenerateBooks(int count)
    {
        List<Book> books = new();

        for (int i = 1; i <= count; i++)
        {
            books.Add(new Book
            {
                Id = Guid.NewGuid().ToString(),
                Title = $"Book {i}"
            });
        }

        return books;
    }
}
