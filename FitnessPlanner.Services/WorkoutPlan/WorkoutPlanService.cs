using FitnessPlanner.Data.Contracts;
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
                        Exercises = swwp.SingleWorkout.ExercisePerformInfoSingleWorkouts.Select(episw => new ExercisePerformInfoDto()
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
    }
}
