using HotChocolateSimpleSchema.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HotChocolateSimpleSchema.Repository
{
    public class GenericRepository<TKey, TEntity> : IGenericRepository<TKey, TEntity>
        where TEntity : BaseEntity<TKey>
    {
        public DbSet<TEntity> DbSet { get; set; }
        public Context.MyDbContext Context { get; private set; }


        public GenericRepository(Context.MyDbContext context)
        {
            Context = context;
            DbSet = Context.Set<TEntity>();
        }

        public virtual async Task<TEntity> GetAsync(TKey id)
        {
            return await DbSet.FindAsync(id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public async Task<IReadOnlyDictionary<TKey, TEntity>> GetAllByIDsAsync(IReadOnlyCollection<TKey> ids, CancellationToken cancellationToken)
        {

            var result = await DbSet.Where(x => ids.Contains(x.ID)).ToListAsync();

            return result.ToDictionary(t => t.ID);
        }

        public async Task<ILookup<TKey, TEntity>> GetAllByIDAsync(IReadOnlyCollection<TKey> ids, CancellationToken cancellationToken)
        {
            var result = await DbSet.Where(x => ids.Contains(x.ID)).ToListAsync();
                
            return result.ToLookup(r => r.ID);
        }
    }
}
