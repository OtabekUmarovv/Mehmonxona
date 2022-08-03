
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
        protected readonly  MehmonxonaDbContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public GenericRepository(MehmonxonaDbContext dbContext)
        {
            this._context = dbContext;
            this._dbSet = _context.Set<TEntity>();
        }



        public async Task<TEntity> CreateAsync(TEntity entity)
            => (await _dbSet.AddAsync(entity)).Entity;

        public async Task<bool> DeleteAsync(Expression<Func<TEntity, bool>> expression)
        {
            var entity = await _dbSet.FirstOrDefaultAsync(expression);

            if (entity is null)
                return false;

            _dbSet.Remove(entity);

            return true;
        }


        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> expression)
            => expression is null ? _dbSet : _dbSet.Where(expression);


        public Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> expression)
            => _dbSet.FirstOrDefaultAsync(expression);

        public Task SaveChangesAsync() => _context.SaveChangesAsync();

        public void Dispose() => GC.SuppressFinalize(this);

        public TEntity Update(TEntity entity)
            => _dbSet.Update(entity).Entity;
    }
}
