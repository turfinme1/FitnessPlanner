using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Data.Models;

namespace FitnessPlanner.Data.Repositories
{
    public sealed class ExercisePerformInfoRepository(ApplicationDbContext context) : Repository<ExercisePerformInfo>(context), IExercisePerformInfoRepository
    {
    }
}
