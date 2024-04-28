using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Data.Models;

namespace FitnessPlanner.Data.Repositories
{
    public sealed class SingleWorkoutRepository(ApplicationDbContext context) : Repository<SingleWorkout>(context), ISingleWorkoutRepository
    {
    }
}
