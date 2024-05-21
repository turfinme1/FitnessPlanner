using FitnessPlanner.Data.Models;

namespace FitnessPlanner.Data.Contracts
{
    public interface IUserRepository : IRepository<User>
    {
        Task<IEnumerable<User>> GetAllWithRelatedEntitiesAsync();
        Task<User?> GetByIdWithRelatedEntitiesAsync(string id);
    }
}
