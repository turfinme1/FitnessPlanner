using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Data.Models;

namespace FitnessPlanner.Data.Repositories
{
    /// <summary>
    /// Repository class for handling data operations related to exercise performance information.
    /// </summary>
    /// <param name="context">The database context to be used by the repository.</param>
    public sealed class ExercisePerformInfoRepository(ApplicationDbContext context) : Repository<ExercisePerformInfo>(context), IExercisePerformInfoRepository
    {
    }
}
