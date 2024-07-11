using Ardalis.Result;
using FitnessPlanner.Services.Models.WorkoutPlan;

namespace FitnessPlanner.Services.CosineSimilarityCalculation.Contracts
{
    public interface ICosineSimilarityCalculationService
    {
        Task<Result<WorkoutPlanDto>> GetWorkoutIdRecommendationByUserIdAsync(string? userId);
    }
}
