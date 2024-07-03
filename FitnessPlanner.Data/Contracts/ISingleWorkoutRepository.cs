using FitnessPlanner.Data.Models;

namespace FitnessPlanner.Data.Contracts
{
    /// <summary>
    /// Interface for the single workout repository, defining methods for managing <see cref="SingleWorkout"/> entities.
    /// </summary>
    public interface ISingleWorkoutRepository : IRepository<SingleWorkout>
    {
    }
}
