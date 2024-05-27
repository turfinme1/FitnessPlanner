using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Data.Models;

namespace FitnessPlanner.Data.Repositories
{
    /// <summary>
    /// Repository class for handling data operations related to goals.
    /// </summary>
    /// <param name="context">The database context to be used by the repository.</param>
    public sealed class GoalRepository(ApplicationDbContext context) : Repository<Goal>(context), IGoalRepository
    {
    }
}
