using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        #region GetAll
        public IQueryable<TEntity> GetAll()
        {
            return _dbSet;
        }

        public IQueryable<TEntity> GetAllReadOnly()
        {
            return _dbSet.AsNoTracking();
        }
        #endregion

        #region GetById
        public virtual async Task<TEntity> GetByIdAsync(int id) => await _dbSet.FindAsync(id);

        public virtual async Task<TEntity> GetByIdAsync(long id) => await _dbSet.FindAsync(id);
        #endregion

        #region Add
        public virtual void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void MassAdd(List<TEntity> entities)
        {
            _dbSet.AddRange(entities);
        }
        #endregion

        #region Edit
        public void Edit(TEntity entity, string propertyName)
        {
            _context.Entry(entity).Property(propertyName).IsModified = true;
        }

        public void Edit(TEntity entity, string[] propertiesName)
        {
            if (propertiesName != null && propertiesName.Any())
            {
                foreach (var property in propertiesName)
                    Edit(entity, property);
            }
        }
        #endregion

        #region Delete
        public virtual void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public virtual void MassDelete(List<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }
        public virtual void MassDelete(ICollection<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }
        public virtual void MassDelete(IQueryable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }
        #endregion
    }
}
