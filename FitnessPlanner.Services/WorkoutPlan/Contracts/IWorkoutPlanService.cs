using FitnessPlanner.Services.Models.WorkoutPlan;

namespace FitnessPlanner.Services.WorkoutPlan.Contracts
{
    public interface IWorkoutPlanService
    {
        Task<IEnumerable<WorkoutPlanDto>> GetAllAsync();
    }
}
