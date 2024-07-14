using Event.Application.Repositories;
using Event.Domain.Comman;

namespace Event.Application.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IReadRepository<T> GetReadRepository<T>() where T : class,IBaseEntity,new();
        IWriteRepository<T> GetWriteRepository<T>() where T : class,IBaseEntity,new();
        Task<int> SaveAsync();
        int Save();

    }
}
