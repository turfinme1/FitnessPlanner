using FitnessPlanner.Services.Models.WorkoutPlan;

namespace FitnessPlanner.Services.CosineSimilarityCalculation.Contracts
{
    public interface ICosineSimilarityCalculationService
    {
        Task<WorkoutPlanDto> GetWorkoutIdRecommendationByUserIdAsync(string userId);
    }
}
