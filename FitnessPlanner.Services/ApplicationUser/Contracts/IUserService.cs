using Ardalis.Result;
using FitnessPlanner.Services.Models.User;
using FitnessPlanner.Services.Models.WorkoutPlan;

namespace FitnessPlanner.Services.ApplicationUser.Contracts
{
    public interface IUserService
    {
        Task<Result<UserPreferencesDto>> GetByIdAsUserPreferenceDtoAsync(string userId);

        Task<Result> UpdateAsync(string? userClaimId, UserDataUpdateDto userPreferencesDto);

        Task<Result<UserDataFormDto>> GetByIdAsUserDataFormDtoAsync(string? userId);

        Task<Result> AddWorkoutPlanToUserAsync(string? userId, int workoutPlanId);

        Task<Result> RemoveWorkoutPlanFromUserAsync(string? userId, int workoutPlanId);

        Task<Result<IEnumerable<WorkoutPlanDisplayDto>>> GetUserWorkoutPlansAsync(string? userId);
    }
}
