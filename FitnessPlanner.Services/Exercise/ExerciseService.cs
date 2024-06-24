using System.Security.Cryptography.X509Certificates;
using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Data.Models;
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

        public async Task<ExerciseDisplayDto?> GetByIdAsync(int id)
        {
            try
            {
                var exercise = await repositoryManager.Exercises.GetByIdWithRelatedEntitiesAsync(id);

                if (exercise == null)
                {
                    return null;
                }

                return new ExerciseDisplayDto(
                    Id: exercise.Id,
                    Name: exercise.Name,
                    Explanation: exercise.Explanation,
                    PerformTip: exercise.PerformTip,
                    ImageName: exercise.ImageName,
                    MuscleGroups: exercise.ExerciseMuscleGroups.Select(mg =>
                        new MuscleGroupDisplayDto(Name: mg.MuscleGroup.Name)));
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetByIdAsync)}");
                throw;
            }
        }

        public async Task<IEnumerable<ExerciseDisplayDto>?> GetAllByMuscleGroupAsync(string muscleGroupName)
        {
            try
            {
                var muscleGroupNameWithUppercase =
                    string.Concat(muscleGroupName[0].ToString().ToUpper(), muscleGroupName.AsSpan(1));

                var exercises = (await repositoryManager.Exercises
                    .GetByMuscleGroupWithRelatedEntitiesAsync(muscleGroupNameWithUppercase))
                    .ToArray();

                if (exercises.Any() == false)
                {
                    return null;
                }

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
                logger.LogError(e, $"Error in {nameof(GetAllByMuscleGroupAsync)}");
                throw;
            }
        }

        public async Task<ExerciseDeleteDto?> GetByIdAsDeleteDtoAsync(int id)
        {
            try
            {
                var entity = await repositoryManager.Exercises.GetByIdAsync(id);
                if (entity is null)
                {
                    return null;
                }

                return new ExerciseDeleteDto(entity.Id);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetByIdAsDeleteDtoAsync)}");
                throw;
            }
        }

        public async Task<int> CreateAsync(ExerciseCreateDto model)
        {
            var entity = new Data.Models.Exercise()
            {
                Name = model.Name,
                Explanation = model.Explanation,
                PerformTip = model.PerformTip,
                ImageName = model.ImageName,
                ExerciseMuscleGroups = model.MuscleGroups
                    .Select(mgId => new ExerciseMuscleGroup()
                    {
                        MuscleGroupId = mgId
                    })
                    .ToList()
            };

            try
            {
                repositoryManager.Exercises.Add(entity);
                await repositoryManager.SaveChangesAsync();

                return entity.Id;
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(CreateAsync)}");
                throw;
            }
        }

        public async Task UpdateAsync(ExerciseUpdateDto model)
        {
            try
            {
                var entity = await repositoryManager.Exercises.GetByIdWithRelatedEntitiesAsync(model.Id, isTracked: true);

                if (entity is null)
                {
                    throw new ArgumentException($"Exercise with id {model.Id} not found");
                }

                entity.Name = model.Name;
                entity.Explanation = model.Explanation;
                entity.PerformTip = model.PerformTip;
                entity.ImageName = model.ImageName;
                entity.ExerciseMuscleGroups = model.MuscleGroups.Select(mgId => new ExerciseMuscleGroup()
                {
                    MuscleGroupId = mgId
                }).ToList();

                await repositoryManager.SaveChangesAsync();
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(UpdateAsync)}");
                throw;
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                var entity = await repositoryManager.Exercises.GetByIdAsync(id);

                if (entity is not null)
                {
                    repositoryManager.Exercises.Remove(entity);
                    await repositoryManager.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(DeleteAsync)}");
                throw;
            }
        }
    }
}
