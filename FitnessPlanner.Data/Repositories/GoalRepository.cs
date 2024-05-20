using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Data.Models;

namespace FitnessPlanner.Data.Repositories
{
    public sealed class GoalRepository(ApplicationDbContext context) : Repository<Goal>(context), IGoalRepository
    {
    }
}
