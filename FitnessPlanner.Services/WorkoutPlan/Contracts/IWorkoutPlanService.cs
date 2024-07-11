using Ardalis.Result;
using FitnessPlanner.Services.Models.WorkoutPlan;

namespace FitnessPlanner.Services.WorkoutPlan.Contracts
{
    public interface IWorkoutPlanService
    {
        Task<Result<IEnumerable<WorkoutPlanDisplayDto>>> GetAllAsync();

        Task<Result<WorkoutPlanDisplayDto>> GetByIdAsync(int id);

        Task<Result<IEnumerable<WorkoutPlanPropertiesDto>>> GetAllWorkoutsWithPreferencesAsync();

        Task<Result<WorkoutPlanDisplayDto>> CreateAsync(string? userClaimId, WorkoutPlanCreateDto model);

        Task<Result> UpdateAsync(int workoutId, string? userClaimId, WorkoutPlanUpdateDto model);

        Task<Result> DeleteAsync(string? userClaimId, int id);
    }
}
