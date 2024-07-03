using System.Linq.Expressions;
using FitnessPlanner.Data.Contracts;
using Microsoft.EntityFrameworkCore;

namespace FitnessPlanner.Data.Repositories
{
    /// <summary>
    /// Abstract base class for repositories, providing basic CRUD operations for entities.
    /// </summary>
    /// <typeparam name="TEntity">The type of entity managed by the repository.</typeparam>
    /// <param name="context">The database context to be used by the repository.</param>
    public abstract class Repository<TEntity>(ApplicationDbContext context) : IRepository<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// The database set for the entity managed by the repository.
        /// </summary>
        protected readonly DbSet<TEntity> DbSet = context.Set<TEntity>();

        /// <summary>
        /// Retrieves all entities asynchronously.
        /// </summary>
        /// <param name="isTracked">Indicates whether the entities should be tracked by the context.</param>
        /// <returns>
        /// A task that represents the asynchronous operation. 
        /// The task result contains an enumerable collection of entities.
        /// </returns>
        public async Task<IEnumerable<TEntity>> GetAllAsync(bool isTracked = false)
        {
            return isTracked
                ? await DbSet.ToListAsync()
                : await DbSet.AsNoTracking().ToListAsync();
        }

        /// <summary>
        /// Retrieves filtered entities asynchronously based on the provided filter expression.
        /// </summary>
        /// <param name="filter">The filter expression to apply.</param>
        /// <returns>
        /// A task that represents the asynchronous operation. 
        /// The task result contains an enumerable collection of filtered entities.
        /// </returns>
        public async Task<IEnumerable<TEntity>> GetAllFilteredAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await DbSet.AsNoTracking().Where(filter).ToListAsync();
        }

        /// <summary>
        /// Retrieves an entity by its ID asynchronously.
        /// </summary>
        /// <param name="id">The ID of the entity to retrieve.</param>
        /// <returns>
        /// A task that represents the asynchronous operation. 
        /// The task result contains the entity with the specified ID, or null if no entity is found.
        /// </returns>
        public async Task<TEntity?> GetByIdAsync(object id)
        {
            return await DbSet.FindAsync(id);
        }

        /// <summary>
        /// Adds a new entity to the repository.
        /// </summary>
        /// <param name="entity">The entity to add.</param>
        public void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        /// <summary>
        /// Updates an existing entity in the repository.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        public void Update(TEntity entity)
        {
            DbSet.Update(entity);
        }

        /// <summary>
        /// Removes an entity from the repository.
        /// </summary>
        /// <param name="entity">The entity to remove.</param>
        public void Remove(TEntity entity)
        {
            DbSet.Remove(entity);
        }
    }
}
