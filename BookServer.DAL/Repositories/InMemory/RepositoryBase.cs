using BookServer.DAL.Models;
using BookServer.DAL.Repositories.Interfaces;

namespace BookServer.DAL.Repositories.InMemory;

public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : EntityBase
{
}
