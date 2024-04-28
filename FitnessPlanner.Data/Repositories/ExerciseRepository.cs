using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Data.Models;

namespace FitnessPlanner.Data.Repositories
{
    public sealed class ExerciseRepository(ApplicationDbContext context) : Repository<Exercise>(context), IExerciseRepository
    {
    }
}
