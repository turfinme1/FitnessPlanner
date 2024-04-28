using System.Linq.Expressions;
using FitnessPlanner.Data.Contracts;
using Microsoft.EntityFrameworkCore;

namespace FitnessPlanner.Data.Repositories
{
    public abstract class Repository<TEntity>(ApplicationDbContext context) : IRepository<TEntity>
        where TEntity : class
    {
        //protected readonly ApplicationDbContext DbContext = context;
        protected readonly DbSet<TEntity> DbSet = context.Set<TEntity>();

        public async Task<IEnumerable<TEntity>> GetAllAsync(bool isTracked = false)
        {
            return isTracked
                ? await DbSet.ToListAsync()
                : await DbSet.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllFilteredAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await DbSet.AsNoTracking().Where(filter).ToListAsync();
        }

        public async Task<TEntity?> GetByIdAsync(object id)
        {
            return await DbSet.FindAsync(id);
        }

        public void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
            DbSet.Update(entity);
        }

        public void Remove(TEntity entity)
        {
            DbSet.Remove(entity);
        }
    }
}
