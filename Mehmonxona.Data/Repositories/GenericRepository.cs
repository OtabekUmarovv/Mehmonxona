
using Mehmonxona.Data.Contexts;
using Mehmonxona.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mehmonxona.Data.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        MehmonxonaDbContext dbContext;

        public GenericRepository()
        {
            dbContext = new MehmonxonaDbContext();
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            TEntity source = dbContext.Set<TEntity>().Add(entity).Entity;
            await dbContext.SaveChangesAsync();
            return source;
        }

        public async Task<bool> DeleteAsync(Expression<Func<TEntity, bool>> expression)
        {
            TEntity entity = await GetAsync(expression);

            if (entity is null)
                return false;

            dbContext.Set<TEntity>().Remove(entity);
            await dbContext.SaveChangesAsync();

            return true;
        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> expression = null)
            => expression is null ? dbContext.Set<TEntity>() : dbContext.Set<TEntity>().Where(expression);

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
            => await dbContext.Set<TEntity>().FirstOrDefaultAsync(expression);

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            TEntity source = dbContext.Update(entity).Entity;
            await dbContext.SaveChangesAsync();

            return source;
        }
    }
}
