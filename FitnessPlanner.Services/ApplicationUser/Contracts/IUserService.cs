using FitnessPlanner.Services.Models.User;

namespace FitnessPlanner.Services.ApplicationUser.Contracts
{
    public interface IUserService
    {
        Task<UserPreferencesDto?> GetByIdAsUserPreferenceDtoAsync(string userId);
    }
}
