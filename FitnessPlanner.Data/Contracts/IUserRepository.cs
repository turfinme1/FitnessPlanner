using FitnessPlanner.Data.Models;

namespace FitnessPlanner.Data.Contracts
{
    /// <summary>
    /// Interface for the user repository, defining methods for managing <see cref="User"/> entities.
    /// </summary>
    public interface IUserRepository : IRepository<User>
    {
        /// <summary>
        /// Retrieves all users along with their related entities asynchronously.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation. 
        /// The task result contains an enumerable collection of <see cref="User"/> objects with their related entities.
        /// </returns>
        Task<IEnumerable<User>> GetAllWithRelatedEntitiesAsync();

        /// <summary>
        /// Retrieves a <see cref="User"/> by its ID along with its related entities asynchronously.
        /// </summary>
        /// <param name="id">The ID of the user to retrieve.</param>
        /// <returns>
        /// A task that represents the asynchronous operation. 
        /// The task result contains the <see cref="User"/> with its related entities, or null if no user with the specified ID is found.
        /// </returns>
        Task<User?> GetByIdWithRelatedEntitiesAsync(string id);
    }
}
