
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mehmonxona.Data.IRepositories
{
    public interface IGenericRepository<TEntity>
    {
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression);
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> expression = null);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<bool> DeleteAsync(Expression<Func<TEntity, bool>> expression);
    }
}
