using Ardalis.Result;
using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Data.Models;
using FitnessPlanner.Services.Models.ExercisePerformInfo;
using FitnessPlanner.Services.Models.SingleWorkout;
using FitnessPlanner.Services.Models.WorkoutPlan;
using FitnessPlanner.Services.WorkoutPlan.Contracts;
using Microsoft.Extensions.Logging;

namespace FitnessPlanner.Services.WorkoutPlan
{
    public sealed class WorkoutPlanService(
        IUnitOfWork repositoryManager,
        ILogger<WorkoutPlanService> logger) : IWorkoutPlanService
    {
        public async Task<Result<IEnumerable<WorkoutPlanDisplayDto>>> GetAllAsync()
        {
            try
            {
                var result = (await repositoryManager.WorkoutPlans.GetAllWithRelatedEntitiesAsync())
                    .Select(wp => new WorkoutPlanDisplayDto()
                    {
                        Id = wp.Id,
                        Name = wp.Name,
                        Goal = wp.Goal.Name,
                        SkillLevel = wp.SkillLevel.Name,
                        Workouts = wp.SingleWorkoutWorkoutPlans.Select(swwp => new SingleWorkoutDto()
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

                return Result<IEnumerable<WorkoutPlanDisplayDto>>.Success(result);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetAllAsync)}");
                throw;
            }
        }

        public async Task<Result<WorkoutPlanDisplayDto>> GetByIdAsync(int id)
        {
            try
            {
                var workoutPlan = await repositoryManager.WorkoutPlans.GetByIdWithRelatedEntitiesAsync(id);
                if (workoutPlan is null)
                {
                    return Result.NotFound($"Workout plan with Id: {id} doesn't exist.");
                }

                var result = new WorkoutPlanDisplayDto()
                {
                    Id = workoutPlan.Id,
                    Name = workoutPlan.Name,
                    Goal = workoutPlan.Goal.Name,
                    SkillLevel = workoutPlan.SkillLevel.Name,
                    Workouts = workoutPlan.SingleWorkoutWorkoutPlans.Select(swwp => new SingleWorkoutDto()
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
                };

                return Result<WorkoutPlanDisplayDto>.Success(result);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetByIdAsync)}");
                throw;
            }
        }

        public async Task<Result<IEnumerable<WorkoutPlanPropertiesDto>>> GetAllWorkoutsWithPreferencesAsync()
        {
            try
            {
                var result = (await repositoryManager.WorkoutPlans.GetAllWithRelatedEntitiesAsync())
                    .Select(wp => new WorkoutPlanPropertiesDto()
                    {
                        Id = wp.Id,
                        Goal = wp.Goal.Name,
                        SkillLevel = wp.SkillLevel.Name,
                        BodyMassIndexMeasures = wp.WorkoutPlanBodyMassIndexMeasures.Select(x => x.BodyMassIndexMeasure.Type)
                    });

                return Result<IEnumerable<WorkoutPlanPropertiesDto>>.Success(result);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetAllWorkoutsWithPreferencesAsync)}");
                throw;
            }
        }

        public async Task<Result<WorkoutPlanDisplayDto>> CreateAsync(string? userClaimId, WorkoutPlanCreateDto model)
        {
            if (userClaimId is null)
            {
                return Result.Unauthorized();
            }

            var entity = new Data.Models.WorkoutPlan()
            {
                Name = model.Name,
                UserId = userClaimId,
                SkillLevelId = model.SkillLevelId,
                GoalId = model.GoalId,
                SingleWorkoutWorkoutPlans = model.SingleWorkouts
                    .Select(w => new SingleWorkoutWorkoutPlan()
                    {
                        SingleWorkout = new SingleWorkout()
                        {
                            Name = w.Name,
                            Day = w.Day,
                            ExercisePerformInfoSingleWorkouts = w.ExercisePerformInfos.Select(epi => new ExercisePerformInfoSingleWorkout()
                            {
                                ExercisePerformInfo = new ExercisePerformInfo()
                                {
                                    ExerciseId = epi.ExerciseId,
                                    Sets = epi.Sets,
                                    Reps = epi.Reps
                                }
                            }).ToList()
                        }
                    }).ToList(),
                WorkoutPlanBodyMassIndexMeasures = model.BodyMassIndexMeasures.Select(bmi => new WorkoutPlanBodyMassIndexMeasure()
                {
                    BodyMassIndexMeasureId = bmi
                }).ToList()
            };

            try
            {
                repositoryManager.WorkoutPlans.Add(entity);
                await repositoryManager.SaveChangesAsync();

                var workoutPlanDto = await GetByIdAsync(entity.Id);
                return Result<WorkoutPlanDisplayDto>.Success(workoutPlanDto);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(CreateAsync)}");
                throw;
            }
        }

        public async Task<Result> UpdateAsync(int workoutId, string? userClaimId, WorkoutPlanUpdateDto model)
        {
            if (workoutId != model.Id)
            {
                return Result.Error("Workout ID mismatch.");
            }

            try
            {
                var entity = await repositoryManager.WorkoutPlans.GetByIdWithRelatedEntitiesAsync(model.Id, isTracked: true);

                if (entity is null)
                {
                    return Result.NotFound($"WorkoutPlan with Id: {model.Id} doesn't exist.");
                }

                if (entity.UserId != userClaimId)
                {
                    return Result.Unauthorized();
                }

                entity.Name = model.Name;
                entity.SkillLevelId = model.SkillLevelId;
                entity.GoalId = model.GoalId;
                entity.SingleWorkoutWorkoutPlans = model.SingleWorkouts
                    .Select(w => new SingleWorkoutWorkoutPlan()
                    {
                        SingleWorkout = new SingleWorkout()
                        {
                            Name = w.Name,
                            Day = w.Day,
                            ExercisePerformInfoSingleWorkouts = w.ExercisePerformInfos.Select(epi => new ExercisePerformInfoSingleWorkout()
                            {
                                ExercisePerformInfo = new ExercisePerformInfo()
                                {
                                    ExerciseId = epi.ExerciseId,
                                    Sets = epi.Sets,
                                    Reps = epi.Reps
                                }
                            }).ToList()
                        }
                    }).ToList();

                var bodyMassIndexMeasures = model.BodyMassIndexMeasures
                    .SkipWhile(x => entity.WorkoutPlanBodyMassIndexMeasures.Any(y => y.BodyMassIndexMeasureId == x));

                entity.WorkoutPlanBodyMassIndexMeasures = bodyMassIndexMeasures
                    .Select(bmi => new WorkoutPlanBodyMassIndexMeasure()
                    {
                        BodyMassIndexMeasureId = bmi
                    }).ToList();

                await repositoryManager.SaveChangesAsync();
                return Result.Success();
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetAllAsync)}");
                throw;
            }
        }

        public async Task<Result> DeleteAsync(string? userClaimId, int id)
        {
            try
            {
                var entity = await repositoryManager.WorkoutPlans.GetByIdAsync(id);

                if (entity is null)
                {
                    return Result.NotFound($"Workout plan with Id: {id} doesn't exist.");
                }

                if (entity.UserId != userClaimId)
                {
                    return Result.Unauthorized();
                }

                repositoryManager.WorkoutPlans.Remove(entity);
                await repositoryManager.SaveChangesAsync();
                return Result.Success();
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(DeleteAsync)}");
                throw;
            }
        }
    }
}
