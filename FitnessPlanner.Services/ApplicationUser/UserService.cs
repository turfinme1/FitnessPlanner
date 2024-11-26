using Ardalis.Result;
using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Data.Models;
using FitnessPlanner.Services.ApplicationUser.Contracts;
using FitnessPlanner.Services.BodyMassIndexCalculation.Contracts;
using FitnessPlanner.Services.Models.ExercisePerformInfo;
using FitnessPlanner.Services.Models.SingleWorkout;
using FitnessPlanner.Services.Models.User;
using FitnessPlanner.Services.Models.WorkoutPlan;
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

        public async Task<Result> AddWorkoutPlanToUserAsync(string? userId, int workoutPlanId)
        {
            if(userId is null)
            {
                return Result.Unauthorized();
            }

            try
            {
                var user = await repositoryManager.Users.GetByIdWithRelatedEntitiesAsync(userId, isTracked: true);
                if (user is null)
                {
                    return Result.NotFound($"User with Id: {userId} doesn't exist.");
                }

                var workoutPlan = await repositoryManager.WorkoutPlans.GetByIdAsync(workoutPlanId);
                if (workoutPlan is null)
                {
                    return Result.NotFound($"Workout plan with Id: {workoutPlanId} doesn't exist.");
                }

                if(user.UserWorkoutPlans.Any(uwp => uwp.WorkoutPlanId == workoutPlan.Id))
                {
                    return Result.Success();
                }

                user.UserWorkoutPlans.Add(new UserWorkoutPlan()
                {
                    WorkoutPlanId = workoutPlan.Id
                });

                await repositoryManager.SaveChangesAsync();
                return Result.Success();
            }
            catch (Exception e)
            {
                logger.LogError(e, $"{nameof(AddWorkoutPlanToUserAsync)}: Error while adding workout plan to user");
                throw;
            }
        }

        public async Task<Result> RemoveWorkoutPlanFromUserAsync(string? userId, int workoutPlanId)
        {
            if (userId is null)
            {
                return Result.Unauthorized();
            }

            try
            {
                var user = await repositoryManager.Users.GetByIdWithRelatedEntitiesAsync(userId, isTracked: true);
                if (user is null)
                {
                    return Result.NotFound($"User with Id: {userId} doesn't exist.");
                }

                var userWorkoutPlan = user.UserWorkoutPlans.FirstOrDefault(uwp => uwp.WorkoutPlanId == workoutPlanId);
                if (userWorkoutPlan is null)
                {
                    return Result.NotFound($"Workout plan with Id: {workoutPlanId} doesn't exist.");
                }

                user.UserWorkoutPlans.Remove(userWorkoutPlan);

                await repositoryManager.SaveChangesAsync();
                return Result.Success();
            }
            catch (Exception e)
            {
                logger.LogError(e, $"{nameof(RemoveWorkoutPlanFromUserAsync)}: Error while removing workout plan from user");
                throw;
            }
        }

        public async Task<Result<IEnumerable<WorkoutPlanDisplayDto>>> GetUserWorkoutPlansAsync(string? userId)
        {
            if (userId is null)
            {
                return Result.Unauthorized();
            }

            try
            {
                var user = await repositoryManager.Users.GetByIdWithRelatedEntitiesAsync(userId);
                if (user is null)
                {
                    return Result.NotFound($"User with Id: {userId} doesn't exist.");
                }

                var workoutPlans = user.UserWorkoutPlans
                .Select(uwp => uwp.WorkoutPlan)
                .Select(wp => new WorkoutPlanDisplayDto()
                {
                    Id = wp.Id,
                    Name = wp.Name,
                    Goal = wp.Goal.Name,
                    SkillLevel = wp.SkillLevel.Name,
                    Workouts = wp.SingleWorkoutWorkoutPlans.Select(swwp=> new SingleWorkoutDto()
                    {
                        Id = swwp.SingleWorkout.Id,
                        Name = swwp.SingleWorkout.Name,
                        Day = (int)swwp.SingleWorkout.Day,
                        Exercises = swwp.SingleWorkout.ExercisePerformInfoSingleWorkouts.Select(episw =>
                            new ExercisePerformInfoDto()
                            {
                                Id = episw.ExercisePerformInfo.Id,
                                ExerciseName = episw.ExercisePerformInfo.Exercise.Name,
                                Sets = episw.ExercisePerformInfo.Sets,
                                Reps = episw.ExercisePerformInfo.Reps
                            })
                    })
                });
                
                return Result<IEnumerable<WorkoutPlanDisplayDto>>.Success(workoutPlans);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"{nameof(GetUserWorkoutPlansAsync)}: Error while retrieving user's workout plans");
                throw;
            }
        }
    }
}
