using FitnessPlanner.Data.Models;

namespace FitnessPlanner.Data.Contracts
{
    /// <summary>
    /// Interface for the workout plan repository, defining methods for retrieving workout plans with related entities.
    /// </summary>
    public interface IWorkoutPlanRepository : IRepository<WorkoutPlan>
    {
        /// <summary>
        /// Retrieves all workout plans along with their related entities asynchronously.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation. 
        /// The task result contains an enumerable collection of <see cref="WorkoutPlan"/> objects with their related entities.
        /// </returns>
        Task<IEnumerable<WorkoutPlan>> GetAllWithRelatedEntitiesAsync();

        /// <summary>
        /// Retrieves a <see cref="WorkoutPlan"/> by its ID along with its related entities asynchronously.
        /// </summary>
        /// <param name="id">The ID of the workout plan to retrieve.</param>
        /// <param name="isTracked">Indicates whether the entity should be tracked by the context.</param>
        /// <returns>
        /// A task that represents the asynchronous operation. 
        /// The task result contains the <see cref="WorkoutPlan"/> with its related entities, or null if no workout plan with the specified ID is found.
        /// </returns>
        Task<WorkoutPlan?> GetByIdWithRelatedEntitiesAsync(int id, bool isTracked = false);
    }
}
