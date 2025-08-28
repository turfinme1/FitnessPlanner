using Ardalis.Result;
using FitnessPlanner.Services.Models.Exercise;

namespace FitnessPlanner.Services.Exercise.Contracts
{
    public interface IExerciseService
    {
        Task<Result<IEnumerable<ExerciseDisplayDto>>> GetAllAsync();

        Task<Result<ExerciseDisplayDto>> GetByIdAsync(int id);

        Task<Result<IEnumerable<ExerciseDisplayDto>>> GetAllByMuscleGroupAsync(string muscleGroupName);

        Task<Result<ExerciseDisplayDto>> CreateAsync(ExerciseCreateDto model);

        Task<Result> UpdateAsync(int exerciseId, ExerciseUpdateDto model);

        Task<Result> DeleteAsync(int id);
    }
}
