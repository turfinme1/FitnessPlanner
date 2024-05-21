using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Services.ApplicationUser.Contracts;
using FitnessPlanner.Services.Models.User;
using Microsoft.Extensions.Logging;

namespace FitnessPlanner.Services.ApplicationUser
{
    public sealed class UserService(
        IUnitOfWork repositoryManager,
        ILogger<UserService> logger) : IUserService
    {
        public async Task<UserPreferencesDto?> GetByIdAsUserPreferenceDtoAsync(string userId)
        {
            try
            {
                var user = await repositoryManager.Users.GetByIdWithRelatedEntitiesAsync(userId);
                ArgumentNullException.ThrowIfNull(user);

                var userDto = new UserPreferencesDto()
                {
                    Id = user.Id,
                    Goal = user.Goal.Name,
                    SkillLevel = user.SkillLevel.Name,
                    BodyMassIndexMeasures = user.BodyMassIndexMeasure.Type
                };

                return userDto;
            }
            catch (Exception e)
            {
                logger.LogError($"{nameof(GetByIdAsUserPreferenceDtoAsync)}: User not found exception");
                throw;
            }
        }
    }
}
