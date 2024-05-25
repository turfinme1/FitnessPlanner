using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Services.Exercise.Contracts;
using FitnessPlanner.Services.Models.Exercise;
using FitnessPlanner.Services.Models.MuscleGroup;
using Microsoft.Extensions.Logging;

namespace FitnessPlanner.Services.Exercise
{
    public sealed class ExerciseService(
        IUnitOfWork repositoryManager,
        ILogger<ExerciseService> logger) : IExerciseService
    {
        public async Task<IEnumerable<ExerciseDisplayDto>> GetAllAsync()
        {
            try
            {
                var exercises = await repositoryManager.Exercises.GetAllWithRelatedEntitiesAsync();

                return exercises.Select(e => new ExerciseDisplayDto(
                    Id: e.Id,
                    Name: e.Name,
                    Explanation: e.Explanation,
                    PerformTip: e.PerformTip,
                    ImageName: e.ImageName,
                    MuscleGroups: e.ExerciseMuscleGroups.Select(mg =>
                        new MuscleGroupDisplayDto(Name: mg.MuscleGroup.Name))));
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetAllAsync)}");
                throw;
            }
        }
    }
}
