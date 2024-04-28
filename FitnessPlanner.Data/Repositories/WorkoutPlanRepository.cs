using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Data.Models;

namespace FitnessPlanner.Data.Repositories
{
    public sealed class WorkoutPlanRepository(ApplicationDbContext context) : Repository<WorkoutPlan>(context), IWorkoutPlanRepository
    {
    }
    
}
