using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repository.Base
{
    public abstract class GenericRepository<TEntity, TContext>
        where TEntity : class
        where TContext : DbContext
    {
        protected readonly TContext _context;

        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(TContext context)
        {
            _dbSet = context.Set<TEntity>();
            _context = context;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbSet;
        }

        public virtual void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public virtual void MassDelete(List<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public virtual void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void AddRange(List<TEntity> entities)
        {
            _dbSet.AddRange(entities);
        }
    }
}
