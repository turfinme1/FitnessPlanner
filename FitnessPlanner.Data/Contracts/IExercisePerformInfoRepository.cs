using FitnessPlanner.Data.Models;

namespace FitnessPlanner.Data.Contracts
{
    /// <summary>
    /// Interface for the exercise performance information repository, defining methods for managing <see cref="ExercisePerformInfo"/> entities.
    /// </summary>
    public interface IExercisePerformInfoRepository : IRepository<ExercisePerformInfo>
    {
    }
}
