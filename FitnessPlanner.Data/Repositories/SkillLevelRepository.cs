using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Data.Models;

namespace FitnessPlanner.Data.Repositories
{
    /// <summary>
    /// Repository class for handling data operations related to skill levels.
    /// </summary>
    /// <param name="context">The database context to be used by the repository.</param>
    public sealed class SkillLevelRepository(ApplicationDbContext context) : Repository<SkillLevel>(context), ISkillLevelRepository
    {
    }
}
