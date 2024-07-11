using Ardalis.Result;
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
        public async Task<Result<IEnumerable<ExerciseDisplayDto>>> GetAllAsync()
        {
            try
            {
                var exercises = await repositoryManager.Exercises.GetAllWithRelatedEntitiesAsync();
                var exerciseDtos = exercises.Select(e => new ExerciseDisplayDto(
                    Id: e.Id,
                    Name: e.Name,
                    Explanation: e.Explanation,
                    PerformTip: e.PerformTip,
                    ImageName: e.ImageName,
                    MuscleGroups: e.ExerciseMuscleGroups.Select(mg =>
                        new MuscleGroupDisplayDto(Name: mg.MuscleGroup.Name))));

                return Result.Success(exerciseDtos);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetAllAsync)}");
                throw;
            }
        }

        public async Task<Result<ExerciseDisplayDto>> GetByIdAsync(int id)
        {
            try
            {
                var exercise = await repositoryManager.Exercises.GetByIdWithRelatedEntitiesAsync(id);

                if (exercise is null)
                {
                    return Result.NotFound($"Exercise with Id: {id} doesn't exist.");
                }

                var exerciseDto = new ExerciseDisplayDto(
                    Id: exercise.Id,
                    Name: exercise.Name,
                    Explanation: exercise.Explanation,
                    PerformTip: exercise.PerformTip,
                    ImageName: exercise.ImageName,
                    MuscleGroups: exercise.ExerciseMuscleGroups.Select(mg =>
                        new MuscleGroupDisplayDto(Name: mg.MuscleGroup.Name)));

                return Result<ExerciseDisplayDto>.Success(exerciseDto);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetByIdAsync)}");
                throw;
            }
        }

        public async Task<Result<IEnumerable<ExerciseDisplayDto>>> GetAllByMuscleGroupAsync(string muscleGroupName)
        {
            try
            {
                var muscleGroupNameWithUppercase =
                    string.Concat(muscleGroupName[0].ToString().ToUpper(), muscleGroupName.AsSpan(1));

                var exercises = (await repositoryManager.Exercises
                    .GetByMuscleGroupWithRelatedEntitiesAsync(muscleGroupNameWithUppercase))
                    .ToArray();

                if (exercises.Length == 0)
                {
                    return Result.NotFound($"No exercises with specified muscle group: {muscleGroupName}.");
                }

                var exerciseDtos = exercises.Select(e => new ExerciseDisplayDto(
                    Id: e.Id,
                    Name: e.Name,
                    Explanation: e.Explanation,
                    PerformTip: e.PerformTip,
                    ImageName: e.ImageName,
                    MuscleGroups: e.ExerciseMuscleGroups.Select(mg =>
                        new MuscleGroupDisplayDto(Name: mg.MuscleGroup.Name))));

                return Result<IEnumerable<ExerciseDisplayDto>>.Success(exerciseDtos);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetAllByMuscleGroupAsync)}");
                throw;
            }
        }

        public async Task<Result<ExerciseDeleteDto>> GetByIdAsDeleteDtoAsync(int id)
        {
            try
            {
                var entity = await repositoryManager.Exercises.GetByIdAsync(id);
                if (entity is null)
                {
                    return Result.NotFound($"Exercise with Id: {id} doesn't exist.");
                }

                var dto = new ExerciseDeleteDto(entity.Id);
                return Result<ExerciseDeleteDto>.Success(dto);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(GetByIdAsDeleteDtoAsync)}");
                throw;
            }
        }

        public async Task<Result<ExerciseDisplayDto>> CreateAsync(ExerciseCreateDto model)
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

                var exerciseDto =await GetByIdAsync(entity.Id);
                return Result<ExerciseDisplayDto>.Created(exerciseDto);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(CreateAsync)}");
                throw;
            }
        }

        public async Task<Result> UpdateAsync(int exerciseId, ExerciseUpdateDto model)
        {
            if (exerciseId != model.Id)
            {
                return Result.Error("Exercise ID mismatch.");
            }

            try
            {
                var entity = await repositoryManager.Exercises.GetByIdWithRelatedEntitiesAsync(model.Id, isTracked: true);

                if (entity is null)
                {
                    return Result.NotFound($"Exercise with Id: {model.Id} doesn't exist.");
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
                return Result.Success();
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(UpdateAsync)}");
                throw;
            }
        }

        public async Task<Result> DeleteAsync(int id)
        {
            try
            {
                var entity = await repositoryManager.Exercises.GetByIdAsync(id);

                if (entity is null)
                {
                    return Result.NotFound($"Exercise with Id: {id} doesn't exist.");
                }

                repositoryManager.Exercises.Remove(entity);
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
