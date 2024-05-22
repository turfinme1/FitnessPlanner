using FitnessPlanner.Data.Models;

namespace FitnessPlanner.Data.Contracts
{
    public interface IWorkoutPlanRepository : IRepository<WorkoutPlan>
    {
        Task<List<WorkoutPlan>> GetAllWithRelatedEntitiesAsync();

        Task<WorkoutPlan?> GetByIdWithRelatedEntitiesAsync(int id, bool isTracked = false);
    }
}
