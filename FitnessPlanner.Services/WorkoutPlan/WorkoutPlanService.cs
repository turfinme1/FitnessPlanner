﻿using FitnessPlanner.Data.Contracts;
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
        public async Task<IEnumerable<WorkoutPlanDto>> GetAllAsync()
        {
            try
            {
                return (await repositoryManager.WorkoutPlans.GetAllWithRelatedEntitiesAsync()).Select(wp => new WorkoutPlanDto()
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
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetAllAsync)}");
                throw;
            }
        }

        public async Task<WorkoutPlanDto?> GetByIdAsync(int id)
        {
            try
            {
                var workoutPlan = await repositoryManager.WorkoutPlans.GetByIdWithRelatedEntitiesAsync(id);
                if (workoutPlan == null)
                {
                    return null;
                }

                return new WorkoutPlanDto()
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
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetByIdAsync)}");
                throw;
            }
        }

        public async Task<IEnumerable<WorkoutPlanPropertiesDto>> GetAllWorkoutsWithPreferencesAsync()
        {
            try
            {
                return (await repositoryManager.WorkoutPlans.GetAllWithRelatedEntitiesAsync()).Select(wp =>
                    new WorkoutPlanPropertiesDto()
                    {
                        Id = wp.Id,
                        Goal = wp.Goal.Name,
                        SkillLevel = wp.SkillLevel.Name,
                        BodyMassIndexMeasures = wp.WorkoutPlanBodyMassIndexMeasures.Select(x=> x.BodyMassIndexMeasure.Type)
                    });
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetAllWorkoutsWithPreferencesAsync)}");
                throw;
            }
        }
    }
}
