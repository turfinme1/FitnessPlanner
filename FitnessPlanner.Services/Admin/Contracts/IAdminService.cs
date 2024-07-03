using FitnessPlanner.Services.Models.User;

namespace FitnessPlanner.Services.Admin.Contracts
{
    public interface IAdminService
    {
        Task<IEnumerable<UserDisplayDto>> GetAllUsersAsync();
    }
}
