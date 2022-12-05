using BookServer.DAL.Models;

namespace BookServer.DAL.Repositories.Interfaces;

public interface IRepositoryBase<T> where T : EntityBase
{
    // here can be CRUD methods
}
