using FitnessPlanner.Services.Models.MuscleGroup;

namespace FitnessPlanner.Services.Models.Exercise
{
    public record ExerciseDisplayDto(int Id, string Name, string Explanation, string PerformTip, string ImageName, IEnumerable<MuscleGroupDisplayDto> MuscleGroups)
    {
    }
}
