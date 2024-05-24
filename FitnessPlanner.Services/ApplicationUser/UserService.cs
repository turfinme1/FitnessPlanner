using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Data.Models;
using FitnessPlanner.Services.ApplicationUser.Contracts;
using FitnessPlanner.Services.BodyMassIndexCalculation.Contracts;
using FitnessPlanner.Services.Models.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace FitnessPlanner.Services.ApplicationUser
{
    public sealed class UserService(
        IUnitOfWork repositoryManager,
        UserManager<User> userManager,
        IBodyMassIndexCalculationService bodyMassCalculationService,
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
                logger.LogError($"{nameof(GetByIdAsUserPreferenceDtoAsync)}: User not found");
                throw;
            }
        }

        public async Task<IdentityResult> UpdateAsync(UserDataUpdateDto userPreferencesDto)
        {   
            try
            {
                var user = await userManager.FindByIdAsync(userPreferencesDto.Id);
                if (user is null)
                {
                    throw new ArgumentNullException(nameof(user));
                }

                if (user.Name != userPreferencesDto.Name)
                {
                    user.Name = userPreferencesDto.Name;
                }

                if (user.Gender != userPreferencesDto.Gender)
                {
                    user.Gender = userPreferencesDto.Gender;
                }

                if (user.Age != userPreferencesDto.Age)
                {
                    user.Age = userPreferencesDto.Age;
                }

                if (user.Height != userPreferencesDto.Height)
                {
                    user.Height = userPreferencesDto.Height;
                }

                if (user.Weight != userPreferencesDto.Weight)
                {
                    user.Weight = userPreferencesDto.Weight;
                }

                if (user.SkillLevelId != userPreferencesDto.SkillLevelId)
                {
                    user.SkillLevelId = userPreferencesDto.SkillLevelId;
                }

                if (user.GoalId != userPreferencesDto.GoalId)
                {
                    user.GoalId = userPreferencesDto.GoalId;
                }

                user.BodyMassIndexMeasureId = bodyMassCalculationService
                        .GetBodyMassIndexMeasureId(userPreferencesDto.Weight, userPreferencesDto.Height);

                return await userManager.UpdateAsync(user);
            }
            catch (Exception e)
            {
                logger.LogError($"{nameof(UpdateAsync)}: Update failed");
                throw;
            }
        }
    }
}
