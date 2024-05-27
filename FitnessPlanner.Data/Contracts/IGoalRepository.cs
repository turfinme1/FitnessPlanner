using FitnessPlanner.Data.Models;

namespace FitnessPlanner.Data.Contracts
{
    /// <summary>
    /// Interface for the goal repository, defining methods for managing <see cref="Goal"/> entities.
    /// </summary>
    public interface IGoalRepository : IRepository<Goal>
    {
    }
}
