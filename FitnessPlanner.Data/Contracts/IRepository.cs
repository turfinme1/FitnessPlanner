using System.Linq.Expressions;

namespace FitnessPlanner.Data.Contracts
{
    /// <summary>
    /// Interface for generic repository, defining basic CRUD operations for entities.
    /// </summary>
    /// <typeparam name="TEntity">The type of entity managed by the repository.</typeparam>
    public interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Retrieves all entities asynchronously.
        /// </summary>
        /// <param name="isTracked">Indicates whether the entities should be tracked by the context.</param>
        /// <returns>
        /// A task that represents the asynchronous operation. 
        /// The task result contains an enumerable collection of entities.
        /// </returns>
        Task<IEnumerable<TEntity>> GetAllAsync(bool isTracked = false);

        /// <summary>
        /// Retrieves filtered entities asynchronously based on the provided filter expression.
        /// </summary>
        /// <param name="filter">The filter expression to apply.</param>
        /// <returns>
        /// A task that represents the asynchronous operation. 
        /// The task result contains an enumerable collection of filtered entities.
        /// </returns>
        Task<IEnumerable<TEntity>> GetAllFilteredAsync(Expression<Func<TEntity, bool>> filter);

        /// <summary>
        /// Retrieves an entity by its ID asynchronously.
        /// </summary>
        /// <param name="id">The ID of the entity to retrieve.</param>
        /// <returns>
        /// A task that represents the asynchronous operation. 
        /// The task result contains the entity with the specified ID, or null if no entity is found.
        /// </returns>
        Task<TEntity?> GetByIdAsync(object id);

        /// <summary>
        /// Adds a new entity to the repository.
        /// </summary>
        /// <param name="entity">The entity to add.</param>
        void Add(TEntity entity);

        /// <summary>
        /// Updates an existing entity in the repository.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        void Update(TEntity entity);

        /// <summary>
        /// Removes an entity from the repository.
        /// </summary>
        /// <param name="entity">The entity to remove.</param>
        void Remove(TEntity entity);
    }
}
