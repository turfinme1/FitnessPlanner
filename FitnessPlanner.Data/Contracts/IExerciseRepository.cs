using FitnessPlanner.Data.Models;

namespace FitnessPlanner.Data.Contracts
{
    /// <summary>
    /// Interface for the exercise repository, defining methods for managing <see cref="Exercise"/> entities.
    /// </summary>
    public interface IExerciseRepository : IRepository<Exercise>
    {
        /// <summary>
        /// Retrieves all exercises along with their related entities asynchronously.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation. 
        /// The task result contains an enumerable collection of <see cref="Exercise"/> objects with their related entities.
        /// </returns>
        Task<IEnumerable<Exercise>> GetAllWithRelatedEntitiesAsync();

        /// <summary>
        /// Retrieves an <see cref="Exercise"/> by its ID along with its related entities asynchronously.
        /// </summary>
        /// <param name="id">The ID of the exercise to retrieve.</param>
        /// <param name="isTracked">Indicates whether the entity should be tracked by the context.</param>
        /// <returns>
        /// A task that represents the asynchronous operation. 
        /// The task result contains the <see cref="Exercise"/> with its related entities, or null if no exercise with the specified ID is found.
        /// </returns>
        Task<Exercise?> GetByIdWithRelatedEntitiesAsync(int id, bool isTracked = false);

        /// <summary>
        /// Retrieves a collection of <see cref="Exercise"/> by their muscle group along with their related entities asynchronously.
        /// </summary>
        /// <param name="muscleGroupName">The name of the muscle group</param>
        /// <returns>
        /// A task that represents the asynchronous operation. 
        /// The task result contains an enumerable collection of <see cref="Exercise"/> objects with their related entities, or null if no exercises with the specified muscle group name are found.
        /// </returns>
        Task<IEnumerable<Exercise>> GetByMuscleGroupWithRelatedEntitiesAsync(string muscleGroupName);
    }
}
