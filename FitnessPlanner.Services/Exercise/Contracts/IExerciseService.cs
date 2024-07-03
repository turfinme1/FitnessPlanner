using FitnessPlanner.Services.Models.Exercise;

namespace FitnessPlanner.Services.Exercise.Contracts
{
    public interface IExerciseService
    {
        Task<IEnumerable<ExerciseDisplayDto>> GetAllAsync();

        Task<ExerciseDisplayDto?> GetByIdAsync(int id);

        Task<IEnumerable<ExerciseDisplayDto>?> GetAllByMuscleGroupAsync(string muscleGroupName);

        Task<ExerciseDeleteDto?> GetByIdAsDeleteDtoAsync(int id);

        Task<int> CreateAsync(ExerciseCreateDto model);

        Task UpdateAsync(ExerciseUpdateDto model);

        Task DeleteAsync(int id);
    }
}
