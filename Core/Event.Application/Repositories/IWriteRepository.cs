using Event.Domain.Comman;

namespace Event.Application.Repositories
{
    public interface IWriteRepository<T> where T : class,IBaseEntity,new()
    {
        Task AddAsync(T entity);
        Task AddRangeAsync(IList<T> entities);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
