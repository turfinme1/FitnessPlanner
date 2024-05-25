using FitnessPlanner.Data.Models;

namespace FitnessPlanner.Data.Contracts
{
    public interface IExerciseRepository : IRepository<Exercise>
    {
        Task<IEnumerable<Exercise>> GetAllWithRelatedEntitiesAsync();

        Task<Exercise?> GetByIdWithRelatedEntitiesAsync(int id);
    }
}
