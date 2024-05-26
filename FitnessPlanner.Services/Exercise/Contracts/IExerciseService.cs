using FitnessPlanner.Services.Models.Exercise;

namespace FitnessPlanner.Services.Exercise.Contracts
{
    public interface IExerciseService
    {
        Task<IEnumerable<ExerciseDisplayDto>> GetAllAsync();

        Task<ExerciseDisplayDto?> GetById(int id);

        Task<ExerciseDeleteDto?> GetByIdAsDeleteDtoAsync(int id);

        Task<int> CreateAsync(ExerciseCreateDto model);

        Task UpdateAsync(ExerciseUpdateDto model);

        Task DeleteAsync(int id);
    }
}
