using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TraskiladaWebAPI.Models;

namespace TraskiladaWebAPI.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseModel
    {
        private readonly DbSet<T> _dbSet;

        public GenericRepository(DbSet<T> dbSet)
        {
            _dbSet = dbSet;
        }

        public Task<T> FindAsync(params object[] keyValues) => _dbSet.FindAsync(keyValues);

        public Task<List<T>> GetAllAsync(CancellationToken cancellationToken) => _dbSet.ToListAsync(cancellationToken);

        public Task<List<T>> FindBy(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken) => _dbSet
            .Where(predicate)
            .ToListAsync(cancellationToken: cancellationToken);

        public Task<T> SingleAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken) => _dbSet
            .SingleAsync(predicate, cancellationToken);

        public Task<EntityEntry<T>> AddAsync(T entity,
            CancellationToken cancellationToken = new CancellationToken()) => _dbSet.AddAsync(entity, cancellationToken);

        public EntityEntry<T> Remove(T entity) => _dbSet.Remove(entity);

        public EntityEntry<T> RemoveById(Guid id) => _dbSet.Remove(_dbSet.Find(id));

        public EntityEntry<T> Update(T entity) => _dbSet.Update(entity);
    }
}