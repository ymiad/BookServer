using BookServer.BLL.Services;
using BookServer.BLL.Services.Interfaces;
using BookServer.DAL.Repositories.InMemory;
using BookServer.DAL.Repositories.Interfaces;

namespace BookServer.API.Extensions;

public static class ServicesConfiguration
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddTransient<IBookRepository, BookRepository>();

        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddTransient<IBookService, BookService>();

        return services;
    }
}
