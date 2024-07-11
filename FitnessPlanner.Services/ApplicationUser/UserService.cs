using Ardalis.Result;
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
        public async Task<Result<UserPreferencesDto>> GetByIdAsUserPreferenceDtoAsync(string userId)
        {
            try
            {
                var user = await repositoryManager.Users.GetByIdWithRelatedEntitiesAsync(userId);

                if (user is null)
                {
                    return Result<UserPreferencesDto>.NotFound($"User with Id: {userId} doesn't exist.");
                }

                var userDto = new UserPreferencesDto()
                {
                    Id = user.Id,
                    Goal = user.Goal.Name,
                    SkillLevel = user.SkillLevel.Name,
                    BodyMassIndexMeasures = user.BodyMassIndexMeasure.Type
                };

                return Result<UserPreferencesDto>.Success(userDto);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"{nameof(GetByIdAsUserPreferenceDtoAsync)}: Error while retrieving user");
                throw;
            }
        }

        public async Task<Result> UpdateAsync(string? userClaimId, UserDataUpdateDto userPreferencesDto)
        {
            if (userClaimId != userPreferencesDto.Id)
            {
                return Result.Unauthorized();
            }

            try
            {
                var user = await userManager.FindByIdAsync(userPreferencesDto.Id);
                if (user is null)
                {
                    return Result.NotFound($"User with Id: {userPreferencesDto.Id} doesn't exist.");
                }

                if (user.Name != userPreferencesDto.Name)
                {
                    user.Name = userPreferencesDto.Name;
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

                var identityResult = await userManager.UpdateAsync(user);

                return identityResult.Succeeded
                    ? Result.Success()
                    : Result.Error("Update failed");
            }
            catch (Exception e)
            {
                logger.LogError(e, $"{nameof(UpdateAsync)}: Error while updating user");
                throw;
            }
        }

        public async Task<Result<UserDataFormDto>> GetByIdAsUserDataFormDtoAsync(string? userId)
        {
            if (userId is null)
            {
                return Result.Unauthorized();
            }

            try
            {
                var user = await repositoryManager.Users.GetByIdAsync(userId);
                if (user is null)
                {
                    return Result.NotFound($"User with Id: {userId} doesn't exist.");
                }

                var userDto = new UserDataFormDto()
                {
                    Name = user.Name,
                    Age = user.Age,
                    Height = user.Height,
                    Weight = user.Weight,
                    SkillLevelId = user.SkillLevelId,
                    GoalId = user.GoalId
                };

                return Result<UserDataFormDto>.Success(userDto);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"{nameof(GetByIdAsUserDataFormDtoAsync)}: Error while retrieving user");
                throw;
            }
        }
    }
}
