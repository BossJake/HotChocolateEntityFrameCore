using HotChocolateSimpleSchema.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HotChocolateSimpleSchema.Repository
{
    public interface IGenericRepository<TKey, TEntity> where TEntity : BaseEntity<TKey>
    {
        Task<TEntity> GetAsync(TKey id);

        IQueryable<TEntity> GetAll();

        Task<IReadOnlyDictionary<TKey, TEntity>> GetAllByIDsAsync(IReadOnlyCollection<TKey> ids, CancellationToken cancellationToken);
        
        Task<ILookup<TKey, TEntity>> GetAllByIDAsync(IReadOnlyCollection<TKey> ids, CancellationToken cancellationToken);

    }
}
