using Ardalis.Result;
using FitnessPlanner.Services.Models.User;

namespace FitnessPlanner.Services.Admin.Contracts
{
    public interface IAdminService
    {
        Task<Result<IEnumerable<UserDisplayDto>>> GetAllUsersAsync();
    }
}
