using FitnessPlanner.Services.Models.Exercise;

namespace FitnessPlanner.Services.Exercise.Contracts
{
    public interface IExerciseService
    {
        Task<IEnumerable<ExerciseDisplayDto>> GetAllAsync();
    }
}
