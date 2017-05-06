using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TraskiladaWebAPI.Models;

namespace TraskiladaWebAPI.Repositories
{
    public interface IGenericRepository<T> where T : BaseModel
    {
        Task<T> FindAsync(params object[] keyValues);
        Task<List<T>> GetAllAsync(CancellationToken cancellationToken);
        Task<List<T>> FindBy(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);
        Task<T> SingleAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);

        Task<EntityEntry<T>> AddAsync(T entity,
            CancellationToken cancellationToken = new CancellationToken());

        EntityEntry<T> Remove(T entity);
        EntityEntry<T> RemoveById(int id);
        EntityEntry<T> Update(T entity);
    }
}