using Ardalis.Result;
using FitnessPlanner.Services.Models.User;

namespace FitnessPlanner.Services.ApplicationUser.Contracts
{
    public interface IUserService
    {
        Task<Result<UserPreferencesDto>> GetByIdAsUserPreferenceDtoAsync(string userId);

        Task<Result> UpdateAsync(string? userClaimId, UserDataUpdateDto userPreferencesDto);

        Task<Result<UserDataFormDto>> GetByIdAsUserDataFormDtoAsync(string? userId);
    }
}
