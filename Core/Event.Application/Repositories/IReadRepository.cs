using Event.Domain.Comman;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
namespace Event.Application.Repositories
{
    public interface IReadRepository<T> where T :class,IBaseEntity,new()
    {
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null,
            Func<IQueryable<T>, IIncludableQueryable<T,object>>? include = null,
            Func<IQueryable<T> ,IOrderedQueryable<T>>? orderBy = null,
            bool enableTracking = false);
        Task<IList<T>> GetAllPagingAsync(Expression<Func<T, bool>>? predicate = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            bool enableTracking = false,
            int currentPage = 1,
            int pageSize = 5);

        Task<T> GetAsync(Expression<Func<T, bool>> predicate,
           Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
           bool enableTracking = false);

        IQueryable<T> Find(Expression<Func<T, bool>> predicate,bool enableTracking = false);

        Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null);
    }
}
