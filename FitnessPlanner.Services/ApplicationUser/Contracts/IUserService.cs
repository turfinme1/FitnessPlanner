using FitnessPlanner.Services.Models.User;
using Microsoft.AspNetCore.Identity;

namespace FitnessPlanner.Services.ApplicationUser.Contracts
{
    public interface IUserService
    {
        Task<UserPreferencesDto?> GetByIdAsUserPreferenceDtoAsync(string userId);
        Task<IdentityResult> UpdateAsync(UserDataUpdateDto userPreferencesDto);
    }
}
